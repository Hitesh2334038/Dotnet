using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadANDPara
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            Console.WriteLine("C# For Loop");
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
               
                Thread.Sleep(1000);
            }
            s.Stop();
            Console.WriteLine("The Elapsed Time is " + s.ElapsedMilliseconds);
            s.Reset();
            s.Start();
            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, new ParallelOptions { MaxDegreeOfParallelism = 5 }, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(1000);
            });
            s.Stop();
            Console.WriteLine("The Elapsed Time is " + s.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
