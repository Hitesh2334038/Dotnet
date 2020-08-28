using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibFunctionality
{
    public partial class AuthenticateUser : System.Web.UI.UserControl
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["userinfods"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}