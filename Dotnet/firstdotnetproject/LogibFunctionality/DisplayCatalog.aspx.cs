using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibFunctionality
{
    public partial class DisplayCatalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet newds = new DataSet();
            newds = (DataSet)Session["userinfods"];
            Response.Write(newds.Tables[0].Rows[0][0]);
        }
    }
}