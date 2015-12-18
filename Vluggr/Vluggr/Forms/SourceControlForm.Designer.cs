namespace Vluggr.Client.Forms
{
    partial class SourceControlForm
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
            this.sourceControlControl = new Vluggr.Client.Controls.SourceControlControl();
            this.SuspendLayout();
            // 
            // sourceControlControl
            // 
            this.sourceControlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceControlControl.Location = new System.Drawing.Point(0, 0);
            this.sourceControlControl.Name = "sourceControlControl";
            this.sourceControlControl.Size = new System.Drawing.Size(1193, 641);
            this.sourceControlControl.TabIndex = 0;
            // 
            // SourceControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 641);
            this.Controls.Add(this.sourceControlControl);
            this.Name = "SourceControlForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SourceControlControl sourceControlControl;
    }
}

