using Kowoon.MessageForms;
using Kowoon.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Kowoon.PanelLefts.Timers
{
    public partial class FormTimer : Form
    {
        private readonly List<Hashtable> _insertList = new List<Hashtable>();
        public List<Hashtable> InsertList { get => _insertList; }
        private readonly List<Hashtable> _modifyList = new List<Hashtable>();
        public List<Hashtable> ModifyList { get => _modifyList; }
        private SQLiteConnection _sqliteConnection;
        private bool _transaction = false;

        public FormTimer()
        {
            InitializeComponent();
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            _sqliteConnection = SQLiteManager.GetInstance.SQLiteConnectionOpen();
            PaintDataGridView_Timer();
        }

        private void FormTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLiteManager.GetInstance.SQLiteConnectionClose(_sqliteConnection);
        }

        private void PaintDataGridView_Timer()
        {
            this.dataGridViewTimer.Rows.Clear();
            this.dataGridViewTimer.Refresh();
            List<TimerDTO> listTimerDTO = SelectList_TimerDTO();
            foreach (TimerDTO timerDTO in listTimerDTO)
            {
                this.dataGridViewTimer.Rows.Add(timerDTO.Timr_no,
                    timerDTO.Timr_start_time,
                    timerDTO.Timr_end_time,
                    timerDTO.Timr_mon,
                    timerDTO.Timr_tue,
                    timerDTO.Timr_wed,
                    timerDTO.Timr_thu,
                    timerDTO.Timr_fri,
                    timerDTO.Timr_sat,
                    timerDTO.Timr_sun,
                    timerDTO.Timr_dong,
                    timerDTO.Timr_stairs,
                    timerDTO.Timr_floor,
                    timerDTO.Extn_name,
                    timerDTO.Timr_start_contact_point,
                    timerDTO.Timr_end_contact_point);
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
            FormTimerControl formTimerControl = new FormTimerControl
            {
                Owner = this
            };
            formTimerControl.ControlKinds = EnumUserControlKinds.addControl;
            if (formTimerControl.ShowDialog() == DialogResult.OK)
            {
                _transaction = true;
                Insert_TimerDTO();
                PaintDataGridView_Timer();
            }
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewTimer.SelectedCells.Count > 0)
            {
                HashSet<int> indexs = new HashSet<int>();
                string timrNo = "0";
                foreach (DataGridViewCell dgvc in this.dataGridViewTimer.SelectedCells)
                {
                    indexs.Add(dgvc.RowIndex);
                    timrNo = this.dataGridViewTimer.Rows[dgvc.RowIndex].Cells[0].Value.ToString();
                    if (indexs.Count > 1)
                    {
                        MessageBox.Show("여러개의 행은 수정할 수 없습니다.\n하나의 행만 선택해 주세요.");
                        return;
                    }
                }
                FormTimerControl formTimerControl = new FormTimerControl
                {
                    Owner = this
                };
                formTimerControl.ControlKinds = EnumUserControlKinds.modifyControl;
                formTimerControl.SeqNum = int.Parse(timrNo);
                if (formTimerControl.ShowDialog() == DialogResult.OK)
                {
                    _transaction = true;
                    Update_TimerDTO();
                    PaintDataGridView_Timer();
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
                if (this.dataGridViewTimer.SelectedCells.Count > 0)
                {
                    HashSet<string> deleteList = new HashSet<string>();
                    _transaction = true;
                    foreach (DataGridViewCell dgvc in this.dataGridViewTimer.SelectedCells)
                    {
                        deleteList.Add(this.dataGridViewTimer.Rows[dgvc.RowIndex].Cells[0].Value.ToString());
                        Delete_TimerDTO(deleteList);
                    }
                    PaintDataGridView_Timer();
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _transaction = false;
            SQLiteManager.GetInstance.SQLiteConnectionCommit(_sqliteConnection);
            PaintDataGridView_Timer();
            _sqliteConnection = SQLiteManager.GetInstance.SQLiteConnectionOpen();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            FormMessage formMessage = new FormMessage();
            formMessage.Owner = this;
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
        private List<TimerDTO> SelectList_TimerDTO()
        {
            List<TimerDTO> list = new List<TimerDTO>();
            string sql = "SELECT timr_no, timr_start_time, timr_end_time, " +
                "timr_mon, timr_tue, timr_wed, timr_thu, timr_fri, timr_sat, timr_sun, " +
                "timr_dong, timr_stairs, timr_floor, extn_name, timr_start_contact_point, timr_end_contact_point " +
                "FROM KW_Timer ORDER BY timr_no DESC";
            SQLiteManager sqliteManager = SQLiteManager.GetInstance;
            DataSet ds = sqliteManager.SelectQuery_Transaction(sql, null, _sqliteConnection);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new TimerDTO
                    {
                        Timr_no = row.Field<int>("timr_no").ToString(),
                        Timr_start_time = row.Field<string>("timr_start_time").ToString(),
                        Timr_end_time = row.Field<string>("timr_end_time").ToString(),
                        Timr_mon = row.Field<bool>("timr_mon").ToString(),
                        Timr_tue = row.Field<bool>("timr_tue").ToString(),
                        Timr_wed = row.Field<bool>("timr_wed").ToString(),
                        Timr_thu = row.Field<bool>("timr_thu").ToString(),
                        Timr_fri = row.Field<bool>("timr_fri").ToString(),
                        Timr_sat = row.Field<bool>("timr_sat").ToString(),
                        Timr_sun = row.Field<bool>("timr_sun").ToString(),
                        Timr_dong = row.Field<string>("timr_dong") == null ? "" : row.Field<string>("timr_dong").ToString(),
                        Timr_stairs = row.Field<string>("timr_stairs") == null ? "" : row.Field<string>("timr_stairs").ToString(),
                        Timr_floor = row.Field<string>("timr_floor") == null ? "" : row.Field<string>("timr_floor").ToString(),
                        Extn_name = row.Field<string>("extn_name") == null ? "" : row.Field<string>("extn_name").ToString(),
                        Timr_start_contact_point = row.Field<string>("timr_start_contact_point") == null ? "" : row.Field<string>("timr_start_contact_point").ToString(),
                        Timr_end_contact_point = row.Field<string>("timr_end_contact_point") == null ? "" : row.Field<string>("timr_end_contact_point").ToString()
                    }).ToList();
                }
            }
            return list;
        }

        private void Insert_TimerDTO()
        {
            string sql = "INSERT INTO kw_timer (timr_no, timr_start_time, timr_end_time, " +
                   "timr_mon, timr_tue, timr_wed, timr_thu, timr_fri, timr_sat, timr_sun, " +
                   "timr_dong, timr_stairs, timr_floor, extn_name, timr_start_contact_point, timr_end_contact_point) " +
                   "VALUES ((SELECT IFNULL(MAX(timr_no) + 1, 0) FROM kw_timer), @timrStartTime, @timrEndTime, " +
                   "@timrMon, @timrTue, @timrWed, @timrThu, @timrFri, @timrSat, @timrSun, " +
                   "@timrDong, @timrStairs, @timrFloor, @extnName, @timrStartContactPoint, @timrEndContactPoint)";
            if (_insertList.Count > 0)
            {
                foreach (Hashtable prepared in _insertList)
                {
                    SQLiteManager.GetInstance.ExecuteNonQuery_Transaction(sql, prepared, _sqliteConnection);
                }
            }
            _insertList.Clear();
        }

        private List<TimerDTO> SelectOne_TimerDTO(int _timrNo)
        {
            List<TimerDTO> list = new List<TimerDTO>();
            Hashtable prepared = new Hashtable();
            string sql = "SELECT timr_no, timr_start_time, timr_end_time, " +
                "timr_mon, timr_tue, timr_wed, timr_thu, timr_fri, timr_sat, timr_sun, " +
                "timr_dong, timr_stairs, timr_floor, extn_name, timr_start_contact_point, timr_end_contact_point " +
                "FROM kw_timer WHERE timr_no = @timrNo";
            prepared.Add("@timrNo", _timrNo);
            DataSet ds = SQLiteManager.GetInstance.SelectQuery_Transaction(sql, prepared, _sqliteConnection);
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    list = dt.AsEnumerable().Select(row => new TimerDTO
                    {
                        Timr_no = row.Field<int>("timr_no").ToString(),
                        Timr_start_time = row.Field<string>("timr_start_time").ToString(),
                        Timr_end_time = row.Field<string>("timr_end_time").ToString(),
                        Timr_mon = row.Field<bool>("timr_mon").ToString(),
                        Timr_tue = row.Field<bool>("timr_tue").ToString(),
                        Timr_wed = row.Field<bool>("timr_wed").ToString(),
                        Timr_thu = row.Field<bool>("timr_thu").ToString(),
                        Timr_fri = row.Field<bool>("timr_fri").ToString(),
                        Timr_sat = row.Field<bool>("timr_sat").ToString(),
                        Timr_sun = row.Field<bool>("timr_sun").ToString(),
                        Timr_dong = row.Field<string>("timr_dong") == null ? "" : row.Field<string>("timr_dong").ToString(),
                        Timr_stairs = row.Field<string>("timr_stairs") == null ? "" : row.Field<string>("timr_stairs").ToString(),
                        Timr_floor = row.Field<string>("timr_floor") == null ? "" : row.Field<string>("timr_floor").ToString(),
                        Extn_name = row.Field<string>("extn_name") == null ? "" : row.Field<string>("extn_name").ToString(),
                        Timr_start_contact_point = row.Field<string>("timr_start_contact_point") == null ? "" : row.Field<string>("timr_start_contact_point").ToString(),
                        Timr_end_contact_point = row.Field<string>("timr_end_contact_point") == null ? "" : row.Field<string>("timr_end_contact_point").ToString()
                    }).ToList();
                }
            }
            return list;
        }
        public List<TimerDTO> Select_TimerDTO(int _timrNo) => SelectOne_TimerDTO(_timrNo);

        private void Update_TimerDTO()
        {
            string sql = "UPDATE kw_timer SET timr_start_time = @timrStartTime, timr_end_time = @timrEndTime, " +
                   "timr_mon = @timrMon, timr_tue = @timrTue, timr_wed = @timrWed, timr_thu = @timrThu, timr_fri = @timrFri, timr_sat = @timrSat, timr_sun = @timrSun, " +
                   "timr_dong = @timrDong, timr_stairs = @timrStairs, timr_floor = @timrFloor, extn_name = @extnName, " +
                   "timr_start_contact_point = @timrStartContactPoint, timr_end_contact_point = @timrEndContactPoint WHERE timr_no = @timrNo";
            if (_modifyList.Count > 0)
            {
                foreach (Hashtable prepared in _modifyList)
                {
                    SQLiteManager.GetInstance.ExecuteNonQuery_Transaction(sql, prepared, _sqliteConnection);
                }
            }
            _modifyList.Clear();
        }

        private void Delete_TimerDTO(HashSet<string> deleteList)
        {
            string sql = "DELETE FROM kw_timer WHERE timr_no IN (";
            Hashtable prepared = new Hashtable();
            var list = deleteList.Select((Value, Index) => new { Value, Index }).ToList();
            foreach (var anonymousTypes in list)
            {
                sql = sql + "@timr_no" + anonymousTypes.Index + ", ";
                prepared.Add("@timr_no" + anonymousTypes.Index, anonymousTypes.Value);
            }
            sql = sql.Substring(0, sql.Length - 2) + ")";
            SQLiteManager.GetInstance.ExecuteNonQuery_Transaction(sql, prepared, _sqliteConnection);
        }
        #endregion
    }
}
