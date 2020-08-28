using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LoadCatalogService
{
    public partial class BookCatalog : ServiceBase
    {
        //InstallUtil.exe LoadCatalogService.exe
        //InstallUtil.exe -u LoadCatalogService.exe

        //Initialize the timer
        Timer timer = new Timer();

        public BookCatalog()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteMessageToLogFile("Service started at:" + DateTime.Now.ToString());
            timer.Elapsed += timer_Elapsed;
            timer.Interval = 10000; // Every 10 seconds the Elapsed event is invoked
            timer.Enabled = true;
            timer.Start();

        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                WriteMessageToLogFile("timer_Elapsed at:" + DateTime.Now.ToString());

                //Monitor if catalog excel file is present in the folder
                //If False Do nothing
                string sourcefileName = "BookCatalog.xlsx";

                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now.Day);
                sb.Append("_");
                sb.Append(DateTime.Now.Month);
                sb.Append("_");
                sb.Append(DateTime.Now.Year);
                sb.Append("_");
                sb.Append(DateTime.Now.TimeOfDay.ToString().Replace(":", "_").Replace(".", "_"));

                string destinationfileName = "BookCatalog_"+ sb.ToString()+".xlsx";
                string sourcePath = @"C:\DAC_DotNet_Dec2019\Labs\inputcatalog";
                string targetPath = @"C:\DAC_DotNet_Dec2019\Labs\archivecatalog";

                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, sourcefileName);
                string destFile = System.IO.Path.Combine(targetPath, destinationfileName);


                if (File.Exists(sourceFile))
                {
                    WriteMessageToLogFile("File Present. Begin Read of  excel file");

                    string excelconnectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                    string conStr = string.Format(excelconnectionstring, sourceFile, "YES");
                    DataSet dsExcel = new DataSet();
                    using (OleDbConnection cm1 = new OleDbConnection(conStr))
                    {
                        cm1.Open();
                        using (OleDbCommand cmd = new OleDbCommand("SELECT * From [Sheet1$]", cm1))
                        {
                            using (OleDbDataAdapter da = new OleDbDataAdapter())
                            {
                                da.SelectCommand = cmd;
                                da.Fill(dsExcel);
                            }
                        }
                    }
                    WriteMessageToLogFile("Read of  excel file completed successfully");


                    //Code to insert the rows in Database
                    string connectionstringtodatabase = "Data Source=acts-pc;Initial Catalog=Dec26_SimpleLMS;Persist Security Info=True;User ID=sa;Password=boss";
                    foreach (DataTable table in dsExcel.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            //using (SqlConnection cm1 = new SqlConnection(connectionstringtodatabase))
                            //{
                            //    cm1.Open();
                            //    using (SqlCommand cmd = new SqlCommand("AddNewBook", cm1))
                            //    {
                            //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            //        cmd.Parameters.AddWithValue("@author", dr[0].ToString());
                            //        cmd.Parameters.AddWithValue("@title", dr[1].ToString());
                            //        cmd.Parameters.AddWithValue("@price", dr[2].ToString());
                            //        cmd.Parameters.AddWithValue("@description", dr[3].ToString());
                            //        cmd.ExecuteNonQuery();
                            //    }
                            //}
                            //using Entity Framework
                            using (var context = new Dec26_SimpleLMSEntities())
                            {
                                var book = new tbl_Catalog()
                                {
                                    author = dr[0].ToString(),
                                    title = dr[1].ToString(),
                                    price = decimal.Parse(dr[2].ToString()),
                                    description = dr[3].ToString(),
                                    isBookIssued = false

                                };
                                context.tbl_Catalog.Add(book);
                                context.SaveChanges();
                            }
                        }
                    }
                    int noofrowsinserted = dsExcel.Tables[0].Rows.Count;
                    WriteMessageToLogFile(noofrowsinserted + " Rows Saved to LMS DatabaseSuccessfully");
                    System.IO.File.Move(sourceFile, destFile);
                }
            }
            catch (Exception cc)
            {
                WriteMessageToLogFile("Exception occured @" + DateTime.Now.ToString());
                WriteMessageToLogFile(cc.Message);
            }

        }


        protected override void OnStop()
        {
            WriteMessageToLogFile("Service stopped at:" + DateTime.Now.ToString());
        }

        public void WriteMessageToLogFile(string content)
        {
            //set up a filestream
            using (FileStream fs = new FileStream(@"C:\DAC_DotNet_Dec2019\Labs\BookCatalogLog.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //set up a streamwriter for adding text
                StreamWriter sw = new StreamWriter(fs);
                //find the end of the underlying filestream
                sw.BaseStream.Seek(0, SeekOrigin.End);
                //add the text
                sw.WriteLine(content);
                //add the text to the underlying filestream
                sw.Flush();
                //close the writer
                sw.Close();
            }
        }
    }
}
