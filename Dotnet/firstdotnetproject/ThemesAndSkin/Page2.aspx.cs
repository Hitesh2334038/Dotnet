using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThemesAndSkin
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["themename"] != null)
            {
                Page.Theme = Session["themename"].ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection cn = new SqlConnection("Data Source=ACTS-PC;Initial Catalog=CountryStateCity;User ID=sa;Password=boss"))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select c.name as 'County',s.name as 'state',ci.name as'city' from countries c, states s, cities ci where c.id = s.country_id and s.id = ci.state_id";
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                    }
                }
            }
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}