using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Log
{
    public interface ILogProvider
    {
        bool IsDebug { get; }
        bool IsError { get; }
        bool IsFatal { get; }
        bool IsInfo { get; }
        bool IsWarn { get; }

        void Debug(string message);
        void Error(string message);
        void Fatal(string message);
        void Info(string message);
        void Warn(string message);

    }
}
