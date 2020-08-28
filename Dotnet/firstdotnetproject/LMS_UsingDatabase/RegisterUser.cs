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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login fromLogin = new Login();
            this.Hide();
            fromLogin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
            txtEmailAddress.Text = "";
            txtMobileNumber.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
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
                        cmd.CommandText = "RegisterNewUser";
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@mobilenumber", txtMobileNumber.Text);
                        cmd.Parameters.AddWithValue("@emailaddress", txtEmailAddress.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            lblErrorBox.Text = "User is registered successfully";
                        }
                        else
                        {
                            lblErrorBox.Text = "User registeration Failed. Please re try after some time.";
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
