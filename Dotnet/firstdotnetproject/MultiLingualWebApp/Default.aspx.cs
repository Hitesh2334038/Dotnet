using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiLingualWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            double amount = 63343455.67;
            txtMoney.Text = string.Format("{0:c}", amount);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected override void InitializeCulture()
        {
            if (Request.Form["ddlLanguage"] != null)
            {
                string selectedValue = Request.Form["ddlLanguage"];
                SetCulture(selectedValue, selectedValue);
            }
            base.InitializeCulture();
        }

        protected void SetCulture(string name, string locale)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(name);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(locale);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(locale);
        }

    }
}