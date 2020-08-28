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

namespace FirstDatabaseProject
{
    public partial class DACStudent : Form
    {
        public DACStudent()
        {
            InitializeComponent();
        }

        private void DACStudent_Load(object sender, EventArgs e)
        {

            DisplayStudentInfo();
        }

        private void DisplayStudentInfo()
        {
            try
            {
                //select
                string connectionstringtodatabase = "Data Source=ACTS-PC;Initial Catalog=dac;Persist Security Info=True;User ID=sa;Password=boss";
                DataSet ds = new DataSet();
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SelectStudentInfo";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMarks1.Text = "";
            txtMarks2.Text = "";
            txtStudentAddress.Text = "";
            txtStudentCourse.Text = "";
            txtStudentId.Text = "";
            txtStudentName.Text = "";
            lblErrorBox.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //insert
                string connectionstringtodatabase = "Data Source=ACTS-PC;Initial Catalog=dac;Persist Security Info=True;User ID=sa;Password=boss";
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "InsertStudent";
                        cmd.Parameters.AddWithValue("@studentname", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@course", txtStudentCourse.Text);
                        cmd.Parameters.AddWithValue("@studentaddress", txtStudentAddress.Text);
                        cmd.Parameters.AddWithValue("@m1", txtMarks1.Text);
                        cmd.Parameters.AddWithValue("@m2", txtMarks2.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            DisplayStudentInfo();
                            btnReset_Click(null, null);
                            lblErrorBox.Text = "Student Inserted Successfully";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtStudentId.Text = row.Cells[0].Value.ToString();
                txtStudentName.Text = row.Cells[1].Value.ToString();
                txtStudentCourse.Text = row.Cells[2].Value.ToString();
                txtStudentAddress.Text = row.Cells[3].Value.ToString();
                txtMarks1.Text = row.Cells[4].Value.ToString();
                txtMarks2.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // update
                string connectionstringtodatabase = "Data Source=ACTS-PC;Initial Catalog=dac;Persist Security Info=True;User ID=sa;Password=boss";
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UpdateStudentInfo";
                        cmd.Parameters.AddWithValue("@studentid", txtStudentId.Text);
                        cmd.Parameters.AddWithValue("@studentname", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@course", txtStudentCourse.Text);
                        cmd.Parameters.AddWithValue("@studentaddress", txtStudentAddress.Text);
                        cmd.Parameters.AddWithValue("@m1", txtMarks1.Text);
                        cmd.Parameters.AddWithValue("@m2", txtMarks2.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            DisplayStudentInfo();
                            btnReset_Click(null, null);
                            lblErrorBox.Text = "Student Update Successfully";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // delete
                string connectionstringtodatabase = "Data Source=ACTS-PC;Initial Catalog=dac;Persist Security Info=True;User ID=sa;Password=boss";
                using (SqlConnection cn = new SqlConnection(connectionstringtodatabase))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DeleteStudentInfo";
                        cmd.Parameters.AddWithValue("@studentid", txtStudentId.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            DisplayStudentInfo();
                            btnReset_Click(null, null);
                            lblErrorBox.Text = "Student Deleted Successfully";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }
    }
}
