namespace Kowoon.Mains
{
    public class JogamdoDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_Jogamdo";
        private string jogamdo_num;
        private string jogamdo_orderBy;
        private string jogamdo_name;
        private string jogamdo_backgroundImage;
        private string jogamdo_widthSize;
        private string jogamdo_heightSize;

        public string Jogamdo_num { get => jogamdo_num; set => jogamdo_num = value; }
        public string Jogamdo_orderBy { get => jogamdo_orderBy; set => jogamdo_orderBy = value; }
        public string Jogamdo_name { get => jogamdo_name; set => jogamdo_name = value; }
        public string Jogamdo_backgroundImage { get => jogamdo_backgroundImage; set => jogamdo_backgroundImage = value; }
        public string Jogamdo_widthSize { get => jogamdo_widthSize; set => jogamdo_widthSize = value; }
        public string Jogamdo_heightSize { get => jogamdo_heightSize; set => jogamdo_heightSize = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            jogamdo_num = "INTEGER PRIMARY KEY AUTOINCREMENT";
            jogamdo_orderBy = "INTEGER UNIQUE NOT NULL";
            jogamdo_name = "NVARCHAR(50) NOT NULL";
            jogamdo_backgroundImage = "NVARCHAR(1024)";
            jogamdo_widthSize = "INTEGER NOT NULL";
            jogamdo_heightSize = "INTEGER NOT NULL";
        }
    }
}
