using Kowoon.Utils;
using System;
using System.Windows.Forms;

namespace Kowoon.MessageForms
{
    public partial class FormMessage : Form
    {
        private EnumUserControlKinds _controlKinds = EnumUserControlKinds.notFindMainPort;
        public void SetControlKinds(EnumUserControlKinds controlKinds)
        {
            _controlKinds = controlKinds;
        }

        public FormMessage()
        {
            InitializeComponent();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            //Point owner_location = this.Owner.Location;
            //int owner_width = this.Owner.Size.Width;

            //int x = owner_location.X + owner_width + 5;
            //this.Location = new Point(x, owner_location.Y + 3);
            UserControl userControl = null;
            switch (_controlKinds)
            {
                case EnumUserControlKinds.notFindMainPort:
                    userControl = new UCNotFindMainPort();
                    break;
                case EnumUserControlKinds.notFindAudioPort:
                    userControl = new UCNotFindMainPort();
                    break;
                case EnumUserControlKinds.endConfirmation:
                    userControl = new UCEndConfirmation();
                    break;
                case EnumUserControlKinds.deleteConfirmation:
                    userControl = new UCDeleteConfirmation();
                    break;
            }
            panelMessage.Controls.Add(userControl);
        }
    }
}
