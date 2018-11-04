namespace Windows.RegistryEditor.Views.Controls
{
    partial class Loader
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
            this.pbxGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGif
            // 
            this.pbxGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxGif.Image = global::Windows.RegistryEditor.Properties.Resources.loader_clock;
            this.pbxGif.Location = new System.Drawing.Point(0, 0);
            this.pbxGif.Name = "pbxGif";
            this.pbxGif.Size = new System.Drawing.Size(100, 100);
            this.pbxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGif.TabIndex = 0;
            this.pbxGif.TabStop = false;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbxGif);
            this.Name = "Loader";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.Spinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGif;
    }
}
