using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Query String
            //lblWelcomeMessage.Text = "We are glad to welcome MR /Mrs " + Request["username"].ToString();

            //Cookies
            if (Request.Cookies["name"]!= null)
            {
                lblWelcomeMessage.Text = "We are glad to welcome MR /Mrs " + Request.Cookies["name"].Value;
            }
            else
            {
                lblWelcomeMessage.Text = "Cookie is expired";
            }

            //Session
            if (Session["name"] != null)
            {
                lblWelcomeMessage.Text = "We are glad to welcome MR /Mrs " + Session["name"].ToString();
                


                var ds = (DataSet)Session["ds"];
                lblWelcomeMessage.Text += Environment.NewLine + ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lblWelcomeMessage.Text = "Session is expired";
            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");

        }
    }
}