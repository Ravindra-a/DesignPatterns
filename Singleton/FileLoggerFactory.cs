using Singleton.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class FileLoggerFactory : IFileLoggerFactory
    {
        public IFileLogger CreateInstance()
        {
            return FileLogger.Instance;
        }
    }
}
