
namespace Kowoon.PanelLefts.Externals
{
    partial class FormExternal
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
            this.tableLayoutPanelExternal = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelExternal
            // 
            this.tableLayoutPanelExternal.AutoScroll = true;
            this.tableLayoutPanelExternal.AutoScrollMinSize = new System.Drawing.Size(5, 358);
            this.tableLayoutPanelExternal.ColumnCount = 1;
            this.tableLayoutPanelExternal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelExternal.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelExternal.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelExternal.Name = "tableLayoutPanelExternal";
            this.tableLayoutPanelExternal.Size = new System.Drawing.Size(139, 357);
            this.tableLayoutPanelExternal.TabIndex = 1;
            // 
            // FormExternal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(144, 361);
            this.Controls.Add(this.tableLayoutPanelExternal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExternal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "외부기기";
            this.Load += new System.EventHandler(this.External_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExternal;
    }
}