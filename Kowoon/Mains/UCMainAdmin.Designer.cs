
namespace Kowoon.Mains
{
    partial class UCMainAdmin
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnExternalSet = new System.Windows.Forms.Button();
            this.btnGroupSet = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnViewAdd = new System.Windows.Forms.Button();
            this.btnZone = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelUser.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUser.Controls.Add(this.panelLeft);
            this.panelUser.Controls.Add(this.panelRight);
            this.panelUser.Controls.Add(this.tabControlAdmin);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(995, 712);
            this.panelUser.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.btnView);
            this.panelLeft.Controls.Add(this.btnExternalSet);
            this.panelLeft.Controls.Add(this.btnGroupSet);
            this.panelLeft.Controls.Add(this.btnProgram);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(550, 65);
            this.panelLeft.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImage = global::Kowoon.Properties.Resources.btnView;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.Transparent;
            this.btnView.Location = new System.Drawing.Point(0, 0);
            this.btnView.Margin = new System.Windows.Forms.Padding(0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(72, 60);
            this.btnView.TabIndex = 0;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            this.btnView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnView_Down);
            this.btnView.MouseEnter += new System.EventHandler(this.BtnView_Enter);
            this.btnView.MouseLeave += new System.EventHandler(this.BtnView_Leave);
            this.btnView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnView_Enter);
            // 
            // btnExternalSet
            // 
            this.btnExternalSet.BackColor = System.Drawing.Color.Transparent;
            this.btnExternalSet.BackgroundImage = global::Kowoon.Properties.Resources.btnExternalSet;
            this.btnExternalSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExternalSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExternalSet.FlatAppearance.BorderSize = 0;
            this.btnExternalSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExternalSet.ForeColor = System.Drawing.Color.Transparent;
            this.btnExternalSet.Location = new System.Drawing.Point(87, 0);
            this.btnExternalSet.Margin = new System.Windows.Forms.Padding(0);
            this.btnExternalSet.Name = "btnExternalSet";
            this.btnExternalSet.Size = new System.Drawing.Size(72, 60);
            this.btnExternalSet.TabIndex = 1;
            this.btnExternalSet.UseVisualStyleBackColor = false;
            this.btnExternalSet.Click += new System.EventHandler(this.BtnExternalSet_Click);
            this.btnExternalSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnExternalSet_Down);
            this.btnExternalSet.MouseEnter += new System.EventHandler(this.BtnExternalSet_Enter);
            this.btnExternalSet.MouseLeave += new System.EventHandler(this.BtnExternalSet_Leave);
            this.btnExternalSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnExternalSet_Enter);
            // 
            // btnGroupSet
            // 
            this.btnGroupSet.BackColor = System.Drawing.Color.Transparent;
            this.btnGroupSet.BackgroundImage = global::Kowoon.Properties.Resources.btnGroupSet;
            this.btnGroupSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGroupSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroupSet.FlatAppearance.BorderSize = 0;
            this.btnGroupSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupSet.ForeColor = System.Drawing.Color.Transparent;
            this.btnGroupSet.Location = new System.Drawing.Point(174, 0);
            this.btnGroupSet.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroupSet.Name = "btnGroupSet";
            this.btnGroupSet.Size = new System.Drawing.Size(72, 60);
            this.btnGroupSet.TabIndex = 2;
            this.btnGroupSet.UseVisualStyleBackColor = false;
            this.btnGroupSet.Click += new System.EventHandler(this.BtnGroupSet_Click);
            this.btnGroupSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnGroupSet_Down);
            this.btnGroupSet.MouseEnter += new System.EventHandler(this.BtnGroupSet_Enter);
            this.btnGroupSet.MouseLeave += new System.EventHandler(this.BtnGroupSet_Leave);
            this.btnGroupSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGroupSet_Enter);
            // 
            // btnProgram
            // 
            this.btnProgram.BackColor = System.Drawing.Color.Transparent;
            this.btnProgram.BackgroundImage = global::Kowoon.Properties.Resources.btnProgram;
            this.btnProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgram.FlatAppearance.BorderSize = 0;
            this.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgram.ForeColor = System.Drawing.Color.Transparent;
            this.btnProgram.Location = new System.Drawing.Point(261, 0);
            this.btnProgram.Margin = new System.Windows.Forms.Padding(0);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(72, 60);
            this.btnProgram.TabIndex = 3;
            this.btnProgram.UseVisualStyleBackColor = false;
            this.btnProgram.Click += new System.EventHandler(this.BtnProgram_Click);
            this.btnProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnProgram_Down);
            this.btnProgram.MouseEnter += new System.EventHandler(this.BtnProgram_Enter);
            this.btnProgram.MouseLeave += new System.EventHandler(this.BtnProgram_Leave);
            this.btnProgram.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnProgram_Enter);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.btnViewAdd);
            this.panelRight.Controls.Add(this.btnZone);
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Location = new System.Drawing.Point(630, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(365, 65);
            this.panelRight.TabIndex = 11;
            // 
            // btnViewAdd
            // 
            this.btnViewAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAdd.BackgroundImage = global::Kowoon.Properties.Resources.btnViewAdd;
            this.btnViewAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAdd.FlatAppearance.BorderSize = 0;
            this.btnViewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewAdd.Location = new System.Drawing.Point(17, 11);
            this.btnViewAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewAdd.Name = "btnViewAdd";
            this.btnViewAdd.Size = new System.Drawing.Size(97, 38);
            this.btnViewAdd.TabIndex = 7;
            this.btnViewAdd.UseVisualStyleBackColor = false;
            this.btnViewAdd.Click += new System.EventHandler(this.BtnViewAdd_Click);
            this.btnViewAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnViewAdd_Down);
            this.btnViewAdd.MouseEnter += new System.EventHandler(this.BtnViewAdd_Enter);
            this.btnViewAdd.MouseLeave += new System.EventHandler(this.BtnViewAdd_Leave);
            this.btnViewAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnViewAdd_Enter);
            // 
            // btnZone
            // 
            this.btnZone.BackColor = System.Drawing.Color.Transparent;
            this.btnZone.BackgroundImage = global::Kowoon.Properties.Resources.btnZone;
            this.btnZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZone.FlatAppearance.BorderSize = 0;
            this.btnZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZone.ForeColor = System.Drawing.Color.Transparent;
            this.btnZone.Location = new System.Drawing.Point(133, 11);
            this.btnZone.Margin = new System.Windows.Forms.Padding(0);
            this.btnZone.Name = "btnZone";
            this.btnZone.Size = new System.Drawing.Size(97, 38);
            this.btnZone.TabIndex = 5;
            this.btnZone.UseVisualStyleBackColor = false;
            this.btnZone.Click += new System.EventHandler(this.BtnZone_Click);
            this.btnZone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnZone_Down);
            this.btnZone.MouseEnter += new System.EventHandler(this.BtnZone_Enter);
            this.btnZone.MouseLeave += new System.EventHandler(this.BtnZone_Leave);
            this.btnZone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnZone_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Kowoon.Properties.Resources.btnSave;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(249, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSave_Down);
            this.btnSave.MouseEnter += new System.EventHandler(this.BtnSave_Enter);
            this.btnSave.MouseLeave += new System.EventHandler(this.BtnSave_Leave);
            this.btnSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSave_Enter);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPage1);
            this.tabControlAdmin.Location = new System.Drawing.Point(3, 71);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(989, 638);
            this.tabControlAdmin.TabIndex = 10;
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
            // UCMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelUser);
            this.Name = "UCMainAdmin";
            this.Size = new System.Drawing.Size(995, 712);
            this.Load += new System.EventHandler(this.UCMainAdmin_Load);
            this.panelUser.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExternalSet;
        private System.Windows.Forms.Button btnGroupSet;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnZone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnViewAdd;
    }
}
