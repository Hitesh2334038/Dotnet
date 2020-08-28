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
    public partial class UpdatePErsonalDetails : Form
    {
        public DataSet userinfoDs = new DataSet();
        public int libraryUserid = 0;
        public UpdatePErsonalDetails()
        {
            InitializeComponent();
        }

        private void UpdatePErsonalDetails_Load(object sender, EventArgs e)
        {
            txtEmailAddress.Text = userinfoDs.Tables[0].Rows[0][5].ToString();
            txtMobileNumber.Text = userinfoDs.Tables[0].Rows[0][4].ToString();
            libraryUserid = int.Parse(userinfoDs.Tables[0].Rows[0][0].ToString());
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
                        cmd.CommandText = "UpdateUserInfo";
                        cmd.Parameters.AddWithValue("@libraryuserid", libraryUserid);
                        cmd.Parameters.AddWithValue("@mobilenumber", txtMobileNumber.Text);
                        cmd.Parameters.AddWithValue("@emailaddress", txtEmailAddress.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            lblErrorBox.Text = "User info is updated successfully";
                        }
                        else
                        {
                            lblErrorBox.Text = "User info updation Failed. Please re try after some time.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrorBox.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage fromhome = new HomePage();
            this.Hide();
            fromhome.userinfoDs = userinfoDs;
            fromhome.Show();
        }
    }
}
