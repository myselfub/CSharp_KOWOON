using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace Kowoon.Utils
{
    internal class SQLiteManager
    {
        private static readonly Lazy<SQLiteManager> _lazy = new Lazy<SQLiteManager>(() => new SQLiteManager());
        public static SQLiteManager GetInstance => _lazy.Value;

        private Hashtable _connection = new Hashtable();
        private readonly string _connPath;
        private const string _connFileName = "Kowoon.sqlite";
        private readonly string _connStr;

        private SQLiteManager()
        {
            _connPath = FileManager.GetInstance.GetResourceDirectoryPath();
            _connStr = "Data Source=" + _connPath + "\\" + _connFileName + ";Version=3;"; // Password=Kowoon;
            // string connStr = _connStr.Substring(0, _connStr.Length - _connStr.Substring(_connStr.IndexOf("Password")).Length);
            string connPath = _connPath + "\\" + _connFileName;
            if (!FileManager.GetInstance.FileExists(connPath))
            {
                SQLiteConnection.CreateFile(connPath);
            }
            Init();
        }

        /// <summary>
        /// 테이블 자동 생성
        /// </summary>
        private void Init()
        {
            foreach (string tableName in DefaultTable.GetInstance.GetDefaultTableNames())
            {
                if (!ExistsTable(tableName))
                {
                    CreateTable(tableName);
                    HashSet<string> querys = DefaultTable.GetInstance.GetDefaultQuery(tableName);
                    InsertTable(querys);
                }
            }
        }

        /// <summary>
        /// 테이블 존재 여부 확인
        /// </summary>
        /// <param name="tableName">테이블명</param>
        /// <returns></returns>
        public bool ExistsTable(string tableName)
        {
            bool tableExists = true;
            string result = "";
            string sql = "SELECT count(*) AS count FROM sqlite_master WHERE name = '" + tableName + "'";
            try
            {
                using SQLiteConnection conn = new SQLiteConnection(_connStr, true);
                conn.Open();

                SQLiteCommand sc = new SQLiteCommand(sql, conn);
                SQLiteDataReader sdr = sc.ExecuteReader();
                while (sdr.Read())
                {
                    result = sdr["count"].ToString(); // (string) cmd.ExecuteScalar()
                }
                sdr.Close();
                conn.Close();
            }
            catch (SQLiteException se)
            {
                Console.WriteLine(se.Message); // Log
                MessageBox.Show("SQL 에러 발생");
            }
            if (result == "0")
            {
                tableExists = false;
            }

            return tableExists;
        }

        /// <summary>
        /// 기본 테이블 생성
        /// </summary>
        /// <param name="tableName"></param>
        public void CreateTable(string tableName)
        {
            Dictionary<string, string> table = DefaultTable.GetInstance.GetDefaultTable(tableName);
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in table)
            {
                if (kvp.Key.Equals("constraint"))
                {
                    sb.Append(kvp.Value);
                    sb.Append(", ");
                }
                else
                {
                    sb.Append(kvp.Key);
                    sb.Append(" ");
                    sb.Append(kvp.Value);
                    sb.Append(", ");
                }
            }
            sb.Remove(sb.Length - 2, 2);
            string sql = "CREATE TABLE " + tableName + " (" + sb.ToString() + ")";
            try
            {
                using SQLiteConnection conn = new SQLiteConnection(_connStr);
                conn.Open();
                SQLiteCommand sc = new SQLiteCommand(sql, conn);
                sc.ExecuteNonQuery();
                conn.Close();
            }
            catch (SQLiteException se)
            {
                Console.WriteLine(se.Message); // Log
                MessageBox.Show("SQL 에러 발생");
            }
        }

        /// <summary>
        /// 기본 데이터 삽입
        /// </summary>
        /// <param name="querys"></param>
        public void InsertTable(HashSet<string> querys)
        {
            try
            {
                foreach (string sql in querys)
                {
                    using SQLiteConnection conn = new SQLiteConnection(_connStr);
                    conn.Open();
                    SQLiteCommand sc = new SQLiteCommand(sql, conn);
                    sc.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (SQLiteException se)
            {
                Console.WriteLine(se.Message); // Log
                MessageBox.Show("SQL 에러 발생");
            }
        }

        /// <summary>
        /// Query API
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="prepared">Data</param>
        public void ExecuteNonQuery(string sql, Hashtable prepared)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(_connStr))
                {
                    SQLiteCommand sc = new SQLiteCommand(sql, conn);
                    if (prepared != null && prepared.Count > 0)
                    {
                        foreach (DictionaryEntry de in prepared)
                        {
                            sc.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                        }
                        sc.CommandType = CommandType.Text;
                        sc.Prepare();
                    }
                    conn.Open();
                    sc.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (SQLiteException se)
            {
                Console.WriteLine(se.Message); // Log
                MessageBox.Show("SQL 에러 발생");
            }
        }

        /// <summary>
        /// SELECT SQL API
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="prepared">Data</param>
        /// <returns></returns>
        public DataSet SelectQuery(string sql, Hashtable prepared)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(_connStr))
                {
                    SQLiteCommand sc = new SQLiteCommand(sql, conn);
                    if (prepared != null && prepared.Count > 0)
                    {
                        foreach (DictionaryEntry de in prepared)
                        {
                            sc.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                        }
                        sc.CommandType = CommandType.Text;
                        sc.Prepare();
                    }
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sc);
                    conn.Open();
                    sda.Fill(ds);
                    conn.Close();
                }
            }
            catch (SQLiteException se)
            {
                Console.WriteLine(se.Message); // Log
                string errorCode = LogAndExceptionManager.GetInstance.GetErrorCode("SQLiteException");
                string errorMessage = LogAndExceptionManager.GetInstance.GetErrorMessage("SQLiteException");
                MessageBox.Show("ErrorCode : " + errorCode + "\n" + errorMessage);
            }

            return ds;
        }

        /// <summary>
        /// Connection Open API
        /// </summary>
        /// <returns>SQL Connection</returns>
        public SQLiteConnection SQLiteConnectionOpen()
        {
            SQLiteConnection conn = new SQLiteConnection(_connStr);
            conn.Open();
            _connection.Add(conn, conn.BeginTransaction());
            return conn;
        }

        /// <summary>
        /// Connection Close API
        /// </summary>
        /// <param name="sqliteConnection">SQL Connection</param>
        public void SQLiteConnectionClose(SQLiteConnection sqliteConnection)
        {
            if (sqliteConnection != null)
            {
                try
                {
                    foreach (DictionaryEntry de in _connection)
                    {
                        if (de.Key == sqliteConnection)
                        {
                            ((SQLiteTransaction)de.Value).Rollback();
                        }
                    }
                    sqliteConnection.Close();
                    _connection.Remove(sqliteConnection);
                    sqliteConnection = null;
                }
                catch (SQLiteException se)
                {
                    Console.WriteLine(se.Message); // Log
                    string errorCode = LogAndExceptionManager.GetInstance.GetErrorCode("SQLiteException");
                    string errorMessage = LogAndExceptionManager.GetInstance.GetErrorMessage("SQLiteException");
                    MessageBox.Show("ErrorCode : " + errorCode + "\n" + errorMessage);
                }
            }
        }

        /// <summary>
        /// Database Transaction Commit API
        /// </summary>
        /// <param name="sqliteConnection">SQL Connection</param>
        public void SQLiteConnectionCommit(SQLiteConnection sqliteConnection)
        {
            if (sqliteConnection != null)
            {
                try
                {
                    foreach (DictionaryEntry de in _connection)
                    {
                        if (de.Key == sqliteConnection)
                        {
                            ((SQLiteTransaction)de.Value).Commit();
                        }
                    }
                }
                catch (SQLiteException se)
                {
                    Console.WriteLine(se.Message); // Log
                    string errorCode = LogAndExceptionManager.GetInstance.GetErrorCode("SQLiteException");
                    string errorMessage = LogAndExceptionManager.GetInstance.GetErrorMessage("SQLiteException");
                    MessageBox.Show("ErrorCode : " + errorCode + "\n" + errorMessage);
                }
            }
        }

        /// <summary>
        /// Database Transaction Roolback API
        /// </summary>
        /// <param name="sqliteConnection">SQL Connection</param>
        public void SQLiteConnectionRollback(SQLiteConnection sqliteConnection)
        {
            if (sqliteConnection != null)
            {
                try
                {
                    foreach (DictionaryEntry de in _connection)
                    {
                        if (de.Key == sqliteConnection)
                        {
                            ((SQLiteTransaction)de.Value).Rollback();
                        }
                    }
                }
                catch (SQLiteException se)
                {
                    Console.WriteLine(se.Message); // Log
                    string errorCode = LogAndExceptionManager.GetInstance.GetErrorCode("SQLiteException");
                    string errorMessage = LogAndExceptionManager.GetInstance.GetErrorMessage("SQLiteException");
                    MessageBox.Show("ErrorCode : " + errorCode + "\n" + errorMessage);
                }
            }
        }

        /// <summary>
        /// Transaction을 위해 Database Connection Close를 하지 않은 상태로 Query를 보내기 위한 API
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="prepared">Data</param>
        /// <param name="sqliteConnection">SQL Connection</param>
        public void ExecuteNonQuery_Transaction(string sql, Hashtable prepared, SQLiteConnection sqliteConnection)
        {
            if (sqliteConnection != null)
            {
                try
                {
                    SQLiteCommand sc = new SQLiteCommand(sql, sqliteConnection);
                    if (prepared != null && prepared.Count > 0)
                    {
                        foreach (DictionaryEntry de in prepared)
                        {
                            sc.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                        }
                        sc.CommandType = CommandType.Text;
                        sc.Prepare();
                    }
                    sc.ExecuteNonQuery();
                }
                catch (SQLiteException se)
                {
                    Console.WriteLine(se.Message); // Log
                    MessageBox.Show("SQL 에러 발생");
                }
            }
        }

        /// <summary>
        /// Transaction 때문에 Database Connection Commit되지 않은 Data를 확인하기 위한 API
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="prepared">Data</param>
        /// <param name="sqliteConnection">SQL Connection</param>
        /// <returns></returns>
        public DataSet SelectQuery_Transaction(string sql, Hashtable prepared, SQLiteConnection sqliteConnection)
        {
            DataSet ds = new DataSet();
            if (sqliteConnection != null)
            {
                try
                {
                    SQLiteCommand sc = new SQLiteCommand(sql, sqliteConnection);
                    if (prepared != null && prepared.Count > 0)
                    {
                        foreach (DictionaryEntry de in prepared)
                        {
                            sc.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                        }
                        sc.CommandType = CommandType.Text;
                        sc.Prepare();
                    }
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sc);
                    sda.Fill(ds);

                }
                catch (SQLiteException se)
                {
                    Console.WriteLine(se.Message); // Log
                    string errorCode = LogAndExceptionManager.GetInstance.GetErrorCode("SQLiteException");
                    string errorMessage = LogAndExceptionManager.GetInstance.GetErrorMessage("SQLiteException");
                    MessageBox.Show("ErrorCode : " + errorCode + "\n" + errorMessage);
                }
            }

            return ds;
        }
    }
}
