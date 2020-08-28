using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serilization
{
    [Serializable]
    class Program
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            try
            {
                Program obj = new Program();
                obj.ID = 1;
                obj.Name = "Hitesh";

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"D:\Dotnet\ConsoleApp1\Hitesh", FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, obj);
                stream.Close();

               // IFormatter formatter = new BinaryFormatter();
                 stream = new FileStream(@"D:\Dotnet\ConsoleApp1\Hitesh", FileMode.Open, FileAccess.Read);
                Program objnew = (Program)formatter.Deserialize(stream);

                Console.WriteLine(objnew.ID);
                Console.WriteLine(objnew.Name);
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
