using Kowoon.MessageForms;
using Kowoon.PanelLefts.Externals;
using System;
using System.Windows.Forms;
using Kowoon.PanelLefts.Groups;

namespace Kowoon.Mains
{
    public partial class UCMainUser : UserControl
    {
        public UCMainUser()
        {
            InitializeComponent();
        }

        private void UCMainUser_Load(object sender, EventArgs e)
        {
        }

        #region BtnExternal
        private void BtnExternal_Leave(object sender, EventArgs e)
        {
            btnExternal.BackgroundImage = global::Kowoon.Properties.Resources.btnExternal;
        }

        private void BtnExternal_Enter(object sender, EventArgs e)
        {
            btnExternal.BackgroundImage = global::Kowoon.Properties.Resources.btnExternal_Enter;
        }

        private void BtnExternal_Down(object sender, MouseEventArgs e)
        {
            btnExternal.BackgroundImage = global::Kowoon.Properties.Resources.btnExternal_Down;
        }

        private void BtnExternal_Click(object sender, EventArgs e)
        {
            FormExternal formExternal = new FormExternal();
            formExternal.Show();
        }
        #endregion

        #region BtnGroup
        private void BtnGroup_Leave(object sender, EventArgs e)
        {
            btnGroup.BackgroundImage = global::Kowoon.Properties.Resources.btnGroup;
        }

        private void BtnGroup_Enter(object sender, EventArgs e)
        {
            btnGroup.BackgroundImage = global::Kowoon.Properties.Resources.btnGroup_Enter;
        }

        private void BtnGroup_Down(object sender, MouseEventArgs e)
        {
            btnGroup.BackgroundImage = global::Kowoon.Properties.Resources.btnGroup_Down;
        }

        private void BtnGroup_Click(object sender, EventArgs e)
        {
            FormGroup formGroup = new FormGroup();
            formGroup.Show();
        }
        #endregion

        #region BtnTimer
        private void BtnTimer_Leave(object sender, EventArgs e)
        {
            btnTimer.BackgroundImage = global::Kowoon.Properties.Resources.btnTimer;
        }

        private void BtnTimer_Enter(object sender, EventArgs e)
        {
            btnTimer.BackgroundImage = global::Kowoon.Properties.Resources.btnTimer_Enter;
        }

        private void BtnTimer_Down(object sender, MouseEventArgs e)
        {
            btnTimer.BackgroundImage = global::Kowoon.Properties.Resources.btnTimer_Down;
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            PanelLefts.Timers.FormTimer formTimer = new PanelLefts.Timers.FormTimer();
            formTimer.Show();
        }
        #endregion

        #region BtnReservation
        private void BtnReservation_Leave(object sender, EventArgs e)
        {
            btnReservation.BackgroundImage = global::Kowoon.Properties.Resources.btnReservation;
        }

        private void BtnReservation_Enter(object sender, EventArgs e)
        {
            btnReservation.BackgroundImage = global::Kowoon.Properties.Resources.btnReservation_Enter;
        }

        private void BtnReservation_Down(object sender, MouseEventArgs e)
        {
            btnReservation.BackgroundImage = global::Kowoon.Properties.Resources.btnReservation_Down;
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            PanelLefts.Reservations.FormReservation formReservation = new PanelLefts.Reservations.FormReservation();
            formReservation.Show();
        }
        #endregion

        #region BtnRecords
        private void BtnRecords_Leave(object sender, EventArgs e)
        {
            btnRecords.BackgroundImage = global::Kowoon.Properties.Resources.btnRecords;
        }

        private void BtnRecords_Enter(object sender, EventArgs e)
        {
            btnRecords.BackgroundImage = global::Kowoon.Properties.Resources.btnRecords_Enter;
        }

        private void BtnRecords_Down(object sender, MouseEventArgs e)
        {
            btnRecords.BackgroundImage = global::Kowoon.Properties.Resources.btnRecords_Down;
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            FormMessage formMessage = new FormMessage();
            formMessage.Show();
        }
        #endregion

        #region BtnAllOn
        private void BtnAllOn_Leave(object sender, EventArgs e)
        {
            btnAllOn.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOn;
        }

        private void BtnAllOn_Enter(object sender, EventArgs e)
        {
            btnAllOn.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOn_Enter;
        }

        private void BtnAllOn_Down(object sender, MouseEventArgs e)
        {
            btnAllOn.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOn_Down;
        }

        private void BtnAllOn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnAllOff
        private void BtnAllOff_Leave(object sender, EventArgs e)
        {
            btnAllOff.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOff;
        }

        private void BtnAllOff_Enter(object sender, EventArgs e)
        {
            btnAllOff.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOff_Enter;
        }

        private void BtnAllOff_Down(object sender, MouseEventArgs e)
        {
            btnAllOff.BackgroundImage = global::Kowoon.Properties.Resources.btnAllOff_Down;
        }

        private void BtnAllOff_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
