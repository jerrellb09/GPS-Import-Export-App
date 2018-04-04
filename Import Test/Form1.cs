using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
//using GenericParsing;
using Com.StellmanGreene.CSVReader;
using System.Dynamic;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using System.Data.Odbc;



namespace Import_Test
{


    public partial class Form1 : Form
    {
        private DataGridView dataGridView = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        public DataTable dt;
        public DataTable gldTable; //Goldstar Table
        public DataTable calTable; //Calamp Table
        public DataTable skyTable; //SkyPatrol Table       
        public DataTable gldTableNew; //Goldstar Table for the new reports
        public DateTime? endDate;
        public DateTime? startDate;
        private DateTime minimumDate;
        public DateTime maximumDate;
        private DataTable res;

        public Form1()
        {
            InitializeComponent();
        }

        //Button to show the Goldstar history table
        private void btnShowGLDTbl_Click(object sender, EventArgs e)
        {
            //MyConn = new OleDbConnection(connString);
            //MyConn.ConnectionString = connString;
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=S:\\Jerrell Test Database.accdb";
            string strSql = "Select * from Test_Goldstar_History";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            //cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Test_Goldstar_History");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Test_Goldstar_History";
        }

        //Button to locate the Goldstar Locate History CSV
        private void btnGldLocateHist_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            GetGoldstarLocateHist();
            MakeControlsInvisible();
        }

        private void GetGoldstarLocateHist()
        {
            var csv = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files (*.csv) | *.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                csv = fileName;
            }
            gldTable = CSVReader.ReadCSVFile(csv, true);
            dataGridView3.DataSource = gldTable.DefaultView;
            dataGridView3.AutoGenerateColumns = true;
            dt = gldTable;
        }

        private void btnNewGoldstar_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            GetNewGoldstarLocateHist();
            MakeControlsInvisible();
        }


        private void GetNewGoldstarLocateHist()
        {
            var xlsx = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files (*.csv) | *.csv|Excel Worksheets|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                xlsx = fileName;
            }

            // the file to parse
            String path = xlsx; //@"C:\exampleCsv.csv";

            // a data table we'll use to hold the parsed data
            DataTable glddt = new DataTable();
            gldTable = glddt;
            dt = gldTable;

            // check the file exists
            if (File.Exists(path))
            {
                // create the parser
                using (TextFieldParser parser = new TextFieldParser(path))
                {
                    // set the parser variables
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    bool firstline = true;

                    while (!parser.EndOfData)
                    {
                        //processing row
                        string[] fields = parser.ReadFields();

                        // get the column headers
                        if (firstline)
                        {
                            foreach (var val in fields)
                            {
                                glddt.Columns.Add(val);
                            }

                            firstline = false;

                            continue;
                        }

                        // get the row data
                        glddt.Rows.Add(fields);
                    }
                }
            }
            //gldTableNew = CSVReader.ReadCSVFile(csv, true);
            dataGridView3.DataSource = gldTable.DefaultView;
            dataGridView3.AutoGenerateColumns = true;
            dt = gldTable;
        }

        private void MakeControlsVisible()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            btnFilterDate.Visible = true;
            btnClearFilter.Visible = true;
        }

        private void MakeControlsInvisible()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            btnFilterDate.Visible = false;
            btnClearFilter.Visible = false;
        }

        //Button to locate the Calamp Locate History CSV
        private void btnCalampLocateHist_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            GetCalampLocateHist();
            GetCalampDateRange();
            MakeControlsVisible();

        }

        public void GetCalampDateRange()
        {
            //DateTime startDate = DateTime.MinValue;
            //DateTime endDate = DateTime.MaxValue;

            //DateTime minimumDate = calTable.Rows.OfType<DataRow>().Select(k => Convert.ToDateTime(k["Received Timestamp"])).OrderBy(k => k).Min();
            //DateTime maximumDate = calTable.Rows.OfType<DataRow>().Select(k => Convert.ToDateTime(k["Received Timestamp"])).OrderBy(k => k).Max();

            DateTime minimumDate = Convert.ToDateTime((dt.Compute("min([Received Timestamp])", string.Empty)));

            //DateTime minDate = Convert.ToDateTime((dt.Compute("WITH ranked AS (select Time,Nickname,rownum = ROW_NUMBER() OVER(Partition by dateAdd(day, Datediff(day, 0, Time), 0) order by Time) from CalampHistory) select Time,Nickname from ranked where rownum = 1", string.Empty)));

            DateTime maximumDate = Convert.ToDateTime((dt.Compute("max([Received Timestamp])", string.Empty)));



            dateTimePicker1.MinDate = minimumDate;
            dateTimePicker1.MaxDate = maximumDate;
            dateTimePicker2.MinDate = minimumDate;
            dateTimePicker2.MaxDate = maximumDate;


            MessageBox.Show("The beginning date is " + minimumDate + " and the end date is " + maximumDate);




            //MessageBox.Show("Location for Calamp start on" + begin.ToString() + "and ends on" + end.ToString());
        }

        public void GetCalampLocateHist()
        {
            try
            {
                var csv = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "CSV Files (*.csv) | *.csv";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = dlg.FileName;
                    csv = fileName;
                }
                calTable = CSVReader.ReadCSVFile(csv, true);
                dataGridView3.DataSource = calTable.DefaultView;
                dataGridView3.AutoGenerateColumns = true;
                dt = calTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSkyPatrolLocateHist_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            GetSkyPatrolLocateHist();
            MakeControlsInvisible();

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            //dataGridView3.Columns.Clear();
            //dt = calTable;
            dt = res;
            res = calTable;
            dataGridView3.DataSource = res;

        }

        private void GetSkyPatrolLocateHist()
        {
            var csv = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files (*.csv) |*.csv| Text Files (*.txt) |*.txt";
            //fbd.SelectedPath = "\\\\files\\Production\\GpsStore\\SkyPatrol\\SkyPatrol history downloads";
            //fbd.SelectedPath = "C:\\Users\\jerrell.nal\\Desktop";
            //dlg.ShowDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //string foldername;
            //foldername = fbd.SelectedPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                csv = fileName;
            }

            //skyTable = CSVReader.ReadCSVFile(csv, true);
            //CsvReader sky = new CsvReader(csv, true, '=');

            // the file to parse
            String path = csv; //@"C:\exampleCsv.csv";

            // a data table we'll use to hold the parsed data
            DataTable skydt = new DataTable();
            skyTable = skydt;
            dt = skyTable;

            // check the file exists
            if (File.Exists(path))
            {
                // create the parser
                using (TextFieldParser parser = new TextFieldParser(path))
                {
                    // set the parser variables
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    bool firstline = true;

                    while (!parser.EndOfData)
                    {
                        //processing row
                        string[] fields = parser.ReadFields();

                        // get the column headers
                        if (firstline)
                        {
                            foreach (var val in fields)
                            {
                                skydt.Columns.Add(val);
                            }

                            firstline = false;

                            continue;
                        }

                        // get the row data
                        skydt.Rows.Add(fields);
                    }
                }

                dataGridView3.DataSource = skydt;

                //}
                //dataGridView3.DataSource = skyTable.DefaultView;
                ////dataGridView3.Databind();
                //dataGridView3.AutoGenerateColumns = true;
                //dt = skyTable;            
            }
        }

        private string GetFileName()
        {
            var csv = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "CSV Files (*.csv) |*.csv| Text Files (*.txt) |*.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                csv = fileName;
            }

            return csv;
        }

        private void CreateDataTable(string csv)
        {
            DataTable dt = new DataTable();
        }



        //private void ReadExcel(string filePath)
        //{
        //    DataTable table = new DataTable();
        //    string strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;TypeGuessRows=0;ImportMixedTypes=Text\"", filePath);
        //    using (OleDbConnection dbConnection = new OleDbConnection(strConn))
        //    {
        //        using (OleDbDataAdapter dbAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", dbConnection)) //rename sheet if required!
        //            dbAdapter.Fill(table);
        //        dataGridView3.DataSource = table;
        //    }
        //}

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
        }

        public void WriteToSkyPatrolTable(DataTable dt)
        {
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=S:\\Jerrell Test Database.accdb";
            OleDbConnection con = new OleDbConnection(strProvider);

            con.Open();

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                string strSql = "INSERT INTO SkypatrolHistory(Unit, [Serial Number], [Report Time], [Report Type], Speed,Heading, Latitude, Longitude, Location,[Valid GPS]) VALUES(Unit, @SSN,@ReportTime, @ReportType, @Speed, @Heading, @Latitude, @Longitude, @Location, @ValidGPS)";


                var unit = dataGridView3.Rows[i].Cells["unit"].Value;

                OleDbCommand cmd = new OleDbCommand(strSql, con);

                cmd.Parameters.AddWithValue("Unit", unit ?? DBNull.Value); //dataGridView3.Rows[i].Cells["Unit"].Value
                cmd.Parameters.AddWithValue("@SSN", dataGridView3.Rows[i].Cells["Serial Number"].Value ?? DBNull.Value);
                //cmd.Parameters.AddWithValue("@Sub-Account", dataGridView3.Rows[i].Cells["Sub-Account"].Value);
                cmd.Parameters.AddWithValue("@ReportTime", dataGridView3.Rows[i].Cells["Report Time"].Value ?? DBNull.Value);
                //cmd.Parameters.AddWithValue("@TimeZone", dataGridView3.Rows[i].Cells["Time Zone"].Value);
                cmd.Parameters.AddWithValue("@ReportType", dataGridView3.Rows[i].Cells["Report Type"].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Speed", dataGridView3.Rows[i].Cells["Speed"].Value ?? DBNull.Value);
                //cmd.Parameters.AddWithValue("@Driver", dataGridView3.Rows[i].Cells["Driver"].Value);
                cmd.Parameters.AddWithValue("@Heading", dataGridView3.Rows[i].Cells["Heading"].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Latitude", dataGridView3.Rows[i].Cells["Latitude"].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Longitude", dataGridView3.Rows[i].Cells["Longitude"].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Location", dataGridView3.Rows[i].Cells["Location"].Value ?? DBNull.Value);
                //cmd.Parameters.AddWithValue("@StopTime", dataGridView3.Rows[i].Cells["Stop Time"].Value);
                cmd.Parameters.AddWithValue("@ValidGPS", dataGridView3.Rows[i].Cells["Valid GPS"].Value ?? DBNull.Value);
                cmd.ExecuteNonQuery();

            }

            con.Close();

        }

        //Button to Export the information in the Datagrid to a CSV
        //and saving it to your desktop
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dt.IsInitialized)
            {
                if (dt.Equals(gldTable))

                {
                    string filename = OperationsUtility.goldstarFile;
                    OperationsUtility.CreateGoldStarDataTable(gldTable);
                    gldTable.CleanGoldStarFile();
                    gldTable.ExportToCSV(filename);
                }
                else if (dt.Equals(skyTable))
                {
                    string filename = OperationsUtility.skypatrolFile;
                    OperationsUtility.CreateSkyPatrolTable(skyTable);
                    skyTable.CleanSkyPatrolFile();
                    //skyTable.ExportSkyToCSV(filename);
                    CSVUtility.ConvertSkyPatrolToExcel(skyTable);
                }
                else if (dt.Equals(gldTableNew))
                {
                    string filename = OperationsUtility.spireonFile;
                    OperationsUtility.CreateGoldStarDataTable(gldTableNew);
                    gldTableNew.CleanGoldStarFile();
                    gldTableNew.ExportToCSV(filename);
                }
                else if (dt.Equals(calTable) || res.Equals(calTable))
                {
                    string filename = OperationsUtility.calampFileNew;
                    OperationsUtility.CreateCalampDataTable(calTable);
                    calTable.CleanCalampFile();
                    calTable.ExportCalToCSV(filename);
                    var message = "Calamp History has been exported to" + "@" + filename;
                    MessageBox.Show(message);
                }
                else
                {
                    var message = "There is nothing to show";
                    MessageBox.Show(message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\\Users\\Jerrell.nal\\Desktop\\GoldstarLocateHistoryTest.csv");
        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime[] times = calTable.Rows.Cast<DataRow>().Select(r => Convert.ToDateTime(r.ItemArray[0])).ToArray();

            var minTimes = from n in times
                           group n by n.Date into g
                           select g.OrderByDescending(t => t.Date).Min();

            var start = from u in times
                        where u.Date == dateTimePicker1.Value.Date
                        group u by u.Date into l
                        select l.OrderBy(k => k.Date).Min();


            dateTimePicker1.Value = start.First();
            textBox1.Text = dateTimePicker1.Value.ToString();
        }

        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime[] times = calTable.Rows.Cast<DataRow>().Select(r => Convert.ToDateTime(r.ItemArray[0])).ToArray();

            var minTimes = from n in times
                           group n by n.Date into g
                           select g.OrderByDescending(t => t.Date).Max();

            var end = from u in times
                      where u.Date == dateTimePicker2.Value.Date
                      group u by u.Date into l
                      select l.OrderBy(k => k.Date).Max();

            dateTimePicker2.Value = end.First();
            textBox2.Text = dateTimePicker2.Value.ToString();
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            DateTime[] times = calTable.Rows.Cast<DataRow>().Select(r => Convert.ToDateTime(r.ItemArray[0])).ToArray();

            //queries the minimum time for each day in the times array
            var start = from u in times
                        where u.Date == dateTimePicker1.Value.Date
                        group u by u.Date into l
                        select l.OrderBy(k => k.Date).Min();

            //queries the maximum time for each day in the times array
            var end = from u in times
                      where u.Date == dateTimePicker2.Value.Date
                      group u by u.Date into l
                      select l.OrderBy(k => k.Date).Max();

            //This linq query creates a date range filter that is chosen by setting a start and end date
            //the result gets stored in a temp table
            res = calTable.Select().Where(p => (Convert.ToDateTime(p["Received Timestamp"]) >= Convert.ToDateTime(start.First()) && Convert.ToDateTime(p["Received Timestamp"]) <= Convert.ToDateTime(end.First()))).CopyToDataTable();

            var minTimes = from n in times
                           group n by n.Date into g
                           select g.OrderByDescending(t => t.Date).Min();

            var maxTimes = from n in times
                           group n by n.Date into g
                           select g.OrderByDescending(t => t.Date).Max();

            //The filtered table then becomes Caltable
            calTable = res;

            //calTable.AsDataView().RowFilter = 

            dataGridView3.DataSource = calTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteToSkyPatrolTable(skyTable);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MyConn = new OleDbConnection(connString);
            //MyConn.ConnectionString = connString;
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=S:\\Jerrell Test Database.accdb";
            string strSql = "Select * from SkypatrolHistory";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            //cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Skypatrolhistory");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Skypatrolhistory";
        }
    }
}

