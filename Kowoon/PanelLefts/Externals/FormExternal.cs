using Kowoon.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Externals
{
    public partial class FormExternal : Form
    {
        private readonly Dictionary<string, string> _buttonInfo = new Dictionary<string, string>();
        public FormExternal()
        {
            InitializeComponent();
        }

        private void External_Load(object sender, EventArgs e)
        {
            List<ExternalDTO> listExternalDTO = SelectList_ExternalDTO();
            foreach (ExternalDTO externalDTO in listExternalDTO)
            {
                _buttonInfo.Add(this.tableLayoutPanelExternal.RowCount.ToString(), externalDTO.Extn_seq);
                Button button = new Button();
                button.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point);
                button.BackColor = Color.Transparent;
                button.BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Cursor = Cursors.Hand;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.Transparent;
                button.Location = new Point(0, (34 * this.tableLayoutPanelExternal.RowCount));
                button.Name = "buttonExternal" + this.tableLayoutPanelExternal.RowCount;
                button.Size = new Size(120, 34);
                button.TabIndex = this.tableLayoutPanelExternal.RowCount;
                button.Text = externalDTO.Extn_name;
                button.UseVisualStyleBackColor = true;
                button.Margin = new Padding(0);
                button.ForeColor = SystemColors.ControlText;
                button.Click += new EventHandler(this.ButtonExternal_Click);
                button.MouseDown += new MouseEventHandler(this.ButtonExternal_Down);
                button.MouseUp += new MouseEventHandler(this.ButtonExternal_Enter);
                button.MouseEnter += new EventHandler(this.ButtonExternal_Enter);
                button.MouseLeave += new EventHandler(this.ButtonExternal_Leave);
                this.tableLayoutPanelExternal.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
                this.tableLayoutPanelExternal.Controls.Add(button, 0, this.tableLayoutPanelExternal.RowCount);
                this.tableLayoutPanelExternal.RowCount++;
            }
        }

        #region ButtonExternal
        private void ButtonExternal_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
        }

        private void ButtonExternal_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefault_Enter;
        }

        private void ButtonExternal_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefault_Down;
        }

        private void ButtonExternal_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanelExternal.Focus();
            FormExternalBtn formExternalBtn = new FormExternalBtn(((Button)sender).Text, ((Button)sender).Name.Substring("buttonExternal".Length));
            formExternalBtn.Show();
        }
        #endregion

        #region SQL
        private List<ExternalDTO> SelectList_ExternalDTO()
        {
            List<ExternalDTO> list = new List<ExternalDTO>();
            string sql = "SELECT extn_seq, extn_name FROM kw_external ORDER BY extn_seq";
            SQLiteManager sqliteManager = SQLiteManager.GetInstance;
            DataSet ds = sqliteManager.SelectQuery(sql, null);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new ExternalDTO
                    {
                        Extn_seq = row.Field<int>("extn_seq").ToString(),
                        Extn_name = row.Field<string>("extn_name").ToString()
                    }).ToList();
                }
            }
            return list;
        }
        #endregion
    }
}
