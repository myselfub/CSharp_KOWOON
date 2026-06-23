using Kowoon.MessageForms;
using Kowoon.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Reservations
{
    public partial class FormReservation : Form
    {
        private readonly List<Hashtable> _insertList = new List<Hashtable>();
        public List<Hashtable> InsertList { get => _insertList; }
        private readonly List<Hashtable> _modifyList = new List<Hashtable>();
        public List<Hashtable> ModifyList { get => _modifyList; }
        private SQLiteConnection _sqliteConnection;
        private bool _transaction = false;

        public FormReservation()
        {
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            _sqliteConnection = SQLiteManager.GetInstance.SQLiteConnectionOpen();
            PaintDataGridView_Reservation();
        }

        private void FormReservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLiteManager.GetInstance.SQLiteConnectionClose(_sqliteConnection);
        }

        private void PaintDataGridView_Reservation()
        {
            this.dataGridViewReservation.Rows.Clear();
            this.dataGridViewReservation.Refresh();
            List<ReservationDTO> listReservationDTO = SelectList_ReservationDTO();
            foreach (ReservationDTO reservationDTO in listReservationDTO)
            {
                this.dataGridViewReservation.Rows.Add(reservationDTO.Resr_no,
                    reservationDTO.Resr_date,
                    reservationDTO.Resr_start_time,
                    reservationDTO.Resr_end_time,
                    reservationDTO.Resr_group_broadcasting,
                    reservationDTO.Resr_dong,
                    reservationDTO.Resr_stairs,
                    reservationDTO.Resr_floor,
                    reservationDTO.Extn_name,
                    reservationDTO.Resr_start_contact_point,
                    reservationDTO.Resr_end_contact_point);
            }
        }

        #region Button
        private void Button_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefault;
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefaultBlue;
        }

        private void Button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = global::Kowoon.Properties.Resources.btnDefault_Down;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormReservationControl formReservationControl = new FormReservationControl
            {
                Owner = this
            };
            formReservationControl.ControlKinds = EnumUserControlKinds.addControl;
            if (formReservationControl.ShowDialog() == DialogResult.OK)
            {
                _transaction = true;
                Insert_ReservationDTO();
                PaintDataGridView_Reservation();
            }
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewReservation.SelectedCells.Count > 0)
            {
                HashSet<int> indexs = new HashSet<int>();
                string resrNo = "0";
                foreach (DataGridViewCell dgvc in this.dataGridViewReservation.SelectedCells)
                {
                    indexs.Add(dgvc.RowIndex);
                    resrNo = this.dataGridViewReservation.Rows[dgvc.RowIndex].Cells[0].Value.ToString();
                    if (indexs.Count > 1)
                    {
                        MessageBox.Show("여러개의 행은 수정할 수 없습니다.\n하나의 행만 선택해 주세요.");
                        return;
                    }
                }
                FormReservationControl formReservationControl = new FormReservationControl
                {
                    Owner = this
                };
                formReservationControl.ControlKinds = EnumUserControlKinds.modifyControl;
                formReservationControl.SeqNum = int.Parse(resrNo);
                if (formReservationControl.ShowDialog() == DialogResult.OK)
                {
                    _transaction = true;
                    Update_ReservationDTO();
                    PaintDataGridView_Reservation();
                }
            }
            else
            {
                MessageBox.Show("수정할 행을 선택해 주세요.");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            FormMessage formMessage = new FormMessage
            {
                Owner = this
            };
            formMessage.SetControlKinds(EnumUserControlKinds.deleteConfirmation);
            if (formMessage.ShowDialog() == DialogResult.OK)
            {
                if (this.dataGridViewReservation.SelectedCells.Count > 0)
                {
                    HashSet<string> deleteList = new HashSet<string>();
                    _transaction = true;
                    foreach (DataGridViewCell dgvc in this.dataGridViewReservation.SelectedCells)
                    {
                        deleteList.Add(this.dataGridViewReservation.Rows[dgvc.RowIndex].Cells[0].Value.ToString());
                        Delete_ReservationDTO(deleteList);
                    }
                    PaintDataGridView_Reservation();
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _transaction = false;
            SQLiteManager.GetInstance.SQLiteConnectionCommit(_sqliteConnection);
            PaintDataGridView_Reservation();
            _sqliteConnection = SQLiteManager.GetInstance.SQLiteConnectionOpen();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormMessage formMessage = new FormMessage
            {
                Owner = this
            };
            formMessage.SetControlKinds(EnumUserControlKinds.endConfirmation);
            if (_transaction)
            {
                if (formMessage.ShowDialog() == DialogResult.OK)
                {
                    SQLiteManager.GetInstance.SQLiteConnectionRollback(_sqliteConnection);
                    if (_sqliteConnection != null)
                    {
                        _sqliteConnection = null;
                    }
                }
            }
            this.Close();
        }
        #endregion

        #region SQL
        private List<ReservationDTO> SelectList_ReservationDTO()
        {
            List<ReservationDTO> list = new List<ReservationDTO>();
            string sql = "SELECT resr_no, resr_date, resr_start_time, resr_end_time, " +
                "resr_group_broadcasting, resr_dong, resr_stairs, resr_floor, extn_name, " +
                "resr_start_contact_point, resr_end_contact_point " +
                "FROM kw_reservation ORDER BY resr_no DESC";
            SQLiteManager sqliteManager = SQLiteManager.GetInstance;
            DataSet ds = sqliteManager.SelectQuery_Transaction(sql, null, _sqliteConnection);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new ReservationDTO
                    {
                        Resr_no = row.Field<int>("resr_no").ToString(),
                        Resr_date = row.Field<string>("resr_date").ToString(),
                        Resr_start_time = row.Field<string>("resr_start_time").ToString(),
                        Resr_end_time = row.Field<string>("resr_end_time").ToString(),
                        Resr_group_broadcasting = row.Field<string>("resr_group_broadcasting").ToString() ?? "",
                        Resr_dong = row.Field<string>("resr_dong") == null ? "" : row.Field<string>("resr_dong").ToString(),
                        Resr_stairs = row.Field<string>("resr_stairs") == null ? "" : row.Field<string>("resr_stairs").ToString(),
                        Resr_floor = row.Field<string>("resr_floor") == null ? "" : row.Field<string>("resr_floor").ToString(),
                        Extn_name = row.Field<string>("extn_name") == null ? "" : row.Field<string>("extn_name").ToString(),
                        Resr_start_contact_point = row.Field<string>("resr_start_contact_point") == null ? "" : row.Field<string>("resr_start_contact_point").ToString(),
                        Resr_end_contact_point = row.Field<string>("resr_end_contact_point") == null ? "" : row.Field<string>("resr_end_contact_point").ToString()
                    }).ToList();
                }
            }
            return list;
        }

        private void Insert_ReservationDTO()
        {
            string sql = "INSERT INTO kw_reservation (resr_no, resr_date, resr_start_time, resr_end_time, " +
                   "resr_group_broadcasting, resr_dong, resr_stairs, resr_floor, extn_name, " +
                   "resr_start_contact_point, resr_end_contact_point) " +
                   "VALUES ((SELECT IFNULL(MAX(resr_no) + 1, 0) FROM kw_reservation), @resrDate, @resrStartTime, @resrEndTime, " +
                   "@resrGroupBroadcasting, @resrDong, @resrStairs, @resrFloor, @extnName, @resrStartContactPoint, @resrEndContactPoint)";
            if (_insertList.Count > 0)
            {
                foreach (Hashtable prepared in _insertList)
                {
                    SQLiteManager.GetInstance.ExecuteNonQuery_Transaction(sql, prepared, _sqliteConnection);
                }
            }
            _insertList.Clear();
        }

        private List<ReservationDTO> SelectOne_ReservationDTO(int _resrNo)
        {
            List<ReservationDTO> list = new List<ReservationDTO>();
            Hashtable prepared = new Hashtable();
            string sql = "SELECT resr_no, resr_date, resr_start_time, resr_end_time, " +
                "resr_group_broadcasting, resr_dong, resr_stairs, resr_floor, extn_name, " +
                "resr_start_contact_point, resr_end_contact_point " +
                "FROM kw_reservation WHERE resr_no = @resrNo";
            prepared.Add("@resrNo", _resrNo);
            DataSet ds = SQLiteManager.GetInstance.SelectQuery_Transaction(sql, prepared, _sqliteConnection);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new ReservationDTO
                    {
                        Resr_no = row.Field<int>("resr_no").ToString(),
                        Resr_date = row.Field<string>("resr_date").ToString(),
                        Resr_start_time = row.Field<string>("resr_start_time").ToString(),
                        Resr_end_time = row.Field<string>("resr_end_time").ToString(),
                        Resr_group_broadcasting = row.Field<string>("resr_group_broadcasting").ToString(),
                        Resr_dong = row.Field<string>("resr_dong") == null ? "" : row.Field<string>("resr_dong").ToString(),
                        Resr_stairs = row.Field<string>("resr_stairs") == null ? "" : row.Field<string>("resr_stairs").ToString(),
                        Resr_floor = row.Field<string>("resr_floor") == null ? "" : row.Field<string>("resr_floor").ToString(),
                        Extn_name = row.Field<string>("extn_name") == null ? "" : row.Field<string>("extn_name").ToString(),
                        Resr_start_contact_point = row.Field<string>("resr_start_contact_point") == null ? "" : row.Field<string>("resr_start_contact_point").ToString(),
                        Resr_end_contact_point = row.Field<string>("resr_end_contact_point") == null ? "" : row.Field<string>("resr_end_contact_point").ToString()
                    }).ToList();
                }
            }
            return list;
        }
        public List<ReservationDTO> Select_ReservationDTO(int _resrNo) => SelectOne_ReservationDTO(_resrNo);

        private void Update_ReservationDTO()
        {
            string sql = "UPDATE kw_reservation SET resr_date = @resrDate, resr_start_time = @resrStartTime, resr_end_time = @resrEndTime, " +
                   "resr_group_broadcasting = @resrGroupBroadcasting, resr_dong = @resrDong, resr_stairs = @resrStairs, resr_floor = @resrFloor, " +
                   "extn_name = @extnName, resr_start_contact_point = @resrStartContactPoint, resr_end_contact_point = @resrEndContactPoint WHERE resr_no = @resrNo";
            if (_modifyList.Count > 0)
            {
                foreach (Hashtable prepared in _modifyList)
                {
                    SQLiteManager.GetInstance.ExecuteNonQuery_Transaction(sql, prepared, _sqliteConnection);
                }
            }
            _modifyList.Clear();
        }

        private void Delete_ReservationDTO(HashSet<string> deleteList)
        {
            string sql = "DELETE FROM kw_reservation WHERE resr_no IN (";
            Hashtable prepared = new Hashtable();
            var list = deleteList.Select((Value, Index) => new { Value, Index }).ToList();
            foreach (var anonymousTypes in list)
            {
                sql = sql + "@resr_no" + anonymousTypes.Index + ", ";
                prepared.Add("@resr_no" + anonymousTypes.Index, anonymousTypes.Value);
            }
            sql = sql[0..^2] + ")";
            SQLiteManager.GetInstance.ExecuteNonQuery_Transaction(sql, prepared, _sqliteConnection);
        }
        #endregion
    }
}
