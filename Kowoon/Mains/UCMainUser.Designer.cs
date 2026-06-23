
namespace Kowoon.Mains
{
    partial class UCMainUser
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnExternal = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelUser.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tabControlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.Control;
            this.panelUser.Controls.Add(this.panelLeft);
            this.panelUser.Controls.Add(this.panelRight);
            this.panelUser.Controls.Add(this.tabControlUser);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(995, 712);
            this.panelUser.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.btnExternal);
            this.panelLeft.Controls.Add(this.btnGroup);
            this.panelLeft.Controls.Add(this.btnTimer);
            this.panelLeft.Controls.Add(this.btnReservation);
            this.panelLeft.Controls.Add(this.btnRecords);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(550, 65);
            this.panelLeft.TabIndex = 9;
            // 
            // btnExternal
            // 
            this.btnExternal.BackColor = System.Drawing.Color.Transparent;
            this.btnExternal.BackgroundImage = global::Kowoon.Properties.Resources.btnExternal;
            this.btnExternal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExternal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExternal.FlatAppearance.BorderSize = 0;
            this.btnExternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExternal.ForeColor = System.Drawing.Color.Transparent;
            this.btnExternal.Location = new System.Drawing.Point(0, 0);
            this.btnExternal.Margin = new System.Windows.Forms.Padding(0);
            this.btnExternal.Name = "btnExternal";
            this.btnExternal.Size = new System.Drawing.Size(72, 60);
            this.btnExternal.TabIndex = 0;
            this.btnExternal.UseVisualStyleBackColor = false;
            this.btnExternal.Click += new System.EventHandler(this.BtnExternal_Click);
            this.btnExternal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnExternal_Down);
            this.btnExternal.MouseEnter += new System.EventHandler(this.BtnExternal_Enter);
            this.btnExternal.MouseLeave += new System.EventHandler(this.BtnExternal_Leave);
            this.btnExternal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnExternal_Enter);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnGroup.BackgroundImage = global::Kowoon.Properties.Resources.btnGroup;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.ForeColor = System.Drawing.Color.Transparent;
            this.btnGroup.Location = new System.Drawing.Point(87, 0);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(72, 60);
            this.btnGroup.TabIndex = 1;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            this.btnGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnGroup_Down);
            this.btnGroup.MouseEnter += new System.EventHandler(this.BtnGroup_Enter);
            this.btnGroup.MouseLeave += new System.EventHandler(this.BtnGroup_Leave);
            this.btnGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGroup_Enter);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnTimer.BackgroundImage = global::Kowoon.Properties.Resources.btnTimer;
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimer.Location = new System.Drawing.Point(174, 0);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(72, 60);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            this.btnTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTimer_Down);
            this.btnTimer.MouseEnter += new System.EventHandler(this.BtnTimer_Enter);
            this.btnTimer.MouseLeave += new System.EventHandler(this.BtnTimer_Leave);
            this.btnTimer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnTimer_Enter);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnReservation.BackgroundImage = global::Kowoon.Properties.Resources.btnReservation;
            this.btnReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.ForeColor = System.Drawing.Color.Transparent;
            this.btnReservation.Location = new System.Drawing.Point(261, 0);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(72, 60);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.BtnReservation_Click);
            this.btnReservation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnReservation_Down);
            this.btnReservation.MouseEnter += new System.EventHandler(this.BtnReservation_Enter);
            this.btnReservation.MouseLeave += new System.EventHandler(this.BtnReservation_Leave);
            this.btnReservation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnReservation_Enter);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnRecords.BackgroundImage = global::Kowoon.Properties.Resources.btnRecords;
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.ForeColor = System.Drawing.Color.Transparent;
            this.btnRecords.Location = new System.Drawing.Point(348, 0);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(72, 60);
            this.btnRecords.TabIndex = 4;
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.BtnRecords_Click);
            this.btnRecords.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRecords_Down);
            this.btnRecords.MouseEnter += new System.EventHandler(this.BtnRecords_Enter);
            this.btnRecords.MouseLeave += new System.EventHandler(this.BtnRecords_Leave);
            this.btnRecords.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRecords_Enter);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.btnAllOn);
            this.panelRight.Controls.Add(this.btnAllOff);
            this.panelRight.Location = new System.Drawing.Point(630, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(365, 65);
            this.panelRight.TabIndex = 11;
            // 
            // btnAllOn
            // 
            this.btnAllOn.BackColor = System.Drawing.Color.Transparent;
            this.btnAllOn.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOn;
            this.btnAllOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAllOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOn.FlatAppearance.BorderSize = 0;
            this.btnAllOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOn.ForeColor = System.Drawing.Color.Transparent;
            this.btnAllOn.Location = new System.Drawing.Point(163, 11);
            this.btnAllOn.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(82, 38);
            this.btnAllOn.TabIndex = 5;
            this.btnAllOn.UseVisualStyleBackColor = false;
            this.btnAllOn.Click += new System.EventHandler(this.BtnAllOn_Click);
            this.btnAllOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnAllOn_Down);
            this.btnAllOn.MouseEnter += new System.EventHandler(this.BtnAllOn_Enter);
            this.btnAllOn.MouseLeave += new System.EventHandler(this.BtnAllOn_Leave);
            this.btnAllOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAllOn_Enter);
            // 
            // btnAllOff
            // 
            this.btnAllOff.BackColor = System.Drawing.Color.Transparent;
            this.btnAllOff.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOff;
            this.btnAllOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAllOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOff.FlatAppearance.BorderSize = 0;
            this.btnAllOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOff.ForeColor = System.Drawing.Color.Transparent;
            this.btnAllOff.Location = new System.Drawing.Point(264, 11);
            this.btnAllOff.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(82, 38);
            this.btnAllOff.TabIndex = 6;
            this.btnAllOff.UseVisualStyleBackColor = false;
            this.btnAllOff.Click += new System.EventHandler(this.BtnAllOff_Click);
            this.btnAllOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnAllOff_Down);
            this.btnAllOff.MouseEnter += new System.EventHandler(this.BtnAllOff_Enter);
            this.btnAllOff.MouseLeave += new System.EventHandler(this.BtnAllOff_Leave);
            this.btnAllOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAllOff_Enter);
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabPage1);
            this.tabControlUser.Location = new System.Drawing.Point(3, 71);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(989, 638);
            this.tabControlUser.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "방송설비";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UCMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelUser);
            this.Name = "UCMainUser";
            this.Size = new System.Drawing.Size(995, 712);
            this.Load += new System.EventHandler(this.UCMainUser_Load);
            this.panelUser.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tabControlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnAllOn;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExternal;
    }
}
