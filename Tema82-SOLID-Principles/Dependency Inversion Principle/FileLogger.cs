using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Dependency_Inversion_Principle
{
    public class FileLogger:ILogger
    {
        public void LogMessage(string aStackTrace)
        {
            //code to log stack trace into a file.
        }
    }
}
