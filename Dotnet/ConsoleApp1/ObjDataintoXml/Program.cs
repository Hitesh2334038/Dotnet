using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjDataintoXml
{
    public class XMLWrite
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            WriteXML();
        }

        public class Book
        {
            public String title;
            public int id;
            public string author;
            public int releaseDate;
        }

        public static void WriteXML()
        {
            Book overview = new Book()
            {
                title = "Serialization Overview",
                id = 11,
                author = "Hitesh",
                releaseDate = 2019
            };
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();

        //    string output = JsonConvert.SerializeObject(Book);
          //  System.Xml.Serialization.XmlSerializer reader =
       //new System.Xml.Serialization.XmlSerializer(typeof(Book));
         //   System.IO.StreamReader file1 = new System.IO.StreamReader(
           //     @"C:\Users\sonar\Documents\SerializationOverview.xml");
           // Book overview1 = (Book)reader.Deserialize(file1);
           // file.Close();


            //Console.WriteLine(overview1.title);
        }
    }


}
