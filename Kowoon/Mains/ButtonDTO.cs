namespace Kowoon.Mains
{
    public class ButtonDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_Button";
        private string jogamdo_num;
        private string button_key;
        private string button_on;
        private string button_off;
        private string button_name1;
        private string button_name2;
        private string button_name3;
        private string button_name4;
        private string button_name5;
        private string button_size1;
        private string button_size2;
        private string button_size3;
        private string button_size4;
        private string button_size5;
        private string button_isUse;
        private string button_backgroundImage;
        private string button_widthSize;
        private string button_heightSize;
        private string button_pointX;
        private string button_pointY;
        private string constraint;

        public string Jogamdo_num { get => jogamdo_num; set => jogamdo_num = value; }
        public string Button_key { get => button_key; set => button_key = value; }
        public string Button_on { get => button_on; set => button_on = value; }
        public string Button_off { get => button_off; set => button_off = value; }
        public string Button_name1 { get => button_name1; set => button_name1 = value; }
        public string Button_name2 { get => button_name2; set => button_name2 = value; }
        public string Button_name3 { get => button_name3; set => button_name3 = value; }
        public string Button_name4 { get => button_name4; set => button_name4 = value; }
        public string Button_name5 { get => button_name5; set => button_name5 = value; }
        public string Button_size1 { get => button_size1; set => button_size1 = value; }
        public string Button_size2 { get => button_size2; set => button_size2 = value; }
        public string Button_size3 { get => button_size3; set => button_size3 = value; }
        public string Button_size4 { get => button_size4; set => button_size4 = value; }
        public string Button_size5 { get => button_size5; set => button_size5 = value; }
        public string Button_isUse { get => button_isUse; set => button_isUse = value; }
        public string Button_backgroundImage { get => button_backgroundImage; set => button_backgroundImage = value; }
        public string Button_widthSize { get => button_widthSize; set => button_widthSize = value; }
        public string Button_heightSize { get => button_heightSize; set => button_heightSize = value; }
        public string Button_pointX { get => button_pointX; set => button_pointX = value; }
        public string Button_pointY { get => button_pointY; set => button_pointY = value; }
        public string Constraint { get => constraint; set => constraint = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            jogamdo_num = "INTEGER";
            button_key = "NVARCHAR(10)";
            button_on = "CHAR(1)";
            button_off = "CHAR(1)";
            button_name1 = "NVARCHAR(100)";
            button_name2 = "NVARCHAR(100)";
            button_name3 = "NVARCHAR(100)";
            button_name4 = "NVARCHAR(100)";
            button_name5 = "NVARCHAR(100)";
            button_size1 = "INTEGER";
            button_size2 = "INTEGER";
            button_size3 = "INTEGER";
            button_size4 = "INTEGER";
            button_size5 = "INTEGER";
            button_isUse = "BOOLEAN NOT NULL DEFAULT 'TRUE'";
            button_backgroundImage = "NVARCHAR(1024)";
            button_widthSize = "INTEGER NOT NULL";
            button_heightSize = "INTEGER NOT NULL";
            button_pointX = "INTEGER NOT NULL DEFAULT 0";
            button_pointY = "INTEGER NOT NULL DEFAULT 0";
            constraint = "PRIMARY KEY(jogamdo_num, button_key)";
        }
    }
}
