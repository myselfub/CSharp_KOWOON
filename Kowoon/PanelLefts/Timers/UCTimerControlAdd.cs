using Kowoon.PanelLefts.Externals;
using Kowoon.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Timers
{
    public partial class UCTimerControlAdd : UserControl
    {
        public UCTimerControlAdd()
        {
            InitializeComponent();
        }

        private void UCTimerControlAdd_Load(object sender, EventArgs e)
        {
            this.comboBoxDong.Items.Add("");
            this.comboBoxStairs.Items.Add("");
            this.comboBoxFloor.Items.Add("");
            this.comboBoxAudio.Items.Add("");
            this.comboBoxStartContactPoint.Items.Add("");
            this.comboBoxEndContactPoint.Items.Add("");
            this.comboBoxDong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            List<ExternalDTO> audioItems = Select_ListAudio();
            foreach (ExternalDTO externalDTO in audioItems)
            {
                this.comboBoxAudio.Items.Add(externalDTO.Extn_name);
            }
        }

        #region Button
        private void Button_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
        }

        private void Button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefault_Down;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            TextBox textBox = null;
            try
            {
                if (textBoxStartHour.Text == "" || int.Parse(textBoxStartHour.Text) > 23)
                {
                    textBox = textBoxStartHour;
                }
                else if (textBoxStartMinute.Text == "" || int.Parse(textBoxStartMinute.Text) > 59)
                {
                    textBox = textBoxStartMinute;
                }
                else if (textBoxStartSecond.Text == "" || int.Parse(textBoxStartSecond.Text) > 59)
                {
                    textBox = textBoxStartSecond;
                }
                else if (textBoxEndHour.Text == "" || int.Parse(textBoxEndHour.Text) > 23)
                {
                    textBox = textBoxEndHour;
                }
                else if (textBoxEndMinute.Text == "" || int.Parse(textBoxEndMinute.Text) > 59)
                {
                    textBox = textBoxEndMinute;
                }
                else if (textBoxEndSecond.Text == "" || int.Parse(textBoxEndSecond.Text) > 59)
                {
                    textBox = textBoxEndSecond;
                }
            }
            catch (TypeUnloadedException)
            { }
            if (textBox != null)
            {
                MessageBox.Show("잘못된 값이 있습니다.\n다시 입력해주세요.");
                textBox.Focus();
                return;
            }
            DateTime timrStartTime = DateTime.ParseExact(textBoxStartHour.Text + ":" + textBoxStartMinute.Text + ":" + textBoxStartSecond.Text, "HH:mm:ss", null);
            DateTime timrEndTime = DateTime.ParseExact(textBoxEndHour.Text + ":" + textBoxEndMinute.Text + ":" + textBoxEndSecond.Text, "HH:mm:ss", null);
            if (timrStartTime > timrEndTime)
            {
                MessageBox.Show("종료시간이 시작시간보다 빠를 수 없습니다.\n다시 입력해주세요.");
                textBoxStartHour.Focus();
                return;
            }
            Insert_TimerDTO();
            ((Form)this.TopLevelControl).DialogResult = DialogResult.OK;
            ((Form)this.TopLevelControl).Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
        #endregion

        #region TextBox
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            Regex regex = new Regex(@"^[0-9]{1,2}$");
            if (textBox.Text.IndexOf("\n") > 0 || textBox.Text.IndexOf("\r") > 0 ||
                textBox.Text.IndexOf("\r\n") > 0 || textBox.Text.IndexOf(Environment.NewLine) > 0)
            {
                textBox.Text = textBox.Text.Replace("\n", "").ToString();
                textBox.Text = textBox.Text.Replace("\r", "").ToString();
                textBox.Text = textBox.Text.Replace("\r\n", "").ToString();
                textBox.Text = textBox.Text.Replace(Environment.NewLine, "").ToString();
                textBox.Focus();
            }
            else if (!regex.IsMatch(text))
            {
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text[0..^1]; // textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    textBox.Select(textBox.Text.Length, 0);
                }
                textBox.Focus();
            }
            if (!int.TryParse(textBox.Text, out int num))
            {
                num = 60;
            }
            if (
                ((textBox.Name == this.textBoxStartHour.Name || textBox.Name == this.textBoxEndHour.Name) && num > 23) ||
                ((textBox.Name == textBoxStartMinute.Name || textBox.Name == textBoxEndMinute.Name) && num > 59) ||
                ((textBox.Name == textBoxStartSecond.Name || textBox.Name == textBoxEndSecond.Name) && num > 59)
                )
            {
                textBox.Text = "";
            }
        }

        private void TextBoxTime_Leave(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            int.TryParse(text, out int num);
            if (text.Length < 2)
            {
                ((TextBox)sender).Text = string.Format("{0:D2}", num);
            }
        }
        #endregion

        private void ComboBoxAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAudio.Text.ToString() == "PC")
            {
                labelMP3.Visible = true;
                textBoxMP3.Visible = true;
                buttonSerach.Visible = true;
                this.comboBoxStartContactPoint.Items.Clear();
                this.comboBoxStartContactPoint.Items.Add("시작");
                this.comboBoxEndContactPoint.Items.Clear();
                this.comboBoxEndContactPoint.Items.Add("종료");
            }
            else
            {
                labelMP3.Visible = false;
                textBoxMP3.Visible = false;
                buttonSerach.Visible = false;
                int startItemIndex = this.comboBoxStartContactPoint.FindString("시작");
                int endItemIndex = this.comboBoxEndContactPoint.FindString("종료");
                if (startItemIndex > -1)
                {
                    this.comboBoxStartContactPoint.Items.RemoveAt(startItemIndex);
                }
                if (endItemIndex > -1)
                {
                    this.comboBoxEndContactPoint.Items.RemoveAt(endItemIndex);
                }
            }
        }

        #region SQL
        private List<ExternalDTO> Select_ListAudio()
        {
            List<ExternalDTO> list = new List<ExternalDTO>();
            string sql = "SELECT extn_name FROM kw_external ORDER BY extn_seq";
            DataSet ds = SQLiteManager.GetInstance.SelectQuery(sql, null);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new ExternalDTO
                    {
                        Extn_name = row.Field<string>("extn_name").ToString()
                    }).ToList();
                }
            }
            return list;
        }

        private void Insert_TimerDTO()
        {
            Hashtable prepared = new Hashtable();
            string timrStartTime = textBoxStartHour.Text + ":" + textBoxStartMinute.Text + ":" + textBoxStartSecond.Text;
            string timrEndTime = textBoxEndHour.Text + ":" + textBoxEndMinute.Text + ":" + textBoxEndSecond.Text;
            prepared.Add("@timrStartTime", timrStartTime);
            prepared.Add("@timrEndTime", timrEndTime);
            prepared.Add("@timrMon", checkBoxMon.Checked);
            prepared.Add("@timrTue", checkBoxTue.Checked);
            prepared.Add("@timrWed", checkBoxWed.Checked);
            prepared.Add("@timrThu", checkBoxThu.Checked);
            prepared.Add("@timrFri", checkBoxFri.Checked);
            prepared.Add("@timrSat", checkBoxSat.Checked);
            prepared.Add("@timrSun", checkBoxSun.Checked);
            prepared.Add("@timrDong", comboBoxDong.SelectedItem == null ? "" : comboBoxDong.SelectedItem.ToString());
            prepared.Add("@timrStairs", comboBoxStairs.SelectedItem == null ? "" : comboBoxStairs.SelectedItem.ToString());
            prepared.Add("@timrFloor", comboBoxFloor.SelectedItem == null ? "" : comboBoxFloor.SelectedItem.ToString());
            prepared.Add("@extnName", comboBoxAudio.SelectedItem == null ? "" : comboBoxAudio.SelectedItem.ToString());
            prepared.Add("@timrStartContactPoint", comboBoxStartContactPoint.SelectedItem == null ? "" : comboBoxStartContactPoint.SelectedItem.ToString());
            prepared.Add("@timrEndContactPoint", comboBoxEndContactPoint.SelectedItem == null ? "" : comboBoxEndContactPoint.SelectedItem.ToString());
            ((FormTimer)((Form)this.TopLevelControl).Owner).InsertList.Add(prepared);
        }
        #endregion
    }
}