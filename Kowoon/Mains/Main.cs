using Kowoon.Logins;
using Kowoon.Utils;
using System;
using System.Windows.Forms;

namespace Kowoon.Mains
{
    public partial class Main : Form
    {
        private EnumUserControlKinds _controlKinds = EnumUserControlKinds.mainUser;
        public void SetControlKinds(EnumUserControlKinds controlKinds)
        {
            _controlKinds = controlKinds;
        }
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormLoding loding = new FormLoding
            {
                Owner = this
            };
            this.Hide();
            loding.ShowDialog();
        }

        public void _Show()
        {
            panelMain.Controls.Clear();
            UserControl userControl = null;
            switch (_controlKinds)
            {
                case EnumUserControlKinds.mainAdmin:
                    userControl = new UCMainAdmin();
                    break;
                case EnumUserControlKinds.mainUser:
                    userControl = new UCMainUser();
                    break;
            }
            panelMain.Controls.Add(userControl);
            this.Show();
        }
    }
}