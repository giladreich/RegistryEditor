namespace Windows.RegistryEditor.Views
{
    partial class FindWindow
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
            this.components = new System.ComponentModel.Container();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLookAt = new System.Windows.Forms.GroupBox();
            this.cbxData = new System.Windows.Forms.CheckBox();
            this.cbxValues = new System.Windows.Forms.CheckBox();
            this.cbxKeys = new System.Windows.Forms.CheckBox();
            this.cbxMatchString = new System.Windows.Forms.CheckBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cbxRegularEx = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.gbxHkeys = new System.Windows.Forms.GroupBox();
            this.cbxsHkeys = new Windows.RegistryEditor.Views.Controls.CheckBoxes();
            this.gbxDataTypes = new System.Windows.Forms.GroupBox();
            this.cbxsDataTypes = new Windows.RegistryEditor.Views.Controls.CheckBoxes();
            this.tbxRemoteComputer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRemoteSearch = new System.Windows.Forms.CheckBox();
            this.btnFindAvailableMachines = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loader = new Windows.RegistryEditor.Views.Controls.Loader();
            this.gbxLookAt.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.gbxHkeys.SuspendLayout();
            this.gbxDataTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(110, 57);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(454, 20);
            this.tbxSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find String:";
            // 
            // gbxLookAt
            // 
            this.gbxLookAt.Controls.Add(this.cbxData);
            this.gbxLookAt.Controls.Add(this.cbxValues);
            this.gbxLookAt.Controls.Add(this.cbxKeys);
            this.gbxLookAt.Location = new System.Drawing.Point(18, 83);
            this.gbxLookAt.Name = "gbxLookAt";
            this.gbxLookAt.Size = new System.Drawing.Size(86, 120);
            this.gbxLookAt.TabIndex = 4;
            this.gbxLookAt.TabStop = false;
            this.gbxLookAt.Text = "Look at";
            // 
            // cbxData
            // 
            this.cbxData.AutoSize = true;
            this.cbxData.Checked = true;
            this.cbxData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxData.Location = new System.Drawing.Point(7, 66);
            this.cbxData.Name = "cbxData";
            this.cbxData.Size = new System.Drawing.Size(49, 17);
            this.cbxData.TabIndex = 2;
            this.cbxData.Text = "Data";
            this.cbxData.UseVisualStyleBackColor = true;
            // 
            // cbxValues
            // 
            this.cbxValues.AutoSize = true;
            this.cbxValues.Checked = true;
            this.cbxValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxValues.Location = new System.Drawing.Point(7, 43);
            this.cbxValues.Name = "cbxValues";
            this.cbxValues.Size = new System.Drawing.Size(58, 17);
            this.cbxValues.TabIndex = 1;
            this.cbxValues.Text = "Values";
            this.cbxValues.UseVisualStyleBackColor = true;
            // 
            // cbxKeys
            // 
            this.cbxKeys.AutoSize = true;
            this.cbxKeys.Checked = true;
            this.cbxKeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxKeys.Location = new System.Drawing.Point(7, 20);
            this.cbxKeys.Name = "cbxKeys";
            this.cbxKeys.Size = new System.Drawing.Size(49, 17);
            this.cbxKeys.TabIndex = 0;
            this.cbxKeys.Text = "Keys";
            this.cbxKeys.UseVisualStyleBackColor = true;
            // 
            // cbxMatchString
            // 
            this.cbxMatchString.AutoSize = true;
            this.cbxMatchString.Location = new System.Drawing.Point(6, 43);
            this.cbxMatchString.Name = "cbxMatchString";
            this.cbxMatchString.Size = new System.Drawing.Size(113, 17);
            this.cbxMatchString.TabIndex = 1;
            this.cbxMatchString.Text = "Match whole word";
            this.cbxMatchString.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.Enabled = false;
            this.btnFindNext.Location = new System.Drawing.Point(519, 272);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 1;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.BtnFindSingle_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindAll.Location = new System.Drawing.Point(519, 301);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(75, 23);
            this.btnFindAll.TabIndex = 2;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(519, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cbxCaseSensitive
            // 
            this.cbxCaseSensitive.AutoSize = true;
            this.cbxCaseSensitive.Location = new System.Drawing.Point(6, 20);
            this.cbxCaseSensitive.Name = "cbxCaseSensitive";
            this.cbxCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.cbxCaseSensitive.TabIndex = 0;
            this.cbxCaseSensitive.Text = "Case Sensitive";
            this.cbxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cbxRegularEx
            // 
            this.cbxRegularEx.AutoSize = true;
            this.cbxRegularEx.Enabled = false;
            this.cbxRegularEx.Location = new System.Drawing.Point(6, 66);
            this.cbxRegularEx.Name = "cbxRegularEx";
            this.cbxRegularEx.Size = new System.Drawing.Size(117, 17);
            this.cbxRegularEx.TabIndex = 2;
            this.cbxRegularEx.Text = "Regular Expression";
            this.cbxRegularEx.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 20);
            this.textBox1.TabIndex = 3;
            // 
            // gbxOptions
            // 
            this.gbxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOptions.Controls.Add(this.cbxMatchString);
            this.gbxOptions.Controls.Add(this.textBox1);
            this.gbxOptions.Controls.Add(this.cbxRegularEx);
            this.gbxOptions.Controls.Add(this.cbxCaseSensitive);
            this.gbxOptions.Location = new System.Drawing.Point(110, 83);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(490, 120);
            this.gbxOptions.TabIndex = 5;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Search Options";
            // 
            // gbxHkeys
            // 
            this.gbxHkeys.Controls.Add(this.cbxsHkeys);
            this.gbxHkeys.Location = new System.Drawing.Point(18, 210);
            this.gbxHkeys.Name = "gbxHkeys";
            this.gbxHkeys.Size = new System.Drawing.Size(194, 147);
            this.gbxHkeys.TabIndex = 6;
            this.gbxHkeys.TabStop = false;
            this.gbxHkeys.Text = "HKEYS";
            // 
            // cbxsHkeys
            // 
            this.cbxsHkeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbxsHkeys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cbxsHkeys.CheckOnClick = true;
            this.cbxsHkeys.DataSource = null;
            this.cbxsHkeys.Items.AddRange(new object[] {
            "HKEY_CLASSES_ROOT",
            "HKEY_CURRENT_USER",
            "HKEY_LOCAL_MACHINE",
            "HKEY_USERS",
            "HKEY_CURRENT_CONFIG"});
            this.cbxsHkeys.Location = new System.Drawing.Point(6, 16);
            this.cbxsHkeys.Name = "cbxsHkeys";
            this.cbxsHkeys.SelectAllChecked = false;
            this.cbxsHkeys.Size = new System.Drawing.Size(182, 125);
            this.cbxsHkeys.TabIndex = 0;
            this.cbxsHkeys.ThreeDCheckBoxes = false;
            // 
            // gbxDataTypes
            // 
            this.gbxDataTypes.Controls.Add(this.cbxsDataTypes);
            this.gbxDataTypes.Location = new System.Drawing.Point(218, 210);
            this.gbxDataTypes.Name = "gbxDataTypes";
            this.gbxDataTypes.Size = new System.Drawing.Size(269, 147);
            this.gbxDataTypes.TabIndex = 7;
            this.gbxDataTypes.TabStop = false;
            this.gbxDataTypes.Text = "Data Types";
            // 
            // cbxsDataTypes
            // 
            this.cbxsDataTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbxsDataTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cbxsDataTypes.CheckOnClick = true;
            this.cbxsDataTypes.DataSource = null;
            this.cbxsDataTypes.Items.AddRange(new object[] {
            "REG_SZ",
            "REG_EXPAND_SZ",
            "REG_MULTI_SZ",
            "REG_DWORD",
            "REG_QWORD",
            "REG_DWORD_LITTLE_ENDIAN",
            "REG_QWORD_LITTLE_ENDIAN",
            "REG_DWORD_BIG_ENDIAN",
            "REG_BINARY",
            "REG_NONE",
            "REG_LINK",
            "REG_RESOURCE_LIST"});
            this.cbxsDataTypes.Location = new System.Drawing.Point(6, 16);
            this.cbxsDataTypes.Name = "cbxsDataTypes";
            this.cbxsDataTypes.SelectAllChecked = true;
            this.cbxsDataTypes.Size = new System.Drawing.Size(257, 125);
            this.cbxsDataTypes.TabIndex = 0;
            this.cbxsDataTypes.ThreeDCheckBoxes = false;
            // 
            // tbxRemoteComputer
            // 
            this.tbxRemoteComputer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRemoteComputer.Enabled = false;
            this.tbxRemoteComputer.Location = new System.Drawing.Point(110, 31);
            this.tbxRemoteComputer.Name = "tbxRemoteComputer";
            this.tbxRemoteComputer.Size = new System.Drawing.Size(454, 20);
            this.tbxRemoteComputer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Computer Name:";
            // 
            // cbxRemoteSearch
            // 
            this.cbxRemoteSearch.AutoSize = true;
            this.cbxRemoteSearch.Location = new System.Drawing.Point(18, 8);
            this.cbxRemoteSearch.Name = "cbxRemoteSearch";
            this.cbxRemoteSearch.Size = new System.Drawing.Size(227, 17);
            this.cbxRemoteSearch.TabIndex = 4;
            this.cbxRemoteSearch.Text = "Search in remote computer on the network";
            this.cbxRemoteSearch.UseVisualStyleBackColor = true;
            this.cbxRemoteSearch.CheckedChanged += new System.EventHandler(this.CbxSearchInRemote_CheckedChanged);
            // 
            // btnFindAvailableMachines
            // 
            this.btnFindAvailableMachines.Enabled = false;
            this.btnFindAvailableMachines.Location = new System.Drawing.Point(570, 30);
            this.btnFindAvailableMachines.Name = "btnFindAvailableMachines";
            this.btnFindAvailableMachines.Size = new System.Drawing.Size(24, 21);
            this.btnFindAvailableMachines.TabIndex = 9;
            this.btnFindAvailableMachines.Text = "...";
            this.toolTip.SetToolTip(this.btnFindAvailableMachines, "Find available machines on the network.");
            this.btnFindAvailableMachines.UseVisualStyleBackColor = true;
            this.btnFindAvailableMachines.Click += new System.EventHandler(this.BtnFindAvailableMachines_Click);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.DisableControlsOnWork = false;
            this.loader.LoaderKind = Windows.RegistryEditor.Views.Controls.LoaderKind.Clock;
            this.loader.Location = new System.Drawing.Point(554, 226);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(40, 40);
            this.loader.SizeLoading = new System.Drawing.Size(100, 100);
            this.loader.TabIndex = 8;
            this.loader.Visible = false;
            // 
            // FindWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 365);
            this.Controls.Add(this.btnFindAvailableMachines);
            this.Controls.Add(this.cbxRemoteSearch);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.gbxDataTypes);
            this.Controls.Add(this.gbxHkeys);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.gbxLookAt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRemoteComputer);
            this.Controls.Add(this.tbxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FindWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindWindow_FormClosing);
            this.Load += new System.EventHandler(this.FindWindow_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindWindow_KeyPress);
            this.gbxLookAt.ResumeLayout(false);
            this.gbxLookAt.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.gbxHkeys.ResumeLayout(false);
            this.gbxDataTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxLookAt;
        private System.Windows.Forms.CheckBox cbxData;
        private System.Windows.Forms.CheckBox cbxValues;
        private System.Windows.Forms.CheckBox cbxKeys;
        private System.Windows.Forms.CheckBox cbxMatchString;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxCaseSensitive;
        private System.Windows.Forms.CheckBox cbxRegularEx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.GroupBox gbxHkeys;
        private System.Windows.Forms.GroupBox gbxDataTypes;
        private Windows.RegistryEditor.Views.Controls.CheckBoxes cbxsDataTypes;
        private Windows.RegistryEditor.Views.Controls.CheckBoxes cbxsHkeys;
        private Windows.RegistryEditor.Views.Controls.Loader loader;
        private System.Windows.Forms.TextBox tbxRemoteComputer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxRemoteSearch;
        private System.Windows.Forms.Button btnFindAvailableMachines;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

