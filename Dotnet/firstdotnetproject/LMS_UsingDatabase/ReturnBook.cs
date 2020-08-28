using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_UsingDatabase
{
    public partial class ReturnBook : Form
    {
        public DataSet userinfoDs = new DataSet();
        public int libraryUserid = 0;
        string bookissueid;
        string bookid;

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstringtodatabase = "Data Source=acts-PC;Initial Catalog=LMS;Integrated Security=True";
                DataSet ds = new DataSet();
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "BooksIssuedToUser";
                        cmd.Parameters.AddWithValue("@libraryuserid", userinfoDs.Tables[0].Rows[0][0]);
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                        }
                    }
                }

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //lblErrorBox.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage fromhome = new HomePage();
            this.Hide();
            fromhome.userinfoDs = userinfoDs;
            fromhome.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                bookissueid = Convert.ToString(selectedRow.Cells[0].Value);
                bookid = Convert.ToString(selectedRow.Cells[2].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstringtodatabase = "Data Source=acts-PC;Initial Catalog=LMS;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ReturnBook";
                        cmd.Parameters.AddWithValue("@bookissueid", bookissueid);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            lblErrorBox.Text = "Book " + bookid + " is Returned successfully";
                        }
                        else
                        {
                            lblErrorBox.Text = "Book Return Failed. Please re try after some time.";
                        }
                    }
                }

                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UpdateBookStatus";
                        cmd.Parameters.AddWithValue("@isBookIssued", 0);
                        cmd.Parameters.AddWithValue("@bookid", bookid);
                        cmd.ExecuteNonQuery();
                    }
                }


                ReturnBook_Load(null, null);
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }
    }
}
