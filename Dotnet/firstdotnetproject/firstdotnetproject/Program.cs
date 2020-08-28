using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstdotnetproject
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
        step1:
            Console.WriteLine("Please enter the number 1");

            try
            {
                num1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number for Num 1");
                goto step1;
            }

        step2:
            Console.WriteLine("Please enter the number 2");

            int.TryParse(Console.ReadLine(), out num2);
            if (num2 == 0)
            {
                Console.WriteLine("Please enter a valid number for Num 2");
                goto step2;
            }

            int result = num1 + num2;
            Console.WriteLine("String cancatination of 2 numbers " + result);
            Console.ReadLine();

            byte x1 = 200;
            short x2;
            int x3 = 270;
            long x4;  //9223372036,85,47,75,807
            float x5;
            double x6;
            decimal x7;
            x4 = x1;
            // x1 =checked((byte)x3);

            object c = x3; // boxing happens
            Console.WriteLine(c); // un boxing happens
            c = "happy";
            Console.WriteLine(c);

            ArrayList al = new ArrayList();
            al.Add(500);
            al.Add(true);
            al.Add("Name");

            TextReader reader = File.OpenText(@"C:\DAC_DotNet_Dec2019\DotNet_Notes.txt");
            for (int i = 0; i < 10; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
            reader.Dispose();


            using (TextReader reader2 = File.OpenText(@"C:\DAC_DotNet_Dec2019\DotNet_Notes.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    string line = reader2.ReadLine();
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("Please enter the username");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome " + username + " to the First Dot net program in CDAC");
            Console.ReadLine();
        }
    }
}
