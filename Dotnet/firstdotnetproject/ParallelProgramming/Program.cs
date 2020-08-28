#define Cdac
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ParallelProgramming
{
    class Program
    {

        #region Constrtor

        #endregion

        #region Variables


        #endregion

        #region SystemDefinedMethodsAndEvents
        static void Main(string[] args)
        {

            ConcurrentDictionary<string, string> newlist = new ConcurrentDictionary<string, string>();
            for (int i = 0; i < 150; i++)
            {
                newlist.TryAdd(i.ToString(), null);
            }

            Stopwatch sw1 = new Stopwatch();
            Console.WriteLine("Start Of Sequential Program");
            sw1.Start();
            for (int counter = 0; counter < 150; counter++)
            {
                newlist[counter.ToString()] = FindFactorial(counter).ToString();
            }
            Console.WriteLine("End Of Sequential Program");
            sw1.Stop();
            Console.WriteLine("The Elapsed Time is " + sw1.ElapsedMilliseconds);
            sw1.Reset();
            sw1.Start();
            Console.WriteLine("Start Of  Parallel Program");
            Parallel.For(0, 150, new ParallelOptions { MaxDegreeOfParallelism = 8 },
                              counter =>
                              {
                                  newlist[counter.ToString()] = FindFactorial(counter).ToString();
                              });

            Console.WriteLine("End Of Parallel Program");
            sw1.Stop();
            Console.WriteLine("The Elapsed Time is " + sw1.ElapsedMilliseconds);

#if Cdac
            Console.WriteLine("Cdac is defined");
#else
        Console.WriteLine("Cdac is undefined");
#endif

            Stopwatch sw = new Stopwatch();
            List<int> collection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            

            sw.Start();
            Console.WriteLine("Start Of  Sequential Program");
            #region  ParallelFor
            for (int counter = 1; counter <= 10; counter++)
            {
                FindFactorialWithSimulatedDelay(counter);
            }

            #endregion

            //#region ParallelForeach

            //foreach (int num in collection)
            //{
            //    FindFactorialWithSimulatedDelay(num);
            //}
            //#endregion

            Console.WriteLine("End Of Sequential Program");
            sw.Stop();
            Console.WriteLine("The Elapsed Time is" + sw.ElapsedMilliseconds);

            sw.Reset();
            sw.Start();
            Console.WriteLine("Start Of  Parallel Program");

            Parallel.For(1, 10, new ParallelOptions { MaxDegreeOfParallelism = 5 },
                              counter =>
                              {
                                  FindFactorialWithSimulatedDelay(counter);
                              });

            //           Parallel.ForEach(collection, new ParallelOptions { MaxDegreeOfParallelism = 10 }, num =>
            //           {
            //               FindFactorialWithSimulatedDelay(num);
            //           }
            //);
            Console.WriteLine("End Of Parallel Program");
            sw.Stop();
            Console.WriteLine("The Elapsed Time is" + sw.ElapsedMilliseconds);




            Console.ReadLine();
        }
        #endregion

        #region UserDefinedFunction

        private static void FindFactorialWithSimulatedDelay(int no)
        {
            int result = 1;
            for (int i = 1; i <= no; i++)
            {
                Thread.Sleep(500);
                result = result * i;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("The Factorial of ");
            sb.Append(no);
            sb.Append("is:");
            sb.Append(result);
            Console.WriteLine(sb.ToString());
        }

        private static double FindFactorial(int no)
        {
            double result = 1;
            for (double i = 1; i <= no; i++)
            {
                result = result * i;
            }
            Thread.Sleep(10);
            return result;
        }
        #endregion


    }
}
