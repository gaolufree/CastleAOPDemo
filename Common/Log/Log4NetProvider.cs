using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Common.Log
{
    public class Log4NetProvider : ILogProvider
    {
        private ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public Log4NetProvider()
        { }
        public Log4NetProvider(string name)
        {
            logger = LogManager.GetLogger(name);
        }

        public bool IsDebug { get;  }

        public bool IsError { get;  }

        public bool IsFatal { get;  }

        public bool IsInfo { get;  }

        public bool IsWarn { get;  }

        public void Debug(string message)
        {
            logger.DebugFormat(message);
        }

        public void Error(string message)
        {
            logger.ErrorFormat(message);
        }

        public void Fatal(string message)
        {
           logger.FatalFormat(message);
        }

        public void Info(string message)
        {
            logger.InfoFormat(message);
        }

        public void Warn(string message)
        {
           logger.WarnFormat(message);
        }
    }
}
