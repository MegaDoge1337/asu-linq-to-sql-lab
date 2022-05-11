using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace LinqToSql.SqlClient
{
    class Logger
    {
        private string _logsPath;

        public Logger(string logsPath = @"./log.txt")
        {
            this._logsPath = logsPath;
            try 
            {
                var stream = File.Create(this._logsPath);
                stream.Close();
            } 
            finally 
            {
                File.AppendAllText(this._logsPath, string.Format("[{0}] <Start> :: Logger initializate", DateTime.Now.ToString()));
            }
        }

        public void Debug(string message) 
        {
            File.AppendAllText(this._logsPath, string.Format("\n[{0}] <Debug> :: {1}", DateTime.Now.ToString(), message));
        }

        public void Error(string message) 
        {
            File.AppendAllText(this._logsPath, string.Format("\n[{0}] <Error> :: {1}", DateTime.Now.ToString(), message));
        }

        public void Info(string message) 
        {
            File.AppendAllText(this._logsPath, string.Format("\n[{0}] <Info> :: {1}", DateTime.Now.ToString(), message));
        }
    }
}
