using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibFunctionality
{
    public partial class Homrpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userinfods"] != null)
            {
                DataSet newds = new DataSet();
                newds = (DataSet)Session["userinfods"];
                GridView1.DataSource = newds;
                GridView1.DataBind();
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}