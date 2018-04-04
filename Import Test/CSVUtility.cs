using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;


namespace Import_Test
{

    public static class CSVUtility
    {
        /// <summary>
        /// Sends the datatable to a CSV file on your desktop
        /// </summary>
        /// <param name="dTable">Datable containing the CSV information</param>
        /// <param name="strFilePath">Destination where the CSV will be created</param>
        /// 

        public static string currentUserDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static void ExportToCSV(this System.Data.DataTable dTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);

            for (int i = 0; i < dTable.Columns.Count; i++)
            {
                sw.Write(dTable.Columns[i]);
                if (i < dTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }

                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                    if (Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(""))
                        {
                            sw.Write(value);
                        }
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public static void ExportCalToCSV(this System.Data.DataTable dTable, string strFilePath)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dTable.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dTable.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field =>
                  string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }

            //File.WriteAllText("C:\\Users\\jerrell.nal\\Desktop\\CalampLocateHistory.csv", sb.ToString());
            File.WriteAllText(currentUserDesktop + "\\CalampLocateHistory.csv", sb.ToString());



            //StreamWriter sw = new StreamWriter(strFilePath, false);

            //for (int i = 0; i < dTable.Columns.Count; i++)
            //{
            //    sw.Write(dTable.Columns[i]);
            //    if (i < dTable.Columns.Count - 1)
            //    {
            //        sw.Write(",");
            //    }
            //}
            //sw.Write(sw.NewLine);
            //foreach (DataRow dr in dTable.Rows)
            //{
            //    for (int i = 0; i < dTable.Columns.Count; i++)
            //    {
            //        if (!Convert.IsDBNull(dr[i]))
            //        {
            //            string value = dr[i].ToString();
            //            if (value.Contains(','))
            //            {
            //                value = String.Format("\"{0}\"", value);
            //                sw.Write(value);
            //            }
            //            else
            //            {
            //                sw.Write(dr[i].ToString());
            //            }
            //        }
            //        if (i < dTable.Columns.Count - 1)
            //        {
            //            sw.Write(",");
            //        }
            //        if (Convert.IsDBNull(dr[i]))
            //        {
            //            string value = dr[i].ToString();
            //            if (value.Contains(""))
            //            {
            //                sw.Write(value);
            //            }
            //        }
            //    }
            //    sw.Write(sw.NewLine);
            //}
            //sw.Close();
        }

        public static void ExportSkyToCSV(this System.Data.DataTable dTable, string strFilePath)
        {

            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dTable.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dTable.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field =>
                  string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText("C:\\Users\\jerrell.nal\\Desktop\\SkyPatrolLocateHistory.csv", sb.ToString());
            //File.WriteAllText("C:\\Users\\jerrell.nal\\Desktop\\Test-excel.xlsx", sb.ToString());
        }

        public static void CleanGoldStarFile(this System.Data.DataTable dTable)
        {
            foreach (DataRow dr in dTable.Rows)
            {
                foreach (DataColumn col in dTable.Columns)
                {
                    if (col.ColumnName == "Display Name")
                    {
                        dr[col] = dr[col].ToString().Replace("-1", "");
                        dr[col] = dr[col].ToString().Replace("-2", "");
                        dr[col] = dr[col].ToString().Replace("-3", "");
                        dr[col] = dr[col].ToString().Replace("- 1", "");
                        dr[col] = dr[col].ToString().Replace("- 2", "");
                        dr[col] = dr[col].ToString().Replace("- 3", "");
                        dr[col] = dr[col].ToString().Replace("-01", "");
                        dr[col] = dr[col].ToString().Replace("-02", "");
                        dr[col] = dr[col].ToString().Replace("-03", "");
                        dr[col] = dr[col].ToString().Replace("_1", "");
                        dr[col] = dr[col].ToString().Replace("_2", "");
                        dr[col] = dr[col].ToString().Replace("_3", "");
                    }
                    if (col.ColumnName == "Speed")
                    {
                        dr[col] = dr[col].ToString().Replace("mph", "");
                    }
                }

            }

        }

        public static void CleanCalampFile(this System.Data.DataTable dTable)
        {

            foreach (DataRow dr in dTable.Rows)
            {
                foreach (DataColumn col in dTable.Columns)
                {
                    if (col.ColumnName == "Vehicle Name")
                    {
                        dr[col] = dr[col].ToString().Replace("-1", "");
                        dr[col] = dr[col].ToString().Replace("-2", "");
                        dr[col] = dr[col].ToString().Replace("-3", "");
                        dr[col] = dr[col].ToString().Replace("- 1", "");
                        dr[col] = dr[col].ToString().Replace("- 2", "");
                        dr[col] = dr[col].ToString().Replace("- 3", "");
                        dr[col] = dr[col].ToString().Replace("-01", "");
                        dr[col] = dr[col].ToString().Replace("-02", "");
                        dr[col] = dr[col].ToString().Replace("-03", "");
                        dr[col] = dr[col].ToString().Replace("_1", "");
                        dr[col] = dr[col].ToString().Replace("_2", "");
                        dr[col] = dr[col].ToString().Replace("_3", "");
                    }
                    if (col.ColumnName == "Speed")
                    {
                        dr[col] = dr[col].ToString().Replace("mph", "");
                    }
                    //if (col.ColumnName == "Geo Address")
                    //{
                    //    dr[col] = dr[col].ToString().Replace(" ", ",");
                    //}

                    //if (col.ColumnName == "Group ID")
                    //{
                    //    dr[col] = dr[col].ToString().Replace("", " ");
                    //}
                    //if (col.ColumnName == "BornOn")
                    //{
                    //    dr[col] = dr[col].ToString().Replace("", " ");
                    //}
                    //if (col.ColumnName == "equipment_id")
                    //{
                    //    dr[col] = dr[col].ToString().Replace(""," ");
                    //}
                }

            }
            //DataTable dtCloned = dTable.Clone();
            //dtCloned.Columns[7].DataType = typeof(string);
            //dtCloned.Columns[8].DataType = typeof(string);
            //foreach (DataRow row in dTable.Rows)
            //{
            //    dtCloned.ImportRow(row);
            //}
        }

        public static void CleanSkyPatrolFile(this System.Data.DataTable dTable)
        {
            foreach (DataRow dr in dTable.Rows)
            {
                foreach (DataColumn col in dTable.Columns)
                {
                    dr[col] = dr[col].ToString().Replace("=", "");
                    dr[col] = dr[col].ToString().Replace("\"", "");


                    if (col.ColumnName == "Unit")
                    {
                        dr[col] = dr[col].ToString().Replace("-1", "");
                        dr[col] = dr[col].ToString().Replace("-2", "");
                        dr[col] = dr[col].ToString().Replace("-3", "");
                        dr[col] = dr[col].ToString().Replace("- 1", "");
                        dr[col] = dr[col].ToString().Replace("- 2", "");
                        dr[col] = dr[col].ToString().Replace("- 3", "");
                        dr[col] = dr[col].ToString().Replace("-01", "");
                        dr[col] = dr[col].ToString().Replace("-02", "");
                        dr[col] = dr[col].ToString().Replace("-03", "");
                        dr[col] = dr[col].ToString().Replace("_1", "");
                        dr[col] = dr[col].ToString().Replace("_2", "");
                        dr[col] = dr[col].ToString().Replace("_3", "");
                    }

                    if (col.ColumnName == "Serial Number" || col.ColumnName == "Unit")
                    {
                        dr[col] = Convert.ToString(dr[col].ToString().Replace("636155", "\'636155"));

                        //dr[col] = ((int)dr[col]);

                    }

                    if (col.ColumnName == "Valid GPS")
                    {
                        dr[col] = dr[col].ToString().Replace("True", "Yes");
                        dr[col] = dr[col].ToString().Replace("False", "No");

                    }



                    dr[col] = dr[col].ToString().Replace("\'", "");


                }
            }
        }

        //public static void ConvertToExcel()
        //{
        //    Application app = new Application();
        //    Workbook wb = app.Workbooks.Open("C:\\Users\\jerrell.nal\\Desktop\\SkyPatrolLocateHistory.csv", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    wb.SaveAs(@"C:\testcsv.xlsx", XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    wb.Close();
        //    app.Quit();
        //}

        public static void ConvertSkyPatrolToExcel(this System.Data.DataTable dTable)
        {
            XLWorkbook wb = new XLWorkbook();

            wb.Worksheets.Add(dTable, "Sheet1");
            // wb.SaveAs("C:\\Users\\jerrell.nal\\Desktop\\SkyPatrolLocateHistoryClosedXML.xlsx");
            wb.SaveAs(currentUserDesktop + "\\SkypatrolLocateHistoryClosedXML.xlsx");

        }

    }
}
