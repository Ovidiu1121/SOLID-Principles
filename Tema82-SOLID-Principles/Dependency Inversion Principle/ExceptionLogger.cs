using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Dependency_Inversion_Principle
{
    //public class ExceptionLogger
    //{
    //    public void LogIntoFile(Exception aException)
    //    {
    //        FileLogger objFileLogger = new FileLogger();
    //        objFileLogger.LogMessage(GetUserReadableMessage(aException));
    //    }
    //    private GetUserReadableMessage(Exception ex)
    //    {
    //        string strMessage = string.Empty;
    //        //code to convert Exception's stack trace and message to user readable format.

    //       return strMessage;
    //    }
    //}

    //public class ExceptionLogger
    //{
    //    public void LogIntoFile(Exception aException)
    //    {
    //        FileLogger objFileLogger = new FileLogger();
    //        objFileLogger.LogMessage(GetUserReadableMessage(aException));
    //    }
    //    public void LogIntoDataBase(Exception aException)
    //    {
    //        DbLogger objDbLogger = new DbLogger();
    //        objDbLogger.LogMessage(GetUserReadableMessage(aException));
    //    }
    //    private string GetUserReadableMessage(Exception ex)
    //    {
    //        string strMessage = string.Empty;
    //        //code to convert Exception's stack trace and message to user readable format.

    //       return strMessage;
    //    }
    //}

    public class ExceptionLogger
    {
        private ILogger _logger;
        public ExceptionLogger(ILogger aLogger)
        {
            this._logger = aLogger;
        }
        public void LogException(Exception aException)
        {
            string strMessage = GetUserReadableMessage(aException);
            this._logger.LogMessage(strMessage);
        }
        private string GetUserReadableMessage(Exception aException)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user readable format.
           
           return strMessage;
        }
    }

}
