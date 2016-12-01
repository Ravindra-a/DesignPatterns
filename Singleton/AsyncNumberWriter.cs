using Singleton.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class AsyncNumberWriter : INumberWriter
    {
        private readonly IFileLoggerFactory _fileLoggerFactory;

        public AsyncNumberWriter(IFileLoggerFactory fileLoggerFactory)
        {
            _fileLoggerFactory = fileLoggerFactory;
        }
        public void WriteNumbersToFile(int max)
        {
            IFileLogger myLogger = null;
            Action<int> logToFile = i =>
            {
                myLogger = _fileLoggerFactory.CreateInstance();
                myLogger.WriteLineToFile("Ready for next number...");
                myLogger.WriteLineToFile("Logged number: " + i);
            };
            Parallel.For(0, max, logToFile);
            myLogger.CloseFile();
        }
    }
}
