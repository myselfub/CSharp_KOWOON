namespace Kowoon.PanelLefts.Reservations
{
    public class ReservationDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private const string TABLE_NAME = "KW_Reservation";
        private string resr_no;
        private string resr_date;
        private string resr_start_time;
        private string resr_end_time;
        private string resr_group_broadcasting;
        private string resr_dong;
        private string resr_stairs;
        private string resr_floor;
        private string extn_name;
        private string resr_start_contact_point;
        private string resr_end_contact_point;

        public string Resr_no { get => resr_no; set => resr_no = value; }
        public string Resr_date { get => resr_date; set => resr_date = value; }
        public string Resr_start_time { get => resr_start_time; set => resr_start_time = value; }
        public string Resr_end_time { get => resr_end_time; set => resr_end_time = value; }
        public string Resr_group_broadcasting { get => resr_group_broadcasting; set => resr_group_broadcasting = value; }
        public string Resr_dong { get => resr_dong; set => resr_dong = value; }
        public string Resr_stairs { get => resr_stairs; set => resr_stairs = value; }
        public string Resr_floor { get => resr_floor; set => resr_floor = value; }
        public string Extn_name { get => extn_name; set => extn_name = value; }
        public string Resr_start_contact_point { get => resr_start_contact_point; set => resr_start_contact_point = value; }
        public string Resr_end_contact_point { get => resr_end_contact_point; set => resr_end_contact_point = value; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<사용>")]
        private void CreateTable()
        {
            resr_no = "INT PRIMARY KEY";
            resr_date = "NVARCHAR(10) NOT NULL";
            resr_start_time = "NVARCHAR(10) NOT NULL";
            resr_end_time = "NVARCHAR(10) NOT NULL";
            resr_group_broadcasting = "NVARCHAR(20)";
            resr_dong = "NVARCHAR(20)";
            resr_stairs = "NVARCHAR(20)";
            resr_floor = "NVARCHAR(20)";
            extn_name = "NVARCHAR(20)";
            resr_start_contact_point = "NVARCHAR(512)";
            resr_end_contact_point = "NVARCHAR(512)";
        }
    }
}
