using Kowoon.Mains;
using Kowoon.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kowoon.Logins
{
    public partial class FormLogin : Form
    {
        private bool _logined = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login(bool isAdmin)
        {
            Main main = (Main)this.Owner;
            if (isAdmin)
            {
                main.SetControlKinds(EnumUserControlKinds.mainAdmin);
            }
            else
            {
                main.SetControlKinds(EnumUserControlKinds.mainUser);
            }
            main._Show();
            _logined = true;
            this.Close();
        }

        #region TextChanged
        private void TextboxId_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.IndexOf("\n") > 0 || textBox.Text.IndexOf("\r") > 0 ||
                textBox.Text.IndexOf("\r\n") > 0 || textBox.Text.IndexOf(Environment.NewLine) > 0)
            {
                textBox.Text = textBox.Text.Replace("\n", "").ToString();
                textBox.Text = textBox.Text.Replace("\r", "").ToString();
                textBox.Text = textBox.Text.Replace("\r\n", "").ToString();
                textBox.Text = textBox.Text.Replace(Environment.NewLine, "").ToString();
                this.textBoxPw.Focus();
            }
        }

        private void TextboxPw_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.IndexOf("\n") > 0 || textBox.Text.IndexOf("\r") > 0 ||
                textBox.Text.IndexOf("\r\n") > 0 || textBox.Text.IndexOf(Environment.NewLine) > 0)
            {
                textBox.Text = textBox.Text.Replace("\n", "").ToString();
                textBox.Text = textBox.Text.Replace("\r", "").ToString();
                textBox.Text = textBox.Text.Replace("\r\n", "").ToString();
                textBox.Text = textBox.Text.Replace(Environment.NewLine, "").ToString();
                this.buttonLogin.Focus();
            }
        }
        #endregion

        #region FormLogin
        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void FormLogin_Closing(object sender, FormClosingEventArgs e)
        {
            if (!_logined)
            {
                _logined = true;
                ((Main)this.Owner).Close();
            }
        }
        #endregion

        #region ButtonLogin
        private void ButtonLogin_Leave(object sender, EventArgs e)
        {
            this.buttonLogin.BackgroundImage = global::Kowoon.Properties.Resources.btnLogin;
        }

        private void ButtonLogin_Enter(object sender, EventArgs e)
        {
            this.buttonLogin.BackgroundImage = global::Kowoon.Properties.Resources.btnLogin_Enter;
        }

        private void ButtonLogin_Down(object sender, MouseEventArgs e)
        {
            this.buttonLogin.BackgroundImage = global::Kowoon.Properties.Resources.btnLogin_Down;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string userId = this.textBoxId.Text;
            string userPw = this.textBoxPw.Text;
            Regex regexId = new Regex(@"^[0-9a-zA-Z가-힣]{1,25}$");
            Regex regexPw = new Regex(@"^[0-9a-zA-Z가-힣!$%^]{1,25}$");
            if (userId == null || userId == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                this.textBoxId.Focus();
                return;
            }
            else if (!regexId.IsMatch(userId))
            {
                MessageBox.Show("아이디에 잘못된 문자가 있습니다.\n 다시 입력해주세요.");
                this.textBoxId.Focus();
                return;
            }
            if (userPw == null || userPw == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                this.textBoxPw.Focus();
                return;
            }
            else if (!regexPw.IsMatch(userPw))
            {
                MessageBox.Show("비밀번호에 잘못된 문자가 있습니다.\n 다시 입력해주세요.");
                this.textBoxId.Focus();
                return;
            }
            string encodingPw = Convert.ToBase64String(Encoding.UTF8.GetBytes(userPw));
            List<UserDTO> listUserDTO = SelectList_UserDTO(userId);
            foreach (UserDTO userDTO in listUserDTO)
            {
                
            }
            Login(false);
        }
        #endregion

        #region ButtonCancel
        private void ButtonCancel_Leave(object sender, EventArgs e)
        {
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnCancel;
        }

        private void ButtonCancel_Enter(object sender, EventArgs e)
        {
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnCancel_Enter;
        }

        private void ButtonCancel_Down(object sender, MouseEventArgs e)
        {
            this.buttonCancel.BackgroundImage = global::Kowoon.Properties.Resources.btnCancel_Down;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SQL
        private List<UserDTO> SelectList_UserDTO(string userId)
        {
            List<UserDTO> list = new List<UserDTO>();
            Hashtable prepared = new Hashtable();
            string sql = String.Concat("SELECT user_id, user_pw FROM KW_User WHERE user_id = @userId");
            prepared.Add("@userId", userId);
            SQLiteManager sqliteManager = SQLiteManager.GetInstance;
            DataSet ds = sqliteManager.SelectQuery(sql, prepared);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new UserDTO
                    {
                        User_id = row.Field<string>("user_id").ToString(),
                        User_pw = row.Field<string>("user_pw").ToString()
                    }).ToList();
                }
            }
            return list;
        }
        #endregion
    }
}
