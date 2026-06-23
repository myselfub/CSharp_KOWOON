using Kowoon.Utils;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Timers
{
    public partial class FormTimerControl : Form
    {
        private EnumUserControlKinds _controlKinds = EnumUserControlKinds.addControl;
        public EnumUserControlKinds ControlKinds { set => _controlKinds = value; }
        private int _seqNum;
        public int SeqNum { set => _seqNum = value; }

        public FormTimerControl()
        {
            InitializeComponent();
        }

        private void FormTimerControl_Load(object sender, System.EventArgs e)
        {
            UserControl userControl = null;
            switch (_controlKinds)
            {
                case EnumUserControlKinds.addControl:
                    userControl = new UCTimerControlAdd();
                    this.Text = "타이머 설정 추가";
                    break;
                case EnumUserControlKinds.modifyControl:
                    userControl = new UCTimerControlModify(_seqNum);
                    this.Text = "타이머 설정 수정";
                    break;
            }
            panelTimerControl.Controls.Add(userControl);
        }
    }
}
