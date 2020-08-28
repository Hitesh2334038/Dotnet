using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class ViewInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null && Session["password"]!=null && Session["phoneno"]!=null && Session["emailid"]!=null)
            {
                lblUsername.Text = Session["username"].ToString();
                lblPassword.Text = Session["password"].ToString();
                lblMobileno.Text = Session["phoneno"].ToString();
                lblEmailid.Text = Session["emailid"].ToString();
            }
        }
    }
}