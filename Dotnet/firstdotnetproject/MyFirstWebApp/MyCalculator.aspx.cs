using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class MyCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Text += "Page_Load" + Environment.NewLine;
            if(!IsPostBack)
            {
                TextBox1.Text = "Please enter a name";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button13.Text;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button14.Text;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button17.Text;
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button19.Text;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button9.Text;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button10.Text;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button11.Text;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button12.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button1.Text;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button6.Text;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button7.Text;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button8.Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button5.Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            txtResult.Text += Button4.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string currenttext = txtResult.Text;
            if (currenttext != "")
            {
                txtResult.Text = currenttext.Substring(0, currenttext.Length - 1);
            }
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                txtResult.Text = dt.Compute(txtResult.Text, "").ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text += "Button20_Click" + Environment.NewLine;
            //lblErrorMessage.Text = "Welcome " + TextBox1.Text + " to the first web app created";
        }

        protected void Button20_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Text += "Button20_Load" + Environment.NewLine;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Text += "CheckBox1_CheckedChanged" + Environment.NewLine;
        }
    }
}