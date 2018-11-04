namespace Windows.RegistryEditor.Views
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Computer");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadHiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32BitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD64bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyKeyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbxScrollToCaret = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSelectAll = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblResultsCount = new System.Windows.Forms.Label();
            this.lvwResults = new Windows.RegistryEditor.Views.Controls.ListViewEx();
            this.columnCbx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HKEY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadHideToolStripMenuItem,
            this.unloadHiveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // loadHideToolStripMenuItem
            // 
            this.loadHideToolStripMenuItem.Name = "loadHideToolStripMenuItem";
            this.loadHideToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadHideToolStripMenuItem.Text = "Load Hive...";
            // 
            // unloadHiveToolStripMenuItem
            // 
            this.unloadHiveToolStripMenuItem.Name = "unloadHiveToolStripMenuItem";
            this.unloadHiveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.unloadHiveToolStripMenuItem.Text = "Unload Hive...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.modifyBinaryDataToolStripMenuItem,
            this.toolStripSeparator3,
            this.newToolStripMenuItem,
            this.toolStripSeparator5,
            this.permissionsToolStripMenuItem,
            this.toolStripSeparator6,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator7,
            this.copyKeyNameToolStripMenuItem,
            this.toolStripSeparator8,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modifyToolStripMenuItem.Text = "Modify...";
            // 
            // modifyBinaryDataToolStripMenuItem
            // 
            this.modifyBinaryDataToolStripMenuItem.Name = "modifyBinaryDataToolStripMenuItem";
            this.modifyBinaryDataToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modifyBinaryDataToolStripMenuItem.Text = "Modify Binary Data...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem,
            this.toolStripSeparator4,
            this.stringValueToolStripMenuItem,
            this.binaryValueToolStripMenuItem,
            this.dWORD32BitValueToolStripMenuItem,
            this.dWORD64bitValueToolStripMenuItem,
            this.multiStringValueToolStripMenuItem,
            this.expandableStringValueToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.keyToolStripMenuItem.Text = "Key";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // stringValueToolStripMenuItem
            // 
            this.stringValueToolStripMenuItem.Name = "stringValueToolStripMenuItem";
            this.stringValueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.stringValueToolStripMenuItem.Text = "String Value";
            // 
            // binaryValueToolStripMenuItem
            // 
            this.binaryValueToolStripMenuItem.Name = "binaryValueToolStripMenuItem";
            this.binaryValueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.binaryValueToolStripMenuItem.Text = "Binary Value";
            // 
            // dWORD32BitValueToolStripMenuItem
            // 
            this.dWORD32BitValueToolStripMenuItem.Name = "dWORD32BitValueToolStripMenuItem";
            this.dWORD32BitValueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dWORD32BitValueToolStripMenuItem.Text = "DWORD (32-bit) Value";
            // 
            // dWORD64bitValueToolStripMenuItem
            // 
            this.dWORD64bitValueToolStripMenuItem.Name = "dWORD64bitValueToolStripMenuItem";
            this.dWORD64bitValueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dWORD64bitValueToolStripMenuItem.Text = "QWORD (64-bit) Value";
            // 
            // multiStringValueToolStripMenuItem
            // 
            this.multiStringValueToolStripMenuItem.Name = "multiStringValueToolStripMenuItem";
            this.multiStringValueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.multiStringValueToolStripMenuItem.Text = "Multi-String Value";
            // 
            // expandableStringValueToolStripMenuItem
            // 
            this.expandableStringValueToolStripMenuItem.Name = "expandableStringValueToolStripMenuItem";
            this.expandableStringValueToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.expandableStringValueToolStripMenuItem.Text = "Expandable String Value";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.permissionsToolStripMenuItem.Text = "Permissions...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // copyKeyNameToolStripMenuItem
            // 
            this.copyKeyNameToolStripMenuItem.Name = "copyKeyNameToolStripMenuItem";
            this.copyKeyNameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.copyKeyNameToolStripMenuItem.Text = "Copy Key Name";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(181, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.findToolStripMenuItem.Text = "Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem,
            this.removeFavoritesToolStripMenuItem});
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addToFavoritesToolStripMenuItem.Text = "Add to Favorites...";
            // 
            // removeFavoritesToolStripMenuItem
            // 
            this.removeFavoritesToolStripMenuItem.Name = "removeFavoritesToolStripMenuItem";
            this.removeFavoritesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.removeFavoritesToolStripMenuItem.Text = "Remove Favorites...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.aboutToolStripMenuItem.Text = "About Registry Editor...";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Computer";
            treeNode1.Text = "Computer";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView.Size = new System.Drawing.Size(202, 536);
            this.treeView.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer.Size = new System.Drawing.Size(956, 536);
            this.splitContainer.SplitterDistance = 202;
            this.splitContainer.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbxScrollToCaret);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbxSelectAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.lblResultsCount);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwResults);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(750, 536);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbxScrollToCaret
            // 
            this.cbxScrollToCaret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxScrollToCaret.AutoSize = true;
            this.cbxScrollToCaret.Checked = true;
            this.cbxScrollToCaret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxScrollToCaret.Location = new System.Drawing.Point(585, 30);
            this.cbxScrollToCaret.Name = "cbxScrollToCaret";
            this.cbxScrollToCaret.Size = new System.Drawing.Size(147, 17);
            this.cbxScrollToCaret.TabIndex = 5;
            this.cbxScrollToCaret.Text = "Automatically scroll down.";
            this.cbxScrollToCaret.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Right Click on one of the results lines to see some magic.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CTRL + F to search for registries.";
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSelectAll.AutoSize = true;
            this.cbxSelectAll.Checked = true;
            this.cbxSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSelectAll.Location = new System.Drawing.Point(7, 29);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbxSelectAll.TabIndex = 1;
            this.cbxSelectAll.Text = "Select All";
            this.cbxSelectAll.UseVisualStyleBackColor = true;
            this.cbxSelectAll.CheckedChanged += new System.EventHandler(this.CbxSelectAll_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(583, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete All Selected Registries";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblResultsCount
            // 
            this.lblResultsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultsCount.AutoSize = true;
            this.lblResultsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsCount.Location = new System.Drawing.Point(5, 8);
            this.lblResultsCount.Name = "lblResultsCount";
            this.lblResultsCount.Size = new System.Drawing.Size(128, 17);
            this.lblResultsCount.TabIndex = 1;
            this.lblResultsCount.Text = "Results Count: 0";
            // 
            // lvwResults
            // 
            this.lvwResults.CheckBoxes = true;
            this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCbx,
            this.columnHkey});
            this.lvwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwResults.FullRowSelect = true;
            this.lvwResults.GridLines = true;
            this.lvwResults.Location = new System.Drawing.Point(0, 0);
            this.lvwResults.Name = "lvwResults";
            this.lvwResults.Size = new System.Drawing.Size(750, 485);
            this.lvwResults.TabIndex = 0;
            this.lvwResults.UseCompatibleStateImageBehavior = false;
            this.lvwResults.View = System.Windows.Forms.View.Details;
            this.lvwResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvwResults_MouseClick);
            // 
            // columnCbx
            // 
            this.columnCbx.Text = "";
            this.columnCbx.Width = 24;
            // 
            // columnHkey
            // 
            this.columnHkey.Text = "HKEY";
            this.columnHkey.Width = 1980;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 560);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = global::Windows.RegistryEditor.Properties.Resources.app;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry Editor";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeRegistryTree()
        {
            treeView.TopNode.Nodes.Add(Microsoft.Win32.Registry.ClassesRoot.Name, Microsoft.Win32.Registry.ClassesRoot.Name);
            treeView.TopNode.Nodes.Add(Microsoft.Win32.Registry.CurrentUser.Name, Microsoft.Win32.Registry.CurrentUser.Name);
            treeView.TopNode.Nodes.Add(Microsoft.Win32.Registry.LocalMachine.Name, Microsoft.Win32.Registry.LocalMachine.Name);
            treeView.TopNode.Nodes.Add(Microsoft.Win32.Registry.Users.Name, Microsoft.Win32.Registry.Users.Name);
            treeView.TopNode.Nodes.Add(Microsoft.Win32.Registry.CurrentConfig.Name, Microsoft.Win32.Registry.CurrentConfig.Name);

            treeView.TopNode.Nodes[Microsoft.Win32.Registry.ClassesRoot.Name].Nodes.Add(System.String.Empty);
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.CurrentUser.Name].Nodes.Add(System.String.Empty);
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.LocalMachine.Name].Nodes.Add(System.String.Empty);
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.Users.Name].Nodes.Add(System.String.Empty);
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.CurrentConfig.Name].Nodes.Add(System.String.Empty);

            treeView.TopNode.Nodes[Microsoft.Win32.Registry.ClassesRoot.Name].Tag = Microsoft.Win32.Registry.ClassesRoot;
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.CurrentUser.Name].Tag = Microsoft.Win32.Registry.CurrentUser;
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.LocalMachine.Name].Tag = Microsoft.Win32.Registry.LocalMachine;
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.Users.Name].Tag = Microsoft.Win32.Registry.Users;
            treeView.TopNode.Nodes[Microsoft.Win32.Registry.CurrentConfig.Name].Tag = Microsoft.Win32.Registry.CurrentConfig;

            treeView.TopNode.Expand();

            treeView.BeforeExpand += TreeViewBeforeExpand;
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem loadHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloadHiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dWORD32BitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dWORD64bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem copyKeyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblResultsCount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader cbx;
        private System.Windows.Forms.ColumnHeader HKEY;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbxSelectAll;
        private Windows.RegistryEditor.Views.Controls.ListViewEx lvwResults;
        private System.Windows.Forms.ColumnHeader columnCbx;
        private System.Windows.Forms.ColumnHeader columnHkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxScrollToCaret;
    }
}