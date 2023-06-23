using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Liskov_Substitution_Principle
{
    //public class SqlFileManager
    //{
    //    public List<SqlFile> lstSqlFiles { get; set; }

    //    public string GetTextFromFiles()
    //    {
    //        StringBuilder objStrBuilder = new StringBuilder();
    //        foreach (var objFile in lstSqlFiles)
    //        {
    //            objStrBuilder.Append(objFile.LoadText());
    //        }
    //        return objStrBuilder.ToString();
    //    }
    //    public void SaveTextIntoFiles()
    //    {
    //        foreach (var objFile in lstSqlFiles)
    //        {
    //            objFile.SaveText();
    //        }
    //    }
    //}

    //public class SqlFileManager
    //{
    //    public List<SqlFile> lstSqlFiles { get; set; }

    //    public string GetTextFromFiles()
    //    {
    //        StringBuilder objStrBuilder = new StringBuilder();
    //        foreach (var objFile in lstSqlFiles)
    //        {
    //            objStrBuilder.Append(objFile.LoadText());
    //        }
    //        return objStrBuilder.ToString();
    //    }
    //    public void SaveTextIntoFiles()
    //    {
    //        foreach (var objFile in lstSqlFiles)
    //        {
    //            //Check whether the current file object is read-only or not.If yes, skip calling it's
    //            // SaveText() method to skip the exception.

    //            if (objFile is ReadOnlySqlFile)
    //                objFile.SaveText();
    //        }
    //    }
    //}

    public class SqlFileManager
    {
        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in aLstReadableFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
        {
            foreach (var objFile in aLstWritableFiles)
            {
                objFile.SaveText();
            }
        }
    }

}
