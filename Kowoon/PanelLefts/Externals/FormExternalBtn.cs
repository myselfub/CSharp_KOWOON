using Kowoon.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Externals
{
    public partial class FormExternalBtn : Form
    {
        private readonly string _extnName;
        private readonly string _extnSeq;

        private FormExternalBtn() { }
        public FormExternalBtn(string extnName, string extnSeq)
        {
            InitializeComponent();
            _extnName = extnName;
            _extnSeq = extnSeq;
        }

        private void ExternalBtn_Load(object sender, EventArgs e)
        {
            Text = _extnName;
            int sizeWidth = (int)(tableLayoutPanelEBtn.Width * tableLayoutPanelEBtn.ColumnStyles[0].Width / 100);
            List<ExternalBtnDTO> listExternalBtnDTO = SelectList_ExternalBtnDTO(_extnSeq);
            foreach (ExternalBtnDTO externalBtnDTO in listExternalBtnDTO)
            {
                Button button = new Button
                {
                    BackColor = SystemColors.ControlDark,
                    Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point),
                    Cursor = Cursors.Hand
                };
                button.FlatAppearance.BorderSize = 1;
                button.FlatStyle = FlatStyle.Flat;
                button.Location = new Point((int.Parse(externalBtnDTO.Extb_key)) * (sizeWidth), 0);
                button.Name = "button" + externalBtnDTO.Extb_key;
                button.Size = new Size(sizeWidth, 40);
                button.TabIndex = int.Parse(externalBtnDTO.Extb_key);
                button.Text = externalBtnDTO.Extb_name;
                button.UseVisualStyleBackColor = true;
                button.Margin = new Padding(0);
                button.ForeColor = SystemColors.ControlLight;
                button.Click += new EventHandler(Button_Click);
                if (externalBtnDTO.Extb_icon != null && externalBtnDTO.Extb_icon != "")
                {
                    button.BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                }
                tableLayoutPanelEBtn.Controls.Add(button, (int.Parse(externalBtnDTO.Extb_key)), 0);
            }

        }

        #region Button
        private void Button_Click(object sender, EventArgs e)
        {
            tableLayoutPanelEBtn.Focus();
            MessageBox.Show(((Button)sender).Text);
        }

        private void ExternalBtn_Shown(object sender, EventArgs e)
        {
            tableLayoutPanelEBtn.Focus();
        }
        #endregion

        #region SQL
        private List<ExternalBtnDTO> SelectList_ExternalBtnDTO(string extnSeq)
        {
            List<ExternalBtnDTO> list = new List<ExternalBtnDTO>();
            Hashtable prepared = new Hashtable();
            string sql = string.Concat("SELECT extb_key, extb_name, extb_use, extb_on, extb_icon FROM kw_externalbtn WHERE extn_seq = @extnSeq");
            prepared.Add("@extnSeq", extnSeq);
            SQLiteManager sqliteManager = SQLiteManager.GetInstance;
            DataSet ds = sqliteManager.SelectQuery(sql, prepared);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new ExternalBtnDTO
                    {
                        Extb_key = row.Field<int>("extb_key").ToString(),
                        Extb_name = row.Field<string>("extb_name").ToString(),
                        Extb_use = row.Field<bool>("extb_use").ToString(),
                        Extb_on = row.Field<bool>("extb_on").ToString(),
                        Extb_icon = row.Field<string>("extb_icon") == null ? "" : row.Field<string>("extb_icon").ToString()
                    }).ToList();
                }
            }
            return list;
        }
        #endregion
    }
}
