using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaSample
{
    public partial class Form1 : Form
    {
        Timer autoTimer = new Timer();
        private Random rand = new Random();
        string code;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateImage();
            autoTimer.Start();
            autoTimer.Interval = 3000;
            autoTimer.Tick += autoTimer_Tick;
        }

        private void CreateImage()
        {
            code = GetRandomText();
            Bitmap bitmap = new Bitmap(250, 50, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Yellow);
            Rectangle rect = new Rectangle(0, 0, 200, 50);

            SolidBrush b = new SolidBrush(Color.Pink);
            //SolidBrush White = new SolidBrush(Color.White);
            HatchBrush White =
   new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.Green);

            int counter = 0;

            g.DrawRectangle(pen, rect);
            g.FillRectangle(b, rect);

            for (int i = 0; i < code.Length; i++)
            {
                Random rr = new Random();
                int nummx = rr.Next(30, 60);
                int nummy = rr.Next(5, 20);
                g.DrawString(code[i].ToString(), new Font("san serif", 11 + rand.Next(14, 18)), White, new PointF(nummx + counter, nummy));
                counter += 20;
            }

            DrawRandomLines(g);

           // if (File.Exists("c:/TEMP/tempimage.bmp"))
            //{

              //  try
                //{
                  //  File.Delete("c:/TEMP/tempimage.bmp");
                    //bitmap.Save("c:/TEMP/tempimage.bmp");

//                }
  //              catch (Exception ex)
    //            {
      //              MessageBox.Show(ex.Message);
        //        }

          //  }
            //else
            //{
              //  bitmap.Save(@"D:\img");

            //}

            g.Dispose();
            bitmap.Dispose();
            pictureBox1.Image = Image.FromFile("c:/TEMP/tempimage.bmp");

        }

        private string GetRandomText()
        {
            StringBuilder randomText = new StringBuilder();

            if (String.IsNullOrEmpty(code))
            {
                string alphabets = "@$#%^&*abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                Random r = new Random();
                for (int j = 0; j < 5; j++)
                {

                    randomText.Append(alphabets[r.Next(alphabets.Length)]);
                }

                code = randomText.ToString();
            }

            return code;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }

            code = "";
            CreateImage();
        }
        private void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Red);


            //For Creating Lines on The Captcha
            for (int i = 0; i < 5; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }

        }
        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == code)
            {
                MessageBox.Show("Correct Entry");
            }
            else
            {
                MessageBox.Show("Incorrect entry");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autoTimer.Start();
            autoTimer.Interval = 3000;
            autoTimer.Tick += autoTimer_Tick;
        }

        void autoTimer_Tick(object sender, EventArgs e)
        {
            button3_Click(null, null);
        }

    }
}
