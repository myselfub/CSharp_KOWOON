using System;
using System.Collections.Generic;
using System.Linq;

namespace Kowoon.Utils
{
    internal class LogAndExceptionManager
    {
        private static readonly Lazy<LogAndExceptionManager> _lazy = new Lazy<LogAndExceptionManager>(() => new LogAndExceptionManager());
        public static LogAndExceptionManager GetInstance => _lazy.Value;

        private readonly Dictionary<string, string> _errorCode = new Dictionary<string, string>()
        {
            {"001", "SystemException" },
            {"002","TypeUnloadedException" },
            {"003","NullReferenceException" },
            {"004","ArgumentException" },
            {"005","ArgumentOutOfRangeException" },
            {"006","SQLiteException" },
        };

        private readonly Dictionary<string, string> _errorMessage = new Dictionary<string, string>()
        {
            {"SystemException", "System 에러 발생"},
            {"TypeUnloadedException", "Type 에러 발생"},
            {"NullReferenceException", "Null 에러 발생"},
            {"ArgumentException", "인자 에러 발생"},
            {"ArgumentOutOfRangeException", "길이 에러 발생"},
            {"SQLiteException", "SQL 에러 발생"},
        };

        private LogAndExceptionManager() { }

        public string GetErrorCode(string errorCode)
        {
            return _errorCode.FirstOrDefault(x => x.Value == errorCode).Key;
        }

        public string GetErrorMessage(string errorName)
        {
            return _errorMessage.FirstOrDefault(x => x.Key == errorName).Value;
        }
    }
}
