using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> citynameList = new List<string>()
                {
                    "jaipur","Delhi","Patna","Agra","Chennai","pune"
                };

                var res = from obj in citynameList
                          where obj.Contains("a")
                          orderby obj
                          select obj;

                foreach (string x in res )
                {
                    Console.WriteLine(x);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
