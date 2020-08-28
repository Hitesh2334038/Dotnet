using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAnd_FolderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create(@"C:\DAC_DotNet_Dec2019\Labs\firstdotnetproject\FileAndFolderApp\" + txtfilename.Text + ".txt");
        }

        private void btnValidateEMailId_Click(object sender, EventArgs e)
        {
            string inputemailid = txtEmailId.Text.Trim();
            bool isEmail = Regex.IsMatch(inputemailid, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if(isEmail)
            {
                txtErrorMessageDisplay.Text = "Valid Email Id";
            }
            else
            {
                txtErrorMessageDisplay.Text = "In Valid Email Id. Please enter it again";
                txtEmailId.Text = "";
                txtEmailId.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string inputURL = txtEmailId.Text.Trim();
            bool isEmail = Regex.IsMatch(inputURL, @"^(http|ftp|https|www)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$", RegexOptions.IgnoreCase);
            if (isEmail)
            {
                txtErrorMessageDisplay.Text = "Valid URl";
            }
            else
            {
                txtErrorMessageDisplay.Text = "In Valid URL. Please enter it again";
                txtEmailId.Text = "";
                txtEmailId.Focus();
            }
        }
    }
}
