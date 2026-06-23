
namespace Kowoon.Logins
{
    partial class FormLoding
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
            this.panelLoding = new System.Windows.Forms.Panel();
            this.pictureBoxLoding = new System.Windows.Forms.PictureBox();
            this.panelLoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoding)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoding
            // 
            this.panelLoding.Controls.Add(this.pictureBoxLoding);
            this.panelLoding.Location = new System.Drawing.Point(0, 0);
            this.panelLoding.Margin = new System.Windows.Forms.Padding(0);
            this.panelLoding.Name = "panelLoding";
            this.panelLoding.Size = new System.Drawing.Size(160, 160);
            this.panelLoding.TabIndex = 0;
            // 
            // pictureBoxLoding
            // 
            this.pictureBoxLoding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLoding.Image = global::Kowoon.Properties.Resources.Loding;
            this.pictureBoxLoding.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoding.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLoding.Name = "pictureBoxLoding";
            this.pictureBoxLoding.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxLoding.TabIndex = 0;
            this.pictureBoxLoding.TabStop = false;
            // 
            // FormLoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(160, 160);
            this.Controls.Add(this.panelLoding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "로딩중";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoding_FormClosing);
            this.Shown += new System.EventHandler(this.FormLoding_Shown);
            this.panelLoding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoding;
        private System.Windows.Forms.PictureBox pictureBoxLoding;
    }
}