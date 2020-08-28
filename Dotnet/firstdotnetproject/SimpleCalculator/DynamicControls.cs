using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class DynamicControls : Form
    {
        public DynamicControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int noofcontrol = int.Parse(textBox1.Text);
            int noofcontrol = 0;
            int.TryParse(textBox1.Text, out noofcontrol);


            //MessageBox.Show("The No Of Controls which would be created is " + noofcontrol);

            for (int loopocount = 0; loopocount < noofcontrol; loopocount++)
            {
                System.Windows.Forms.TextBox txtb = new TextBox();
                txtb.Location = new System.Drawing.Point(50, ((loopocount * 25) + 50));
                txtb.BackColor = Color.CornflowerBlue;
                txtb.Name = "textBox" + loopocount;
                txtb.Size = new System.Drawing.Size(100, 20);
                txtb.TabIndex = loopocount;

                this.Controls.Add(txtb);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(null, null);
            }
        }

        private void DynamicControls_Load(object sender, EventArgs e)
        {
            StringBuilder randomText = new StringBuilder();
            string alphabets = "@$#%^&*abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random r = new Random();
            for (int j = 0; j <= 6; j++)
            {
                randomText.Append(alphabets[r.Next(alphabets.Length)]);
            }

            SharTextBox t = new SharTextBox();
            t.Name = "tt1";
            Size s = new System.Drawing.Size();
            s.Height = 50;
            s.Width = 300;
            t.Size = s;
            Point pt = new Point();
            pt.X = 250;
            pt.Y = 300;
            t.Location = pt;
            t.BackColor = Color.HotPink;
            t.MaxLength = 500;
            this.Controls.Add(t);
        }
    }
}
