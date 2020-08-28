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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterUser frmRegister = new RegisterUser();
            this.Hide();
            frmRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "ValidateUser";
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
    
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                        }
                    }
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblErrorBox.Text = "User is valid";
                    HomePage fromhome = new HomePage();
                    this.Hide();
                    fromhome.userinfoDs = ds;
                    fromhome.Show();

                }
                else
                {
                    lblErrorBox.Text = "Please enter a valid user name and password.";
                }
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
