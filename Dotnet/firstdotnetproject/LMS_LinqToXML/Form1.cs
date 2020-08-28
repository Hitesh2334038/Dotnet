using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LMS_LinqToXML
{
    public partial class Form1 : Form
    {
        XDocument document = XDocument.Load(@"C:\Users\acts\Desktop\Nov2018\DAC_SAmples\LMS_LinqToXML\Books.xml");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Linq to XMl
            

            var childElements = from el in document.Descendants("book").Elements()
                                select el.Name.LocalName;
            var Tempres = childElements.ToList().Distinct().ToList();
            Tempres.Sort();
            comboBox1.DataSource = Tempres;


            DisplayAllBooksInfo();
        }

        private void DisplayAllBooksInfo()
        {
            var books = from r in document.Descendants("book")
                        select new
                        {
                            Author = r.Element("author").Value,
                            Title = r.Element("title").Value,
                            Genere = r.Element("genre").Value,
                            Price = r.Element("price").Value,
                            PublishDate = r.Element("publish_date").Value,
                            Description = r.Element("description").Value,
                            BookId = r.Attribute("id").Value
                        };

            dataGridView1.DataSource = books.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearchTerm.Text = "";
            DisplayAllBooksInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchcondition = comboBox1.Text;
            var books = from r in document.Descendants("book")
                        where r.Element(searchcondition).Value.Trim().ToLower().Contains(txtSearchTerm.Text.Trim().ToLower())
                        select new
                        {
                            Author = r.Element("author").Value,
                            Title = r.Element("title").Value,
                            Genere = r.Element("genre").Value,
                            Price = r.Element("price").Value,
                            PublishDate = r.Element("publish_date").Value,
                            Description = r.Element("description").Value,
                            BookId = r.Attribute("id").Value
                        };

            dataGridView1.DataSource = books.ToList();
        }
    }
}


