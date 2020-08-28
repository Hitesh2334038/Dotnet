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
    public partial class HomePage : Form
    {
        public DataSet userinfoDs = new DataSet();
        public string bookid;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            txtWelcomeUser.Text = "Welcome " + userinfoDs.Tables[0].Rows[0][1];
            txtUSerid.Text = "UserId: " + userinfoDs.Tables[0].Rows[0][0];

            //Code to display all Available books to the user
            try
            {
                string connectionstringtodatabase = "Data Source=acts-PC;Initial Catalog=MiscDB;User ID=sa;Password=boss";
                DataSet ds = new DataSet();
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DisplayAllAvailableBooks";
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
                lblErrorBox.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Hide();
            frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePErsonalDetails frmUpdate = new UpdatePErsonalDetails();
            this.Hide();
            frmUpdate.userinfoDs = userinfoDs;
            frmUpdate.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnBook frmRb = new ReturnBook();
            this.Hide();
            frmRb.userinfoDs = userinfoDs;
            frmRb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "IssueBookToUser";
                        cmd.Parameters.AddWithValue("@libraryuserud",userinfoDs.Tables[0].Rows[0][0]);
                        cmd.Parameters.AddWithValue("@bookid", bookid);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            lblErrorBox.Text = "Book " + bookid + " is Issued successfully";
                        }
                        else
                        {
                            lblErrorBox.Text = "Book Issue Failed. Please re try after some time.";
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
                        cmd.Parameters.AddWithValue("@isBookIssued", 1);
                        cmd.Parameters.AddWithValue("@bookid", bookid);
                        cmd.ExecuteNonQuery();
                    }
                }


                HomePage_Load(null, null);
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                bookid = Convert.ToString(selectedRow.Cells[0].Value);
                btnIssueBook.Enabled = true;

            }
        }

        
    }
}
