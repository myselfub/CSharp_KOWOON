using Kowoon.Logins;
using Kowoon.Mains;
using Kowoon.PanelLefts.Externals;
using Kowoon.PanelLefts.Timers;
using Kowoon.PanelLefts.Reservations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Kowoon.Utils
{
    internal class DefaultTable
    {
        private static readonly Lazy<DefaultTable> _lazy = new Lazy<DefaultTable>(() => new DefaultTable());
        public static DefaultTable GetInstance { get { return _lazy.Value; } }
        private readonly Hashtable _hashtable = new Hashtable
            {
                { "1", new UserDTO() },
                { "2", new ButtonDTO() },
                { "3", new JogamdoDTO() },
                { "4", new ExternalDTO() },
                { "5", new ExternalBtnDTO() },
                { "6", new TimerDTO() },
                { "7", new ReservationDTO() }
            };

        private DefaultTable() { }

        /// <summary>
        /// 기본 테이블 생성을 위한 API
        /// </summary>
        /// <param name="tableName">테이블명</param>
        /// <returns><DictionaryKey>ColumnName</DictionaryKey><DictionaryValue>SQL</DictionaryValue></returns>
        public Dictionary<string, string> GetDefaultTable(string tableName)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (DictionaryEntry de in _hashtable)
            {
                Type type = de.Value.GetType();
                MethodInfo methodInfo = type.GetMethod("CreateTable", BindingFlags.NonPublic | BindingFlags.Instance);
                if (methodInfo != null && methodInfo.ReturnType == typeof(void))
                {
                    methodInfo.Invoke(de.Value, null);
                }
                FieldInfo tableSearch = type.GetField("TABLE_NAME", BindingFlags.NonPublic | BindingFlags.Static);
                if (tableSearch != null && tableSearch.GetValue(de.Value).ToString() == tableName)
                {
                    FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                    foreach (FieldInfo fieldInfo in fieldInfos)
                    {
                        if (fieldInfo != null && fieldInfo.GetValue(de.Value).ToString() != tableName)
                        {
                            dict.Add(fieldInfo.Name, fieldInfo.GetValue(de.Value).ToString());
                        }
                    }
                }
            }
            return dict;
        }

        /// <summary>
        /// 기본 테이블명들을 불러오는 API
        /// </summary>
        /// <returns>DTO에 있는 TABLE_NAME</returns>
        public HashSet<string> GetDefaultTableNames()
        {
            HashSet<string> defaultTableNames = new HashSet<string>();
            foreach (DictionaryEntry de in _hashtable)
            {
                Type type = de.Value.GetType();
                FieldInfo fieldInfo = type.GetField("TABLE_NAME", BindingFlags.NonPublic | BindingFlags.Static);
                defaultTableNames.Add(fieldInfo.GetValue(de.Value).ToString());
            }

            return defaultTableNames;
        }

        /// <summary>
        /// 기본 데이터 삽입을 위한 API
        /// </summary>
        /// <param name="tableName">테이블명</param>
        /// <returns>각 DTO의 DefaultQuery 함수에 있는 Query</returns>
        public HashSet<string> GetDefaultQuery(string tableName)
        {
            HashSet<string> querys = new HashSet<string>();
            foreach (DictionaryEntry de in _hashtable)
            {
                Type type = de.Value.GetType();
                FieldInfo tableSearch = type.GetField("TABLE_NAME", BindingFlags.NonPublic | BindingFlags.Static);
                if (tableSearch != null && tableSearch.GetValue(de.Value).ToString() == tableName)
                {
                    MethodInfo methodInfo = type.GetMethod("DefaultQuery", BindingFlags.NonPublic | BindingFlags.Instance);
                    if (methodInfo != null && methodInfo.ReturnType == typeof(string[]))
                    {
                        string[] strArr = (string[])methodInfo.Invoke(de.Value, null);
                        foreach (string str in strArr)
                        {
                            querys.Add(str);
                        }
                    }
                    else if (methodInfo != null && methodInfo.ReturnType == typeof(string))
                    {
                        querys.Add((string)methodInfo.Invoke(de.Value, null));
                    }
                }
            }

            return querys;
        }

        /// <summary>
        /// 기본 데이터 삽입을 위한 API
        /// </summary>
        /// <returns>각 DTO의 DefaultQuery 함수에 있는 Query</returns>
        public HashSet<string> GetDefaultQuerys()
        {
            HashSet<string> querys = new HashSet<string>();
            foreach (DictionaryEntry de in _hashtable)
            {
                Type type = de.Value.GetType();
                MethodInfo methodInfo = type.GetMethod("DefaultQuery", BindingFlags.NonPublic | BindingFlags.Instance);
                if (methodInfo != null && methodInfo.ReturnType == typeof(string[]))
                {
                    string[] strArr = (string[])methodInfo.Invoke(de.Value, null);
                    foreach (string str in strArr)
                    {
                        querys.Add(str);
                    }
                }
                else if (methodInfo != null && methodInfo.ReturnType == typeof(string))
                {
                    querys.Add((string)methodInfo.Invoke(de.Value, null));
                }
            }

            return querys;
        }
    }
}
