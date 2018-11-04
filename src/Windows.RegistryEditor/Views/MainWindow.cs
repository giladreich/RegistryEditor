using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.RegistryEditor.Events;
using Windows.RegistryEditor.Utils;
using Microsoft.Win32;

using static System.Environment;

namespace Windows.RegistryEditor.Views
{
    public partial class MainWindow : Form
    {

        private FindWindow refFindWindow;
        public FindWindow FindInstance
        {
            get
            {
                if (refFindWindow != null && !refFindWindow.IsDisposed)
                {
                    refFindWindow.Activate();;
                    return refFindWindow;
                }
                refFindWindow = new FindWindow();
                refFindWindow.FoundSingleResult += SingleResultFound;
                refFindWindow.ProgressStarted += ProgressStarted;
                refFindWindow.ProgressChanged += ProgressChanged;
                refFindWindow.ProgressFinished += ProgressFinished;
                refFindWindow.FormClosed += delegate { this.Activate(); };
                return refFindWindow;
            }
        }

        private void ProgressStarted(object sender, ProgressStartedArgs e)
        {
            lvwResults.Items.Clear();
            lblResultsCount.Text = "Results Count: 0";
            Console.WriteLine(e.Message);
        }

        private void ProgressChanged(object sender, ProgressChangedArgs e)
        {
            Text = $"Registry Editor | Collecting Data from {e.Hive}";
            Console.WriteLine(e.Message);
        }

        private void ProgressFinished(object sender, ProgressFinishedArgs e)
        {
            Text = "Registry Editor";
            Console.WriteLine(e.Message);
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitializeRegistryTree();
        }

        private void TreeViewBeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count != 1 || e.Node.Nodes[0].Text != String.Empty) return;

            e.Node.Nodes.Clear();
            if (!(e.Node.Tag is RegistryKey key)) return;

            foreach (string name in key.GetSubKeyNames())
            {
                e.Node.Nodes.Add(name, name);
                if (name == "SECURITY" || name == "SAM") continue;

                RegistryKey subKey = key.OpenSubKey(name);
                e.Node.Nodes[name].Tag = subKey;
                if (subKey.SubKeyCount > 0)
                    e.Node.Nodes[name].Nodes.Add(String.Empty);
            }
        }

        private async void SingleResultFound(object sender, FindSingleResultArgs e)
        {
            await Task.Run(() => 
                lvwResults.InvokeSafe(() => 
                    AddItem(e.Match, true, cbxScrollToCaret.Checked)
                ));
        }

        private void AddItem(string text, bool isChecked, bool isVisible)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(text);
            item.Checked = isChecked;

            lvwResults.Items.Add(item);
            int count = lvwResults.Items.Count;
            lblResultsCount.Text = $"Results Count: {count}";
            if (isVisible)
                lvwResults.EnsureVisible(count - 1);
            //lvwResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                if (!FindInstance.Visible)
                    FindInstance.Show(this);
            }
            else if (lvwResults.Focused && e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetData(DataFormats.StringFormat, lvwResults.GetAllSelectedSubItemsText(1));
            }
            else if (lvwResults.Focused && e.Control && e.KeyCode == Keys.A)
            {
                lvwResults.SelectAllItems();
            }
        }

        private void LvwResults_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                RegistryUtils.OpenRegistryLocation(lvwResults.FocusedItem.SubItems[1].Text);
        }

        private void CbxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            lvwResults.CheckAllItems(cbxSelectAll.Checked);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            List<string> hives = lvwResults.GetAllCheckedSubItemsTextList(1);
            if (hives.Count < 1) return;

            if (!hives.First().StartsWith("HKEY_"))
            {
                MessageBox.Show("Deleting or Exporting registry keys on remote machines not implemented.",
                    "NOT IMPLEMENTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "All registries that are checked will be removed from registry including sub keys.\n" +
                "Are you sure you want to continue?", "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes) return;

            string dstDir = Path.Combine(GetFolderPath(SpecialFolder.Desktop), "Registry_Backup", $"{DateTime.Now:yy-MM-dd_hh-mm}");
            foreach (string hive in hives)
            {
                RegistryUtils.ExportHive(hive, dstDir);
                RegistryUtils.DeleteHive(hive);
                Console.WriteLine($"Registry Deleted: {hive}");
            }

            MessageBox.Show("Successfully removed checked registries.\n" +
                            "Created emergency backup of the removed registries on your desktop.", 
                            "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Utility.OpenFolderInExplorer(dstDir);
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FindInstance.Visible)
                FindInstance.Show(this);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
