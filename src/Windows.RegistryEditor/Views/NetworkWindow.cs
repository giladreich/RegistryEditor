using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.RegistryEditor.Utils;

namespace Windows.RegistryEditor.Views
{
    public partial class NetworkWindow : Form
    {
        private Process proc;

        public NetworkWindow()
        {
            InitializeComponent();
        }

        private async void NetworkWindow_Load(object sender, EventArgs e)
        {
            lbxMachines.Items.Clear();

            loader.Show();
            ProcessStartInfo procInfo = new ProcessStartInfo
            {
                FileName = "NET",
                Arguments = "VIEW",
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            proc = new Process
            {
                StartInfo = procInfo,
                EnableRaisingEvents = true
            };

            proc.ErrorDataReceived += OnErrorDataReceived;
            proc.OutputDataReceived += OnOutputDataReceived;
            proc.Exited += OnFindEnd;

            await Task.Run(() => Execute(proc));
        }

        private void Execute(Process proc)
        {
            proc.Start();
            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null) return;
            if (!e.Data.StartsWith(@"\\")) return;

            lbxMachines.InvokeSafe(() => lbxMachines.Items.Add(e.Data.Trim()));
        }

        private void OnErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("ERROR occured while searching for network devices -> " + e.Data);
            loader.Hide();
        }

        private void OnFindEnd(object sender, EventArgs e)
        {
            Console.WriteLine("Finished searching for network devices.");
            loader.Hide();

            proc = null;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string machineName = lbxMachines.SelectedItem.ToString();
            OnMachineSelected(machineName.Replace(@"\\", String.Empty));
            Close();
        }

        private async void NetworkWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (proc != null)
            {
                e.Cancel = true;
                proc.CancelErrorRead();
                proc.CancelOutputRead();
                await Task.Run(() => Thread.Sleep(100));
                proc.Kill();
                proc.Dispose();
                proc = null;
                await Task.Run(() => Thread.Sleep(500));

                Close();
            }
        }

        public event Action<string> MachineSelected;

        protected virtual void OnMachineSelected(string e) => MachineSelected?.Invoke(e);
    }
}
