using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndRefrence
{
    unsafe class Program
    {
        static void Main(string[] args)
        {

            List<int> objt = new List<int>();
            objt.Add(75);
            objt.Add(25);
            objt.Add(150);


            int a = 4;
            long b = 5656;// 599999999999999999;
            //b = a;
            a =  checked((int)b);

            Console.WriteLine(a);

            
            byte xxxx;
            string name = "chennai";

            int x=100, y = 100;
            Calculate(ref x,ref  y, ref name);//Pass By Refrence and pass by Value

            Console.WriteLine("Inside the  Main program");
            Console.WriteLine("The Value of X is " + x);//100
            Console.WriteLine("The Value of Y is " + y);//100
            Console.WriteLine("The Value of name is " + name);//100

            List<int> coll = new List<int>();
            coll.Add(100);
            ManilupateList(coll);//Pass by Refrence
            Console.WriteLine("Inside the   Main program");
            Console.WriteLine("The Value of Collection is " + coll[0]);//150


            TypedReference tr = __makeref(coll);
            IntPtr ptr = **(IntPtr**)(&tr);
            Console.WriteLine(ptr);
            Console.ReadLine();
        }


        public static void ManilupateList(List<int> obj)
        {
            //TypedReference tr = __makeref(obj);
            //IntPtr ptr = **(IntPtr**)(&tr);
            //Console.WriteLine(ptr);
          
            obj[0] = obj[0] + 50;
            Console.WriteLine("Inside the  ManilupateList function");
            Console.WriteLine("The Value of Collection is " + obj[0]);//150
        }
        
        public static void Calculate(ref int x1,ref int y1, ref string name1)
        {
            x1 = x1 + 50;
            y1 = y1 - 50;
            name1 = name1 + " Cdac";
            Console.WriteLine("Inside the  Calculate function");
            Console.WriteLine("The Value of X is " + x1);//150
            Console.WriteLine("The Value of Y is " + y1);//50
            Console.WriteLine("The Value of name is " + name1);
        }
    }
}

