using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seconddotnetprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn0.Text;
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            txtResult.Text += btndecimal.Text;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnadd.Text;
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnsub.Text;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            txtResult.Text += btndivide.Text;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnmul.Text;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string currenttext = txtResult.Text;
            if (currenttext.Length>0)
            {
                txtResult.Text = currenttext.Substring(0, currenttext.Length - 1);
            }
            
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                txtResult.Text = dt.Compute(txtResult.Text, "").ToString();
            }

            catch(Exception ex)
            {
                txtResult.Text = ex.Message;
            }
                      
        }
    }
}
