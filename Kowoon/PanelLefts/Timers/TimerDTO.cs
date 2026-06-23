namespace Kowoon.PanelLefts.Timers
{
    public class TimerDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_Timer";
        private string timr_no;
        private string timr_start_time;
        private string timr_end_time;
        private string timr_mon;
        private string timr_tue;
        private string timr_wed;
        private string timr_thu;
        private string timr_fri;
        private string timr_sat;
        private string timr_sun;
        private string timr_dong;
        private string timr_stairs;
        private string timr_floor;
        private string extn_name;
        private string timr_start_contact_point;
        private string timr_end_contact_point;

        public string Timr_no { get => timr_no; set => timr_no = value; }
        public string Timr_start_time { get => timr_start_time; set => timr_start_time = value; }
        public string Timr_end_time { get => timr_end_time; set => timr_end_time = value; }
        public string Timr_mon { get => timr_mon; set => timr_mon = value; }
        public string Timr_tue { get => timr_tue; set => timr_tue = value; }
        public string Timr_wed { get => timr_wed; set => timr_wed = value; }
        public string Timr_thu { get => timr_thu; set => timr_thu = value; }
        public string Timr_fri { get => timr_fri; set => timr_fri = value; }
        public string Timr_sat { get => timr_sat; set => timr_sat = value; }
        public string Timr_sun { get => timr_sun; set => timr_sun = value; }
        public string Timr_dong { get => timr_dong; set => timr_dong = value; }
        public string Timr_stairs { get => timr_stairs; set => timr_stairs = value; }
        public string Timr_floor { get => timr_floor; set => timr_floor = value; }
        public string Extn_name { get => extn_name; set => extn_name = value; }
        public string Timr_start_contact_point { get => timr_start_contact_point; set => timr_start_contact_point = value; }
        public string Timr_end_contact_point { get => timr_end_contact_point; set => timr_end_contact_point = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            timr_no = "INT PRIMARY KEY";
            timr_start_time = "NVARCHAR(10) NOT NULL";
            timr_end_time = "NVARCHAR(10) NOT NULL";
            timr_mon = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_tue = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_wed = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_thu = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_fri = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_sat = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_sun = "BOOLEAN NOT NULL DEFAULT 'FALSE'";
            timr_dong = "NVARCHAR(20)";
            timr_stairs = "NVARCHAR(20)";
            timr_floor = "NVARCHAR(20)";
            extn_name = "NVARCHAR(20)";
            timr_start_contact_point = "NVARCHAR(512)";
            timr_end_contact_point = "NVARCHAR(512)";
        }
    }
}
