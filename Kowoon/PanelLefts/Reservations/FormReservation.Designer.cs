
namespace Kowoon.PanelLefts.Reservations
{
    partial class FormReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.columnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGroupBroadcasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStairs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExternalDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartContactPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEndContactPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTimer
            // 
            this.panelTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTimer.Controls.Add(this.dataGridViewReservation);
            this.panelTimer.Controls.Add(this.buttonCancel);
            this.panelTimer.Controls.Add(this.buttonSave);
            this.panelTimer.Controls.Add(this.labelList);
            this.panelTimer.Controls.Add(this.buttonDelete);
            this.panelTimer.Controls.Add(this.buttonModify);
            this.panelTimer.Controls.Add(this.buttonAdd);
            this.panelTimer.Location = new System.Drawing.Point(0, 0);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(984, 531);
            this.panelTimer.TabIndex = 0;
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReservation.ColumnHeadersHeight = 26;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNo,
            this.columnDate,
            this.columnStartTime,
            this.columnEndTime,
            this.columnGroupBroadcasting,
            this.columnDong,
            this.columnStairs,
            this.columnFloor,
            this.columnExternalDevice,
            this.columnStartContactPoint,
            this.columnEndContactPoint});
            this.dataGridViewReservation.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewReservation.Location = new System.Drawing.Point(10, 55);
            this.dataGridViewReservation.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersVisible = false;
            this.dataGridViewReservation.RowHeadersWidth = 62;
            this.dataGridViewReservation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReservation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReservation.RowTemplate.Height = 25;
            this.dataGridViewReservation.Size = new System.Drawing.Size(964, 440);
            this.dataGridViewReservation.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(502, 500);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 25);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "취소";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.buttonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.buttonCancel.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonCancel.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.buttonCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(407, 500);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 25);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "저장";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.buttonSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.buttonSave.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.buttonSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Enter);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.BackColor = System.Drawing.Color.Transparent;
            this.labelList.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelList.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelList.Location = new System.Drawing.Point(15, 25);
            this.labelList.Margin = new System.Windows.Forms.Padding(0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(109, 20);
            this.labelList.TabIndex = 0;
            this.labelList.Text = "예약 설정 목록";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(879, 20);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            this.buttonDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.buttonDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Enter);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Transparent;
            this.buttonModify.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
            this.buttonModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModify.Location = new System.Drawing.Point(789, 20);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(0);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 25);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "수정";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            this.buttonModify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.buttonModify.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonModify.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.buttonModify.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Enter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(699, 20);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            this.buttonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.buttonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Enter);
            // 
            // columnNo
            // 
            this.columnNo.HeaderText = "NO";
            this.columnNo.MaxInputLength = 6;
            this.columnNo.MinimumWidth = 25;
            this.columnNo.Name = "columnNo";
            this.columnNo.ReadOnly = true;
            this.columnNo.ToolTipText = "No";
            this.columnNo.Width = 55;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "날짜";
            this.columnDate.MaxInputLength = 10;
            this.columnDate.MinimumWidth = 60;
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            this.columnDate.ToolTipText = "Date";
            this.columnDate.Width = 90;
            // 
            // columnStartTime
            // 
            this.columnStartTime.HeaderText = "시작시간";
            this.columnStartTime.MaxInputLength = 10;
            this.columnStartTime.MinimumWidth = 60;
            this.columnStartTime.Name = "columnStartTime";
            this.columnStartTime.ReadOnly = true;
            this.columnStartTime.ToolTipText = "StartTime";
            this.columnStartTime.Width = 90;
            // 
            // columnEndTime
            // 
            this.columnEndTime.HeaderText = "종료시간";
            this.columnEndTime.MaxInputLength = 10;
            this.columnEndTime.MinimumWidth = 60;
            this.columnEndTime.Name = "columnEndTime";
            this.columnEndTime.ReadOnly = true;
            this.columnEndTime.ToolTipText = "EndTime";
            this.columnEndTime.Width = 90;
            // 
            // columnGroupBroadcasting
            // 
            this.columnGroupBroadcasting.HeaderText = "그룹방송";
            this.columnGroupBroadcasting.MaxInputLength = 30;
            this.columnGroupBroadcasting.MinimumWidth = 60;
            this.columnGroupBroadcasting.Name = "columnGroupBroadcasting";
            this.columnGroupBroadcasting.ReadOnly = true;
            this.columnGroupBroadcasting.ToolTipText = "GroupBroadcasting";
            this.columnGroupBroadcasting.Width = 90;
            // 
            // columnDong
            // 
            this.columnDong.HeaderText = "동";
            this.columnDong.MaxInputLength = 30;
            this.columnDong.MinimumWidth = 60;
            this.columnDong.Name = "columnDong";
            this.columnDong.ReadOnly = true;
            this.columnDong.ToolTipText = "Dong";
            this.columnDong.Width = 91;
            // 
            // columnStairs
            // 
            this.columnStairs.HeaderText = "계단";
            this.columnStairs.MaxInputLength = 30;
            this.columnStairs.MinimumWidth = 60;
            this.columnStairs.Name = "columnStairs";
            this.columnStairs.ReadOnly = true;
            this.columnStairs.ToolTipText = "Stairs";
            this.columnStairs.Width = 91;
            // 
            // columnFloor
            // 
            this.columnFloor.HeaderText = "층";
            this.columnFloor.MaxInputLength = 30;
            this.columnFloor.MinimumWidth = 60;
            this.columnFloor.Name = "columnFloor";
            this.columnFloor.ReadOnly = true;
            this.columnFloor.ToolTipText = "Floor";
            this.columnFloor.Width = 91;
            // 
            // columnExternalDevice
            // 
            this.columnExternalDevice.HeaderText = "외부기기";
            this.columnExternalDevice.MaxInputLength = 30;
            this.columnExternalDevice.MinimumWidth = 60;
            this.columnExternalDevice.Name = "columnExternalDevice";
            this.columnExternalDevice.ReadOnly = true;
            this.columnExternalDevice.ToolTipText = "ExternalDevice";
            this.columnExternalDevice.Width = 91;
            // 
            // columnStartContactPoint
            // 
            this.columnStartContactPoint.HeaderText = "시작접점";
            this.columnStartContactPoint.MaxInputLength = 512;
            this.columnStartContactPoint.MinimumWidth = 60;
            this.columnStartContactPoint.Name = "columnStartContactPoint";
            this.columnStartContactPoint.ReadOnly = true;
            this.columnStartContactPoint.ToolTipText = "StartContactPoint";
            this.columnStartContactPoint.Width = 91;
            // 
            // columnEndContactPoint
            // 
            this.columnEndContactPoint.HeaderText = "종료접점";
            this.columnEndContactPoint.MaxInputLength = 512;
            this.columnEndContactPoint.MinimumWidth = 60;
            this.columnEndContactPoint.Name = "columnEndContactPoint";
            this.columnEndContactPoint.ReadOnly = true;
            this.columnEndContactPoint.ToolTipText = "EndContactPoint";
            this.columnEndContactPoint.Width = 91;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.panelTimer);
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "예약 설정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReservation_FormClosing);
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGroupBroadcasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExternalDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartContactPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndContactPoint;
    }
}