using System;
using System.Windows.Forms;

namespace Kowoon.MessageForms
{
    public partial class UCDeleteConfirmation : UserControl
    {
        public UCDeleteConfirmation()
        {
            InitializeComponent();
        }

        #region ButtonOk
        private void ButtonOk_Leave(object sender, EventArgs e)
        {
            this.buttonOk.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
        }

        private void ButtonOk_Enter(object sender, EventArgs e)
        {
            this.buttonOk.BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
        }

        private void ButtonOk_Down(object sender, MouseEventArgs e)
        {
            this.buttonOk.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault_Down;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).DialogResult = DialogResult.OK;
            ((Form)this.TopLevelControl).Close();
        }
        #endregion

        #region ButtonCancel
        private void ButtonCancel_Leave(object sender, EventArgs e)
        {
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
        }

        private void ButtonCancel_Enter(object sender, EventArgs e)
        {
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
        }

        private void ButtonCancel_Down(object sender, MouseEventArgs e)
        {
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnDefault_Down;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
        #endregion
    }
}
