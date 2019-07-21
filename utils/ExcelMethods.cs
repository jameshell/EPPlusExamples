using System.IO;
using OfficeOpenXml;

namespace reportsInNetCore.utils
{
    public class ExcelMethods
    {
        public void userReports(){
            //Creates a blank workbook. Use the using statment, so the package is disposed when we are done.
            using (var p = new ExcelPackage())
            {
            //A workbook must have at least on cell, so lets add one... 
            var ws=p.Workbook.Worksheets.Add("Users");
            //To set values in the spreadsheet use the Cells indexer.
            ws.Cells["A1"].Value = "This is cell A1";
            //Save the new workbook. We haven't specified the filename so use the Save as method.
            p.SaveAs(new FileInfo(@"users.xlsx"));
            }
        }
    }
}