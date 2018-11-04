namespace Windows.RegistryEditor.Views
{
    partial class NetworkWindow
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
            this.lbxMachines = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.loader = new Windows.RegistryEditor.Views.Controls.Loader();
            this.SuspendLayout();
            // 
            // lbxMachines
            // 
            this.lbxMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMachines.FormattingEnabled = true;
            this.lbxMachines.Location = new System.Drawing.Point(12, 19);
            this.lbxMachines.Name = "lbxMachines";
            this.lbxMachines.Size = new System.Drawing.Size(179, 95);
            this.lbxMachines.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(103, 120);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.DisableControlsOnWork = true;
            this.loader.LoaderKind = Windows.RegistryEditor.Views.Controls.LoaderKind.Clock;
            this.loader.Location = new System.Drawing.Point(12, 123);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(20, 20);
            this.loader.SizeLoading = new System.Drawing.Size(60, 60);
            this.loader.TabIndex = 3;
            this.loader.Visible = false;
            // 
            // NetworkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 155);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbxMachines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NetworkWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machines on the Network";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkWindow_FormClosing);
            this.Load += new System.EventHandler(this.NetworkWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMachines;
        private System.Windows.Forms.Button btnSelect;
        private Controls.Loader loader;
    }
}