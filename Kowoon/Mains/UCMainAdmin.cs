using System;
using System.Windows.Forms;

namespace Kowoon.Mains
{
    public partial class UCMainAdmin : UserControl
    {
        public UCMainAdmin()
        {
            InitializeComponent();
        }

        private void UCMainAdmin_Load(object sender, EventArgs e)
        {
        }

        #region BtnView
        private void BtnView_Leave(object sender, EventArgs e)
        {
            this.btnView.BackgroundImage = global::Kowoon.Properties.Resources.btnView;
        }

        private void BtnView_Enter(object sender, EventArgs e)
        {
            this.btnView.BackgroundImage = global::Kowoon.Properties.Resources.btnView_Enter;
        }

        private void BtnView_Down(object sender, MouseEventArgs e)
        {
            this.btnView.BackgroundImage = global::Kowoon.Properties.Resources.btnView_Down;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnExternalSet
        private void BtnExternalSet_Leave(object sender, EventArgs e)
        {
            this.btnExternalSet.BackgroundImage = global::Kowoon.Properties.Resources.btnExternalSet;
        }

        private void BtnExternalSet_Enter(object sender, EventArgs e)
        {
            this.btnExternalSet.BackgroundImage = global::Kowoon.Properties.Resources.btnExternalSet_Enter;
        }

        private void BtnExternalSet_Down(object sender, MouseEventArgs e)
        {
            this.btnExternalSet.BackgroundImage = global::Kowoon.Properties.Resources.btnExternalSet_Down;
        }

        private void BtnExternalSet_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnGroupSet
        private void BtnGroupSet_Leave(object sender, EventArgs e)
        {
            this.btnGroupSet.BackgroundImage = global::Kowoon.Properties.Resources.btnGroupSet;
        }

        private void BtnGroupSet_Enter(object sender, EventArgs e)
        {
            this.btnGroupSet.BackgroundImage = global::Kowoon.Properties.Resources.btnGroupSet_Enter;
        }

        private void BtnGroupSet_Down(object sender, MouseEventArgs e)
        {
            this.btnGroupSet.BackgroundImage = global::Kowoon.Properties.Resources.btnGroupSet_Down;
        }

        private void BtnGroupSet_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnProgram
        private void BtnProgram_Leave(object sender, EventArgs e)
        {
            this.btnProgram.BackgroundImage = global::Kowoon.Properties.Resources.btnProgram;
        }

        private void BtnProgram_Enter(object sender, EventArgs e)
        {
            this.btnProgram.BackgroundImage = global::Kowoon.Properties.Resources.btnProgram_Enter;
        }

        private void BtnProgram_Down(object sender, MouseEventArgs e)
        {
            this.btnProgram.BackgroundImage = global::Kowoon.Properties.Resources.btnProgram_Down;
        }

        private void BtnProgram_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnViewAdd
        private void BtnViewAdd_Leave(object sender, EventArgs e)
        {
            this.btnViewAdd.BackgroundImage = global::Kowoon.Properties.Resources.btnViewAdd;
        }

        private void BtnViewAdd_Enter(object sender, EventArgs e)
        {
            this.btnViewAdd.BackgroundImage = global::Kowoon.Properties.Resources.btnViewAdd_Enter;
        }

        private void BtnViewAdd_Down(object sender, MouseEventArgs e)
        {
            this.btnViewAdd.BackgroundImage = global::Kowoon.Properties.Resources.btnViewAdd_Down;
        }

        private void BtnViewAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnZone
        private void BtnZone_Leave(object sender, EventArgs e)
        {
            this.btnZone.BackgroundImage = global::Kowoon.Properties.Resources.btnZone;
        }

        private void BtnZone_Enter(object sender, EventArgs e)
        {
            this.btnZone.BackgroundImage = global::Kowoon.Properties.Resources.btnZone_Enter;
        }

        private void BtnZone_Down(object sender, MouseEventArgs e)
        {
            this.btnZone.BackgroundImage = global::Kowoon.Properties.Resources.btnZone_Down;
        }

        private void BtnZone_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BtnSave
        private void BtnSave_Leave(object sender, EventArgs e)
        {
            this.btnSave.BackgroundImage = global::Kowoon.Properties.Resources.btnSave;
        }

        private void BtnSave_Enter(object sender, EventArgs e)
        {
            this.btnSave.BackgroundImage = global::Kowoon.Properties.Resources.btnSave_Enter;
        }

        private void BtnSave_Down(object sender, MouseEventArgs e)
        {
            this.btnSave.BackgroundImage = global::Kowoon.Properties.Resources.btnSave_Down;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
