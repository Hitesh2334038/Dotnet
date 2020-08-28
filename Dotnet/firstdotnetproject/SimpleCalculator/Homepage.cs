using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    enum Carcolor
    {
        red=1, green=3, blue=5, white=9
    }

    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleCalc ss = new SimpleCalc();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DynamicControls dd = new DynamicControls();
            dd.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res;
            StringBuilder sb = new StringBuilder();
            long x=0;
            while (true)
            {
                x++;
                res = x.ToString() + ",";
                sb.Append(res);
            }
            GC.Collect();
            char dd;


            Directory.CreateDirectory("C:\\Sharanth\\Test");
            //method 1
            StreamReader ss = new StreamReader("");
            //some code here
            ss.Close();
            ss.Dispose();

            //method 2
            using(StreamReader s1 = new StreamReader(""))
            {
                //some code here
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            int value = (int)Carcolor.white;
            MessageBox.Show(value.ToString());

            const double pivalue = 3.147;

            object t1 = 35345;//Boxing
            int sss = (int)t1;//unboxing

            ArrayList r = new ArrayList();
            r.Add(54545);
            r.Add("aadasd");
            r.Add(true);

        }
    }
}
