using Kowoon.Utils;
using Kowoon.Mains;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Kowoon.Logins
{
    public partial class FormLoding : Form
    {
        private bool _loding = false;
        private readonly object lockObj = new object();
        private Thread thread = null;

        public FormLoding()
        {
            InitializeComponent();
        }

        private void FormLoding_Shown(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                try
                {
                    lock (lockObj)
                    {
                        SQLiteManager sqliteManager = SQLiteManager.GetInstance;
                        _loding = true;
                        if (this.InvokeRequired == true)
                        {
                            this.Invoke((Action)(() =>
                            {
                                FormLogin formLogin = new FormLogin
                                {
                                    Owner = this.Owner
                                };
                                this.Hide();
                                formLogin.ShowDialog();
                                this.Close();
                            }));
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                    thread = null;
                }
            });
            thread.Start();
        }

        private void FormLoding_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (thread != null && thread.IsAlive == true)
                {
                    //thread.Abort();
                    //thread.Join();
                    thread = null;
                }
            }
            catch (ThreadAbortException)
            {
                thread = null;
            }
            if (!_loding)
            {
                _loding = true;
                ((Main)this.Owner).Close();
            }
        }
    }
}
