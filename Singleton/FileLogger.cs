using Singleton.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class FileLogger : IFileLogger
    {
        private readonly TextWriter _logfile;
        private const string filePath = @"E:\logfile.txt";
        FileLogger()
        {
            _logfile = GetFileStream();
        }

        public static FileLogger Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly FileLogger instance = new FileLogger();
        }
 
        
        public void WriteLineToFile(string value)
        {
            _logfile.WriteLine(value);
        }

        public void CloseFile()
        {
            _logfile.Close();
        }

        private TextWriter GetFileStream()
        {
            return TextWriter.Synchronized(File.AppendText(filePath));
        }
    }
}
