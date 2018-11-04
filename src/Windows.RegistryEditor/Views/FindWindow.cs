using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.RegistryEditor.Events;
using Windows.RegistryEditor.Utils;
using Stopwatch = Windows.RegistryEditor.Utils.Stopwatch;

namespace Windows.RegistryEditor.Views
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/reg-query
    /// </summary>
    public partial class FindWindow : Form
    {
        private NetworkWindow refNetworkWindow;
        public NetworkWindow NetworkInstance
        {
            get
            {
                if (refNetworkWindow != null && !refNetworkWindow.IsDisposed)
                {
                    refNetworkWindow.Activate();
                    return refNetworkWindow;
                }
                refNetworkWindow = new NetworkWindow();
                refNetworkWindow.MachineSelected += (e) => tbxRemoteComputer.Text = e;
                refNetworkWindow.FormClosing += delegate { tbxSearch.Focus(); };
                return refNetworkWindow;
            }
        }


        private List<Process> procsList;
        private int procsExecuted;
        private bool searchInProgress;

        private AutoResetEvent procToken;
        private CancellationTokenSource cancelSrc;
        private CancellationToken cancelToken;

        public FindWindow()
        {
            InitializeComponent();
        }

        private void FindWindow_Load(object sender, EventArgs e)
        {
            cbxsHkeys.SetItemChecked(1, true);
        }

        private void BtnFindAvailableMachines_Click(object sender, EventArgs e)
        {
            NetworkInstance.ShowDialog(this);
        }

        private void BtnFindSingle_Click(object sender, EventArgs e) { }

        private async void BtnFindAll_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSearch.Text)) return;

            if (cbxRemoteSearch.Checked)
            {
                DialogResult answer = MessageBox.Show(
                    "Scanning registries through the network may take a while depending on the" +
                    "chosen filter. Are you sure you want to continue?", "INFO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (answer != DialogResult.Yes) return;
            }

            Started();
            List<string> hives = GetHkeysFilters();
            procsList = GenerateRegQueryProcs(hives);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            OnProgressStarted(this, new ProgressStartedArgs("Starting to search for registries...", hives.First()));

            searchInProgress = true;
            await ExecuteProcs(procsList);
            searchInProgress = false;
            procToken.Set();

            stopwatch.Stop();
            OnProgressFinished(this, new ProgressFinishedArgs("Finished searching for registries."));
            Stopped();

            Activate();
            MessageBox.Show("Finished searching. Time Taken:\n" + stopwatch.Elapsed.ToString("g"), 
                "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Started()
        {
            btnFindAll.Enabled = false;
            btnCancel.Enabled = true;
            loader.Show();

            procsExecuted = 0;
            procToken = new AutoResetEvent(false);
            cancelSrc = new CancellationTokenSource();
            cancelToken = cancelSrc.Token;
        }

        private void Stopped()
        {
            Text = "Find";
            btnFindAll.Enabled = true;
            btnCancel.Enabled = false;
            loader.Hide();
        }

        /// <summary>
        /// BIG NOTE: When we search through the registry remotely, we can't really access HKCR, HKCU, HKCC but at the same time
        /// we don't really need to, as they can be found under HKLM and HKU. In other words, they're just symbolic links. i.e:
        /// ### HKEY_CLASSES_ROOT links to: ###
        /// HKEY_CURRENT_USER\Software\Classes
        /// HKEY_LOCAL_MACHINE\SOFTWARE\Classes
        /// HKEY_USERS\{UserSID}\Software\Classes
        /// HKEY_USERS\{UserSID}_Classes
        /// 
        /// ### HKEY_CURRENT_USER links to: ###
        /// HKEY_USERS\{UserSID}
        /// 
        /// ### HKEY_CURRENT_CONFIG links to: ###
        /// HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Hardware Profiles\0001
        /// HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Hardware Profiles\Current
        /// HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Hardware Profiles\0001
        /// HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Hardware Profiles\Current
        /// 
        /// Getting user SID:
        /// WindowsIdentity.GetCurrent().User
        /// whoami /user
        /// </summary>
        private List<string> GetHkeysFilters()
        {
            List<string> hives = new List<string>();
            if (cbxRemoteSearch.Checked)
            {
                hives.Add(RegistryUtils.HKLM);
                hives.Add(RegistryUtils.HKU);
                #region experimental
                //string userSID = WindowsIdentity.GetCurrent().User?.Value;
                //Debug.Assert(userSID != null, "userSID != null");
                //foreach (string hive in cbxsHkeys.CheckedItems)
                //{
                //    if (hive.Equals(RegistryUtils.HKCR))
                //        hives.Add($@"HKU\{userSID}\Software\Classes");
                //    else if (hive.Equals(RegistryUtils.HKCU))
                //        hives.Add($@"HKU\{userSID}");
                //    else if (hive.Equals(RegistryUtils.HKLM))
                //        hives.Add($@"HKLM");
                //    else if (hive.Equals(RegistryUtils.HKU))
                //        hives.Add($@"HKU");
                //    else if (hive.Equals(RegistryUtils.HKCC))
                //        hives.Add($@"HKLM\SYSTEM\CurrentControlSet\Hardware Profiles\Current");
                //}
                #endregion experimental
            }
            else
            {
                foreach (string hive in cbxsHkeys.CheckedItems)
                    hives.Add(hive);
            }

            return hives;
        }

        private List<Process> GenerateRegQueryProcs(List<string> hives)
        {
            List<Process> procs = new List<Process>();
            foreach (string hive in hives)
            {
                string searchQuery = BuildSearchQuery(RegistryUtils.GetHiveShortcut(hive));
                Process proc = CreateRegQueryProc(searchQuery);
                procs.Add(proc);
                Console.WriteLine($"{proc.StartInfo.FileName} {proc.StartInfo.Arguments}");
            }

            return procs;
        }

        private string BuildSearchQuery(string hive)
        {
            string query = String.Empty;

            if (cbxRemoteSearch.Checked)
                query = $"\"\\\\{tbxRemoteComputer.Text}\\{hive}\" /f \"{tbxSearch.Text}\" /s";
            else
                query = $"\"{hive}\" /f \"{tbxSearch.Text}\" /s";

            if (cbxKeys.Checked)          query += " /k";
            if (cbxValues.Checked)        query += " /v";
            if (cbxData.Checked)          query += " /d";
            if (cbxCaseSensitive.Checked) query += " /c";
            if (cbxMatchString.Checked)   query += " /e";
            if (cbxsDataTypes.GetItemCheckedByName("REG_MULTI_SZ")) query += " /se +";
             
            if (cbxsDataTypes.CheckedItems.Count <= 0 || cbxsDataTypes.SelectAllChecked)
                return query;

            // ------------------------ Adding Data types filters ------------------------
            query += " /t \"";
            foreach (string checkedItem in cbxsDataTypes.CheckedItems)
                query += checkedItem + ",";

            query = query.TrimEnd(',');
            query += "\"";

            // https://msdn.microsoft.com/en-us/library/windows/desktop/bb773476(v=vs.85).aspx
            // Unfortunately these are not supported by reg query when filtering...
            query = Regex.Replace(query, ",?REG_QWORD_LITTLE_ENDIAN", String.Empty);
            query = Regex.Replace(query, ",?REG_LINK", String.Empty);
            query = Regex.Replace(query, ",?REG_RESOURCE_LIST", String.Empty);

            return query;
        }

        private Process CreateRegQueryProc(string searchQuery)
        {
            ProcessStartInfo procInfo = new ProcessStartInfo
            {
                FileName = "REG",
                Arguments = $"QUERY {searchQuery}",
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process proc = new Process
            {
                StartInfo = procInfo,
                EnableRaisingEvents = true
            };

            proc.ErrorDataReceived += OnErrorDataReceived;
            proc.OutputDataReceived += OnOutputDataReceived;
            proc.Exited += OnFindEnd;

            return proc;
        }

        private async Task ExecuteProcs(IEnumerable<Process> procs)
        {
            foreach (Process proc in procs)
            {
                procsExecuted++;

                string hiveShort = proc.StartInfo.Arguments.Split('"')[1];
                string hive = cbxRemoteSearch.Checked
                    ? RegistryUtils.GetRemoteHiveFullName(hiveShort)
                    : RegistryUtils.GetHiveFullName(hiveShort);
                string message = $"Searching in {hive}...Patient :)";
                Text = $"Find | {message}";

                OnProgressChanged(this, new ProgressChangedArgs(message, hive));
                await Task.Run(() => ExecuteProc(proc));

                if (cancelToken.IsCancellationRequested)
                    break;
            }
        }

        private void ExecuteProc(Process proc)
        {
            proc.Start();
            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();

            Console.WriteLine("[Process::ExecuteProc] - Waiting for exit...");
            proc.WaitForExit();
            Console.WriteLine("[Process::ExecuteProc] - Executed Finished.");
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e?.Data == null) return;

            string hive = e.Data.TrimStart().StartsWith("HKEY_") ? e.Data : String.Empty;
            if (String.IsNullOrEmpty(hive)) return;

            if (cbxRemoteSearch.Checked)
                hive = $"{tbxRemoteComputer.Text}\\{hive}";
            
            OnFoundSingleResult(this, new FindSingleResultArgs(hive));
        }

        private void OnErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e?.Data == null) return;
            if (!e.Data.StartsWith("ERROR")) return;

            if (e.Data.Trim().StartsWith("ERROR: The network path was not found."))
            {
                MessageBox.Show($"{e.Data}\n" +
                                "Make sure that the target machine has \"Remote Registry\" service running.",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cancelSrc.Cancel();
            }
            else
            {
                MessageBox.Show("Error occured. Please contact author of this app with this message.\n" +
                                $"{e.Data}",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private async void OnFindEnd(object sender, EventArgs e)
        {
            if (procsList.Count != procsExecuted || procsExecuted == 0) return;

            await Task.Run(() => Thread.Sleep(1000));
            Console.WriteLine("[Process::OnFindEnd] - Waiting for other thread to finished.");
            procToken.WaitOne();
            Console.WriteLine("[Process::OnFindEnd] - Clearing up.");
            for (int i = 0; i < procsList.Count; i++)
            {
                procsList[i].Dispose();
                procsList[i] = null;
            }

            searchInProgress = false;
            loader.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (!searchInProgress) return;

            cancelSrc.Cancel();
            for (int i = 0; i < procsExecuted; i++)
            {
                procsList[i].CancelErrorRead();
                procsList[i].CancelOutputRead();
                if (!procsList[i].HasExited)
                    procsList[i].Kill();
            }

            procToken.Set();
        }

        private void CbxSearchInRemote_CheckedChanged(object sender, EventArgs e)
        {
            tbxRemoteComputer.Enabled = cbxRemoteSearch.Checked;
            btnFindAvailableMachines.Enabled = cbxRemoteSearch.Checked;
            gbxHkeys.Enabled = !cbxRemoteSearch.Checked;
            if (cbxRemoteSearch.Checked)
                tbxRemoteComputer.Focus();
            else
                tbxSearch.Focus();
        }

        private void FindWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys key = (Keys) e.KeyChar;
            switch (key)
            {
                case Keys.Escape:
                    Close();
                    break;

                case Keys.Return:
                    btnFindAll.PerformClick();
                    break;
            }
        }

        private async void FindWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (searchInProgress)
            {
                e.Cancel = true;
                btnCancel.PerformClick();
                await Task.Run(() => Thread.Sleep(500));
                Close();
            }
        }


        #region --- Events ---

        public event Action<object, FindResultsArgs> FoundResults;
        public event Action<object, FindSingleResultArgs> FoundSingleResult;
        public event Action<object, ProgressStartedArgs> ProgressStarted;
        public event Action<object, ProgressChangedArgs> ProgressChanged;
        public event Action<object, ProgressFinishedArgs> ProgressFinished;

        protected virtual void OnFoundResults(object sender, FindResultsArgs e) => FoundResults?.Invoke(sender, e);

        protected virtual void OnFoundSingleResult(object sender, FindSingleResultArgs e) => FoundSingleResult?.Invoke(sender, e);

        protected virtual void OnProgressStarted(object sender, ProgressStartedArgs e) => ProgressStarted?.Invoke(sender, e);

        protected virtual void OnProgressChanged(object sender, ProgressChangedArgs e) => ProgressChanged?.Invoke(sender, e);

        protected virtual void OnProgressFinished(object sender, ProgressFinishedArgs e) => ProgressFinished?.Invoke(sender, e);

        #endregion --- Events ---

        #region Slow As Hell

        //using LogQuery = Interop.MSUtil.LogQueryClass;
        //using RegistryInputFormat = Interop.MSUtil.COMRegistryInputContextClass;
        //using RegRecordSet = Interop.MSUtil.ILogRecordset;

        //private void BtnFindSingle_Click(object sender, EventArgs e)
        //{
        //    matches = new List<string>();
        //    RegRecordSet rs = null;
        //    try
        //    {
        //        LogQuery qry = new LogQuery();
        //        RegistryInputFormat registryFormat = new RegistryInputFormat();
        //        string query = $@"SELECT Path FROM HKLM WHERE Value='{tbxSearch.Text}'";
        //        rs = qry.Execute(query, registryFormat);
        //        for (; !rs.atEnd(); rs.moveNext())
        //        {
        //            matches.Add(rs.getRecord().toNativeString(""));
        //        }
        //    }
        //    finally
        //    {
        //        rs.close();
        //    }

        //    ((MainWindow)Owner).OnFoundResults(this, new FindResultsArgs(matches));
        //    Close();
        //}

        #endregion Slow As Hell
    }
}
