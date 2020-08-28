using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
   

    public partial class SimpleCalc : Form
    {
        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                lblResult.Text = result.ToString();
                //MessageBox.Show(result.ToString());

                int c = 50;
                c++;
            }
            catch(Exception ex)
            {
                lblResult.Text = ex.Message;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int result = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                lblResult.Text = result.ToString();
            }
           
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
            
           
            finally
            {

            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lblResult.Text = "";
        }

        private void SimpleCalc_Load(object sender, EventArgs e)
        {
            byte sdsds;
            short xx;//int16
            int xxx;//int32
            long asdasd;
            Single ssss;
            double sadasdas;
            

            
        }
    }
}
