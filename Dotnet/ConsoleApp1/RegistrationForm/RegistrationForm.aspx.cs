using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
  
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
 

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["username"] = TxTUserName.Text;
            Session["password"] = TxTPassword.Text;
            Session["phoneno"] = TxTphoneNo.Text;
            Session["emailid"] = TxTEmailId.Text;

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            // string phonePattern = @"^(\+[0-9])$".Suss;
            // string MatchPass = @" ^ (.{ 0,7}|[^0 - 9] *|[^A - Z])$";
            bool isEmailValid = Regex.IsMatch(TxTEmailId.Text, emailPattern);
           //  bool isPhoneValid = Regex.IsMatch(TxTphoneNo.Text, phonePattern);
            //bool isPassword = Regex.IsMatch(TxTPassword.Text, MatchPass);
            var input = TxTPassword.Text;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
            MessageBox.Show("isValidated");


           //  if (!isPhoneValid)
            //{
              //MessageBox.Show("Please enter a valid phone number");
             //TxTphoneNo.Focus();
             //}
            if (TxTUserName.Text == null && TxTphoneNo.Text == null && TxTEmailId.Text == null && TxTPassword.Text == null)
            {
                MessageBox.Show("Fill the information.");
                TxTUserName.Focus();
                TxTphoneNo.Focus();
                TxTEmailId.Focus();
                TxTPassword.Focus();
            }
             if (!isEmailValid)
            {
                MessageBox.Show("Please enter a valid EmailId.");
                TxTEmailId.Focus();

            }
           
          //  else if(!isPassword)
            //{
              //  MessageBox.Show("Please enter a valid And Correct Password.");
            //}
          
            else if (TxTPassword.Text != TxTCPassword.Text)
            {
                MessageBox.Show("Password not matching");
                TxTCPassword.Focus();
               
            }
            else
            {

                Response.Redirect("ViewInfo.aspx");
            }
        }

       
    }
}