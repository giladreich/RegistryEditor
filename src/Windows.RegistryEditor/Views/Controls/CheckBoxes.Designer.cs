namespace Windows.RegistryEditor.Views.Controls
{
    partial class CheckBoxes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxAll = new System.Windows.Forms.CheckedListBox();
            this.cbxAll = new System.Windows.Forms.CheckBox();
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxAll
            // 
            this.lbxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAll.FormattingEnabled = true;
            this.lbxAll.Location = new System.Drawing.Point(0, 30);
            this.lbxAll.Margin = new System.Windows.Forms.Padding(0);
            this.lbxAll.Name = "lbxAll";
            this.lbxAll.Size = new System.Drawing.Size(148, 90);
            this.lbxAll.TabIndex = 0;
            this.lbxAll.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LbxAll_ItemCheck);
            // 
            // cbxAll
            // 
            this.cbxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxAll.AutoSize = true;
            this.cbxAll.Location = new System.Drawing.Point(3, 10);
            this.cbxAll.Name = "cbxAll";
            this.cbxAll.Size = new System.Drawing.Size(70, 17);
            this.cbxAll.TabIndex = 1;
            this.cbxAll.Text = "Select All";
            this.cbxAll.UseVisualStyleBackColor = true;
            this.cbxAll.CheckedChanged += new System.EventHandler(this.CbxAll_CheckedChanged);
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.cbxAll, 0, 0);
            this.panelMain.Controls.Add(this.lbxAll, 0, 1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 2;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Size = new System.Drawing.Size(148, 120);
            this.panelMain.TabIndex = 2;
            // 
            // CheckBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CheckBoxes";
            this.Size = new System.Drawing.Size(148, 120);
            this.Load += new System.EventHandler(this.CheckBoxes_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbxAll;
        private System.Windows.Forms.CheckBox cbxAll;
        private System.Windows.Forms.TableLayoutPanel panelMain;
    }
}
