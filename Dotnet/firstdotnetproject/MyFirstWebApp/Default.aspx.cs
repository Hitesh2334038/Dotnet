using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstringtodatabase = "Data Source=acts-PC;Initial Catalog=LMS;User ID=sa;Password=boss";
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
                    lblErrorMessage.Text = "User is valid";
                    //QueryString way to transfer data from  login to Homepage
                    string destinationpage = "HomePage.aspx?username=" + ds.Tables[0].Rows[0][1] + "&userid=" + ds.Tables[0].Rows[0][0];
                    //Response.Redirect(destinationpage);

                    //Use Cookie to transfer
                    HttpCookie strname = new HttpCookie("name");
                    strname.Value = ds.Tables[0].Rows[0][1].ToString();
                    strname.Expires = DateTime.Now.AddSeconds(10);
                    Response.Cookies.Add(strname);

                    //Use session to transfer Data
                    Session["name"] = ds.Tables[0].Rows[0][1].ToString();
                    Session["ds"] = ds;
                    string destinationpage2 = "HomePage.aspx";
                    Response.Redirect(destinationpage2);

                    
                }
                else
                {
                    lblErrorMessage.Text = "Please enter a valid user name and password.";
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}