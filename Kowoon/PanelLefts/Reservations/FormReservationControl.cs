using Kowoon.Utils;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Reservations
{
    public partial class FormReservationControl : Form
    {
        private EnumUserControlKinds _controlKinds = EnumUserControlKinds.addControl;
        public EnumUserControlKinds ControlKinds { set => _controlKinds = value; }
        private int _seqNum;
        public int SeqNum { set => _seqNum = value; }

        public FormReservationControl()
        {
            InitializeComponent();
        }

        private void FormTimerControl_Load(object sender, System.EventArgs e)
        {
            UserControl userControl = null;
            switch (_controlKinds)
            {
                case EnumUserControlKinds.addControl:
                    userControl = new UCReservationControlAdd();
                    this.Text = "예약 설정 추가";
                    break;
                case EnumUserControlKinds.modifyControl:
                    userControl = new UCReservationControlModify(_seqNum);
                    this.Text = "예약 설정 수정";
                    break;
            }
            panelReservationControl.Controls.Add(userControl);
        }
    }
}
