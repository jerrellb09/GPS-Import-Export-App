using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Principal;
using System.IO;

namespace Import_Test
{
    public static class OperationsUtility
    {

        public static string username = WindowsIdentity.GetCurrent().Name;
        public static string userName = Environment.UserName;
        public static string calDir = "C:\\Users\\" + userName + "\\Calamp History Files";
        public static string skyDir = "C:\\Users\\" + userName + "\\SkyPatrol History Files";
        public static string gldDir = "C:\\Users\\" + userName + "\\Goldstar History Files";




        public static string calampFile
        {
            get
            {
                if (userName.Contains("JSU"))
                {
                    return "C:\\Users\\jerrell.nal\\Desktop\\CalampLocateHistoryTest.csv";
                }
                else
                {
                    return userName;
                }

            }
        }

        public static string calampFileNew
        {
            get
            {
                if (userName.Contains("JSU"))
                {
                    return "C:\\Users\\jerrell.nal\\Desktop\\CalampTest2.csv";
                }
                else
                {
                    return userName;
                }

            }
        }

        public static string goldstarFile
        {
            get
            {
                if (userName.Contains("JSU"))
                {
                    return "C:\\Users\\jerrell.nal\\Desktop\\GoldstarLocateHistoryTest.csv";
                }
                else
                {
                    return userName;
                }

            }
        }

        public static string spireonFile
        {
            get
            {
                if (userName.Contains("JSU"))
                {
                    return "C:\\Users\\jerrell.nal\\Desktop\\SpireonLocateHistoryTest.csv";
                }
                else
                {
                    return userName;
                }

            }
        }

        public static string skypatrolFile
        {
            get
            {
                if (userName.Contains("JSU"))
                {

                    return "C:\\Users\\jerrell.nal\\Desktop\\SkyPatrolLocateHistoryTest.xlsx";

                }
                else
                {
                    return userName;
                }

            }
        }

        //public static DataTable gldTable; //Goldstar Table
        //public static DataTable calTable; //Calamp Table
        //public static DataTable skyTable; //SkyPatrol Table


        public static DataTable CreateGoldStarDataTable(this DataTable gldTable)
        {
            //columns  
            gldTable.SetColumnsOrder("Date Time", "Serial", "Display Name", "New Location", "Address", "Event", "Speed", "Latitude", "Longitude");

            //data
            return gldTable;
        }



        public static DataTable CreateCalampDataTable(this DataTable calTable)
        {
            //columns  
            calTable.Columns.Add("Group ID", typeof(string));
            calTable.Columns.Add("equipment_id", typeof(string));
            calTable.Columns.Add("BornOn", typeof(string));
            calTable.Columns.Add("Event Code", typeof(string));
            calTable.Columns.Remove("GPS Timestamp");
            calTable.Columns.Remove("Device Logged Timestamp");
            calTable.Columns.Remove("Command");
            calTable.Columns.Remove("Rssi");
            calTable.Columns.Remove("Satellites");
            //calTable.Columns[7].DataType = typeof(string);
            //calTable.Columns[8].DataType = typeof(string);


            calTable.SetColumnsOrder("Group ID", "Account Name", "Air ID", "ESN", "equipment_id", "BornOn", "Vehicle Name", "Latitude", "Longitude", "Speed", "Received Timestamp", "Event Code", "Alert Type", "Geo Address");

            //data 
            return calTable;
        }

        public static DataTable CreateSkyPatrolTable(this DataTable skyTable)
        {
            //columns
            //skyTable.Columns.Add("Driver", typeof(string));
            //skyTable.Columns.Remove("Serial Number");
            //skyTable.Columns.Remove("Sub-Account");
            //skyTable.Columns.Remove("Report Time");
            //skyTable.Columns.Remove("Driver");
            //skyTable.Columns.Remove("Status");
            //skyTable.Columns.Remove("Lat");
            //skyTable.Columns.Remove("Long");
            //skyTable.Columns.Remove("Stop Time");
            //skyTable.Columns.Remove("Valid GPS");
            //skyTable.Columns.Add("SerialNumber");
            //skyTable.Columns.Add("Serial", typeof(string));
            skyTable.Columns["Unit"].DefaultValue = "NOTHING";
            skyTable.Columns.Add("Sub-Account").DefaultValue = "";
            //skyTable.Columns.Add("Report Time");
            skyTable.Columns.Add("Time Zone").DefaultValue = ""; ;
            skyTable.Columns["Status"].ColumnName = "Report Type";
            //skyTable.Columns.Add("Speed");
            skyTable.Columns.Add("Driver");
            //skyTable.Columns.Add("Heading");
            skyTable.Columns["Lat"].ColumnName = "Latitude";
            skyTable.Columns["Long"].ColumnName = "Longitude";
            skyTable.Columns.Add("Stop Time").DefaultValue = ""; ;
            skyTable.Columns["Validgps"].ColumnName = "Valid GPS";

            //DataRow dr = skyTable.NewRow();

            skyTable.SetColumnsOrder("Unit", "Serial Number", "Sub-Account", "Report Time", "Time Zone", "Report Type", "Speed", "Driver", "Heading", "Latitude", "Longitude", "Location", "Stop Time", "Valid GPS");

            //data 
            return skyTable;
        }

        //public static void SetDBValueToNull(DataTable skyTable)
        //{
        //    foreach ( DataRow row in skyTable.Rows)
        //    {
        //        foreach (DataColumn col in skyTable.Columns)
        //        {
        //            if (!string.IsNullOrWhiteSpace(skyTable.Columns[Convert.ToString(col)]
        //            {
        //                row["SubAccount"] = string.IsNullOrWhiteSpace("") ? DBNull.Value : (object)Convert.ToInt32("");
        //            }
        //                //row[col] = data[col];
        //            else
        //                row[col] = DBNull.Value;
        //        }
        //    }


        //}

    }
}
