using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Principal;
using System.Security.Authentication;
using System.Security.AccessControl;
//using Microsoft.VisualBasic.FileIO;
namespace FileSorterLibrary
{
    public class Logger:IDisposable
    {
        System.IO.StreamWriter stream;
        string logfile { get; set; }
        public Logger(string logfile)
        {
            this.logfile = logfile;
            stream = new StreamWriter(logfile, true);
        }

        public Logger()
        {

        }
        public void OpenLog()
        {
            if (string.IsNullOrEmpty(this.logfile))
                this.logfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+Guid.NewGuid().ToString()+".log";
            if (stream == null)
                stream = new StreamWriter(logfile, true);
        }

        public void CloseLog()
        {
            if (stream != null)
                stream.Close();
        }

        public void WriteLog(string msg)
        {
            OpenLog();
            stream.WriteLine(msg);
            CloseLog();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        public void Dispose(bool disflag)
        { 
            if(stream!=null)
            {
                stream.Flush();
                stream.Close();                
            }

        }
    }
}
