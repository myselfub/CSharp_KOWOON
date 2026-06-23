
namespace Kowoon.PanelLefts.Timers
{
    partial class FormTimerControl
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
            this.panelTimerControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTimerControl
            // 
            this.panelTimerControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTimerControl.Location = new System.Drawing.Point(9, 9);
            this.panelTimerControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelTimerControl.Name = "panelTimerControl";
            this.panelTimerControl.Size = new System.Drawing.Size(506, 285);
            this.panelTimerControl.TabIndex = 0;
            // 
            // FormTimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 303);
            this.Controls.Add(this.panelTimerControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTimerControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "타이머 설정";
            this.Load += new System.EventHandler(this.FormTimerControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimerControl;
    }
}