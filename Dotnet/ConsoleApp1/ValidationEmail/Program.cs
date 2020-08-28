using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Your Email Id");
            string emailId = Console.ReadLine();


            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(emailId))
            {
                Console.WriteLine("Valid email id");
            }
            else
            {
                Console.WriteLine("Not Valid email id");
            }

            Console.ReadLine();
        }
    }
}
