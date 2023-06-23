using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Dependency_Inversion_Principle
{
    //public class DataExporter
    //{
    //    public void ExportDataFromFile()
    //    {
    //        try
    //        {
    //            //code to export data from files to the database.
    //        }
    //        catch (Exception ex)
    //        {
    //            new ExceptionLogger().LogIntoFile(ex);
    //        }
    //    }
    //}

    //public class DataExporter
    //{
    //    public void ExportDataFromFile()
    //    {
    //        try
    //        {
    //            //code to export data from files to database.
    //        }
    //        catch (IOException ex)
    //        {
    //            new ExceptionLogger().LogIntoDataBase(ex);
    //        }
    //        catch (Exception ex)
    //        {
    //            new ExceptionLogger().LogIntoFile(ex);
    //        }
    //    }
    //}

    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            ExceptionLogger _exceptionLogger;
            try
            {
                //code to export data from files to database.
            }
            catch (IOException ex)
            {
                _exceptionLogger = new ExceptionLogger(new DbLogger());
                _exceptionLogger.LogException(ex);
            }
            //catch (SqlException ex)
            //{
            //    _exceptionLogger = new ExceptionLogger(new EventLogger());
            //    _exceptionLogger.LogException(ex);
            //}
            catch (Exception ex)
            {
                _exceptionLogger = new ExceptionLogger(new FileLogger());
                _exceptionLogger.LogException(ex);
            }
        }
    }
}
