
namespace Kowoon.Logins
{
    partial class FormLogin
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
            this.panelTextbox = new System.Windows.Forms.Panel();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelTextbox.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTextbox
            // 
            this.panelTextbox.BackColor = System.Drawing.Color.Transparent;
            this.panelTextbox.Controls.Add(this.textBoxPw);
            this.panelTextbox.Controls.Add(this.textBoxId);
            this.panelTextbox.Location = new System.Drawing.Point(256, 182);
            this.panelTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTextbox.Name = "panelTextbox";
            this.panelTextbox.Size = new System.Drawing.Size(250, 132);
            this.panelTextbox.TabIndex = 0;
            // 
            // textBoxPw
            // 
            this.textBoxPw.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPw.Location = new System.Drawing.Point(51, 75);
            this.textBoxPw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPw.MaxLength = 30;
            this.textBoxPw.Multiline = true;
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '●';
            this.textBoxPw.Size = new System.Drawing.Size(184, 39);
            this.textBoxPw.TabIndex = 1;
            this.textBoxPw.TextChanged += new System.EventHandler(this.TextboxPw_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxId.Location = new System.Drawing.Point(53, 25);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId.MaxLength = 30;
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(183, 39);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.TextboxId_TextChanged);
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.Transparent;
            this.panelBtn.Controls.Add(this.buttonCancel);
            this.panelBtn.Controls.Add(this.buttonLogin);
            this.panelBtn.Location = new System.Drawing.Point(256, 310);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(250, 58);
            this.panelBtn.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnCancel;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(153, 8);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 42);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonCancel_Down);
            this.buttonCancel.MouseEnter += new System.EventHandler(this.ButtonCancel_Enter);
            this.buttonCancel.MouseLeave += new System.EventHandler(this.ButtonCancel_Leave);
            this.buttonCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonCancel_Enter);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::Kowoon.Properties.Resources.btnLogin;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(53, 8);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(84, 38);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.buttonLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLogin_Down);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.ButtonLogin_Enter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.ButtonLogin_Leave);
            this.buttonLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonLogin_Enter);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Kowoon.Properties.Resources.formLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 430);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.panelTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_Closing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelTextbox.ResumeLayout(false);
            this.panelTextbox.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTextbox;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
    }
}