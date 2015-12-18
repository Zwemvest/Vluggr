namespace Vluggr.Client.Controls
{
    partial class SourceControlControl
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
            this.repositoryUserControl1 = new Vluggr.Client.Controls.SourceControl.RepositoryUserControl();
            this.SuspendLayout();
            // 
            // repositoryUserControl1
            // 
            this.repositoryUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.repositoryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.repositoryUserControl1.Name = "repositoryUserControl1";
            this.repositoryUserControl1.Size = new System.Drawing.Size(788, 100);
            this.repositoryUserControl1.TabIndex = 0;
            // 
            // SourceControlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.repositoryUserControl1);
            this.Name = "SourceControlControl";
            this.Size = new System.Drawing.Size(788, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private SourceControl.RepositoryUserControl repositoryUserControl1;
    }
}
