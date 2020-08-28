using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SetCaptchaText();
            }
        }

        private void SetCaptchaText()
        {
            List<string> validcharacters = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "$", "@", "!", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "Z", "X", "Y", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "-", "#"};
            StringBuilder sb = new StringBuilder();
            Random oRandom = new Random();
            for (int loopcount = 0; loopcount < 6; loopcount++)
            {
                int RanNumber = oRandom.Next(0, 66);
                string RanText = validcharacters[RanNumber];
                sb.Append(RanText);
            }
                //Random oRandom = new Random();
                //int iNumber = oRandom.Next(100000, 999999);
                //Session["Captcha"] = iNumber.ToString();
            Session["Captcha"] = sb.ToString();
            //lblErrorMessage.Text = "Random Number Generated is :" + iNumber.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Captcha"].ToString() != txtCaptcha.Text.Trim())
            {
                lblErrorMessage.Text = "Failure";
            }
            else
            {
                lblErrorMessage.Text = "Success";
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            SetCaptchaText();
        }
    }
}
