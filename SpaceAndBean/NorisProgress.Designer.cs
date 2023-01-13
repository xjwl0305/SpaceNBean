using System.ComponentModel;

namespace SpaceAndBean
{
    partial class NorisProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.progreddssBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progreddssBar1
            // 
            this.progreddssBar1.Location = new System.Drawing.Point(12, 90);
            this.progreddssBar1.Name = "progreddssBar1";
            this.progreddssBar1.Size = new System.Drawing.Size(310, 33);
            this.progreddssBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NorisProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progreddssBar1);
            this.Name = "NorisProgress";
            this.Text = "NorisProgress";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ProgressBar progreddssBar1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}