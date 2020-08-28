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

namespace ReadXL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};" + "Extended Properties='Excel 8.0;HRD={1}'";
            // string connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};";
            //@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\MCA-3\FinalProject\BD_ShahCo\DB_FProject.mdb"
            string sourceFile = @"C:\Users\sonar\Downloads\Book1.xlsx";
            string conStr = string.Format(connection, sourceFile, "YES");
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
            dataGridView1.DataSource = dsExcel.Tables[0];
        }
    }
}
