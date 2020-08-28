using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibFunctionality
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection("Data Source=acts-pc;Initial Catalog=TicketBookingSystem;User ID=cdac;Password=cdac"))
           
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "validateuser";
                    cmd.Parameters.AddWithValue("@username", Login1.UserName);
                    cmd.Parameters.AddWithValue("@password", Login1.Password);
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                    }
                }
            }

            //If ds contrains rows then the user is valid
            if(ds.Tables[0].Rows.Count>0)
            {
                Session["userinfods"] = ds;
                e.Authenticated = true;
            }
        }
    }
}