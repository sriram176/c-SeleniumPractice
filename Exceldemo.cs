using Microsoft.Office.Interop.Excel;
using NUnit.Framework;
namespace Sel_Basic_CSharp_Demos
{
    [TestFixture]
    public class Excel_reading_Writing_demo
    {
        Application app_excel = null;
        Workbook book_excel = null;
        Worksheet sheet_excel = null;
        [Test]
        public void TestMethod()
        {
            
            app_excel = new Application();
            string excelPath = "";
           
            book_excel = app_excel.Workbooks.Open(@"C:\Users\91996\Desktop\");
          
            sheet_excel = book_excel.Worksheets.Item[1];
       
            app_excel.Visible = true;
            
            int row_count = sheet_excel.UsedRange.Rows.Count;

            string name;
            double mark1 = 0, mark2 = 0, mark3 = 0;
            
            for (int row = 2; row <= row_count; row++)
            {
                
                name = sheet_excel.Cells[row, 2].value;
                mark1 = sheet_excel.Cells[row, 3].value;
                mark2 = sheet_excel.Cells[row, 4].value;
                mark3 = sheet_excel.Cells[row, 5].value;
                
                System.Console.WriteLine("The scores of {0} are {1}, {2} and {3}", name, mark1, mark2, mark3);
            }
            
            double totalMark = mark1 + mark2 + mark3;
            for (int row = 2; row <= row_count; row++)
            {
                
                sheet_excel.Cells[row, 6].value = totalMark;
            }
          
            book_excel.Save();
        }
        [TearDown]
        public void teardownmethod()
        {
            //Closing book and application
            book_excel.Close();
            app_excel.Quit();
        }
    }
}
