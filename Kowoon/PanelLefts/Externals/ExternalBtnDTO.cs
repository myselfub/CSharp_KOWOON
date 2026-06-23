using System.Collections.Generic;

namespace Kowoon.PanelLefts.Externals
{
    public class ExternalBtnDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_ExternalBtn";
        private string extb_key;
        private string extb_name;
        private string extb_use;
        private string extb_on;
        private string extb_icon;
        private string extn_seq;
        private string PRIMARY;

        public string Extb_key { get => extb_key; set => extb_key = value; }
        public string Extb_name { get => extb_name; set => extb_name = value; }
        public string Extb_use { get => extb_use; set => extb_use = value; }
        public string Extb_on { get => extb_on; set => extb_on = value; }
        public string Extb_icon { get => extb_icon; set => extb_icon = value; }
        public string Extn_seq { get => extn_seq; set => extn_seq = value; }
        public string PRIMARY1 { get => PRIMARY; set => PRIMARY = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            extb_key = "INT";
            extb_name = "NVARCHAR(20) NOT NULL";
            extb_use = "BOOLEAN NOT NULL DEFAULT 'TRUE'";
            extb_on = "BOOLEAN NOT NULL DEFAULT 'TRUE'";
            extb_icon = "NVARCHAR(512)";
            extn_seq = "INT";
            PRIMARY = "KEY (extb_key, extn_seq)";
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private string[] DefaultQuery()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                list.Add("INSERT INTO kw_externalbtn (extb_key, extb_name, extn_seq) VALUES ((SELECT IFNULL(MAX(extb_key) + 1, 0) FROM kw_externalbtn WHERE extn_seq = 0), 'Button" + i + "', 0)");
            }
            return list.ToArray();
        }
    }
}
