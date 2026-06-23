namespace Kowoon.Logins
{
    public class UserDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_User";
        private string user_num;
        private string user_id;
        private string user_pw;
        private string user_name;
        private string user_createAt;

        public string User_num { get => user_num; set => user_num = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public string User_pw { get => user_pw; set => user_pw = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string User_createAt { get => user_createAt; set => user_createAt = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            user_num = "INTEGER PRIMARY KEY AUTOINCREMENT";
            user_id = "NVARCHAR(25) UNIQUE NOT NULL";
            user_pw = "NVARCHAR(40) NOT NULL";
            user_name = "NVARCHAR(20)";
            user_createAt = "DATETIME NOT NULL DEFAULT (DATETIME('NOW','LOCALTIME'))";
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private string[] DefaultQuery()
        {
            return new string[] {
                "INSERT INTO kw_user (user_id, user_pw, user_name) VALUES ('kowoon', '1', 'admin')",
                "INSERT INTO kw_user (user_id, user_pw, user_name) VALUES ('admin', '1', 'admin')"
            };
        }
    }
}
