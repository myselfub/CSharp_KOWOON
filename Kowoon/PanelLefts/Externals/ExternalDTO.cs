namespace Kowoon.PanelLefts.Externals
{
    public class ExternalDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_External";
        private string extn_seq;
        private string extn_name;
        private string extn_use;
        private string extn_btnFrom;
        private string extn_btnTo;

        public string Extn_seq { get => extn_seq; set => extn_seq = value; }
        public string Extn_name { get => extn_name; set => extn_name = value; }
        public string Extn_use { get => extn_use; set => extn_use = value; }
        public string Extn_btnFrom { get => extn_btnFrom; set => extn_btnFrom = value; }
        public string Extn_btnTo { get => extn_btnTo; set => extn_btnTo = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            extn_seq = "INT PRIMARY KEY";
            extn_name = "NVARCHAR(20) NOT NULL";
            extn_use = "BOOLEAN NOT NULL DEFAULT 'TRUE'";
            extn_btnFrom = "INT";
            extn_btnTo = "INT";
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private string DefaultQuery()
        {
            return "INSERT INTO kw_external (extn_seq, extn_name, extn_btnFrom, extn_btnTo) VALUES ((SELECT IFNULL(MAX(extn_seq) + 1, 0) FROM kw_external), 'PC', 1, 8)";
        }
    }
}
