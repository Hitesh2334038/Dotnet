using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 50;
            int y = 10;
            int z = 0;
            sub(x, y, out z);

            int si = simpleinterest(1000,7); //Optional Parameter implementeed by giving default values

           si= simpleinterest(r: 15, n: 5, p: 1000); // Named Paramater

            Console.WriteLine("The Simple interst is");
            Console.WriteLine(si);
            //default parameters
            Console.WriteLine("The Value of z is " + z);

            int inputfropmuser = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out inputfropmuser);



            Console.ReadLine();
        }

        public static int simpleinterest( int p,int r, int n=1)
        {
            return p * n * r / 100;
        }
        public static int add(int x,int y)
        {
            int result = 0;
            result = x + y;
            return result;
        }

        public static void sub(int x, int y, out int result)
        {
            result = x - y;
        }
    }
}
