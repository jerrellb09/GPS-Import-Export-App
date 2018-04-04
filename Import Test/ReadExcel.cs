using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Excel;
using System.Data;
using System.IO;

namespace Import_Test
{
    class ReadExcel
    {
        //static void Main(string[] args)
        //{
        //    //Reading from a binary Excel file ('97-2003 format; *.xls)
        //    //IExcelDataReader excelReader2003 = ExcelReaderFactory.CreateBinaryReader(stream);

        //    //Reading from a OpenXml Excel file (2007 format; *.xlsx)
        //    FileStream stream = new FileStream("../../myxlsx/sample.xlsx", FileMode.Open);
        //    IExcelDataReader excelReader2007 = ExcelReaderFactory.CreateOpenXmlReader(stream);

        //    //DataSet - The result of each spreadsheet will be created in the result.Tables
        //    DataSet result = excelReader2007.AsDataSet();

        //    //Data Reader methods
        //    foreach (DataTable table in result.Tables)
        //    {
        //        for (int i = 0; i < table.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < table.Columns.Count; j++)
        //                Console.Write("\"" + table.Rows[i].ItemArray[j] + "\";");
        //            Console.WriteLine();
        //        }
        //    }

        //    //Free resources (IExcelDataReader is IDisposable)
        //    //excelReader2003.Close();
        //    excelReader2007.Close();
        //    Console.Read();
        //}

        //private void ReadExcelFile()
        //{
        //    var filePath = "";
        //    FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

        //    //1. Reading from a binary Excel file ('97-2003 format; *.xls)
        //    //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
        //    //...
        //    //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
        //    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        //    //...
        //    //3. DataSet - The result of each spreadsheet will be created in the result.Tables
        //    DataSet result = excelReader.AsDataSet();
        //    //...
        //    //4. DataSet - Create column names from first row
        //    excelReader.IsFirstRowAsColumnNames = true;
        //    DataSet result = excelReader.AsDataSet();

        //    //5. Data Reader methods
        //    while (excelReader.Read())
        //    {
        //        //excelReader.GetInt32(0);
        //    }

        //    //6. Free resources (IExcelDataReader is IDisposable)
        //    excelReader.Close();
        //}
    }
}
