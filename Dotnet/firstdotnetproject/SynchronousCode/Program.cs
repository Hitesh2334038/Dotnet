using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronousCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int counter = 1; counter < 20; counter++)
            {
                if (counter % 3 == 0)
                {
                    //WriteFactorial(counter); // Sequential Programming
                    WriteFactorialAsyncUsingDelegate(counter); // Concurrent Programming using Async Calls
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
            Console.WriteLine("End Of Program");
            sw.Stop();
            Console.WriteLine("The Elapsed Time is" + sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void WriteFactorial(int no)
        {
            int result = FindFactorialWithSimulatedDelay(no);
            Console.WriteLine("Factorial of {0} is {1}", no, result);
        }

        private static void WriteFactorialAsyncUsingDelegate(int facno)
        {
            Func<int, int> findFact = FindFactorialWithSimulatedDelay;
            findFact.BeginInvoke(facno,
                                (iAsyncresult) =>
                                {
                                    AsyncResult asyncResult = iAsyncresult as AsyncResult;
                                    Func<int, int> del = asyncResult.AsyncDelegate as Func<int, int>;
                                    int factorial = del.EndInvoke(asyncResult);
                                    Console.WriteLine("Inside the Async Return Method");
                                    Console.WriteLine("Factorial of {0} is {1}", facno, factorial);
                                },
                                null);
        }

        private static int FindFactorialWithSimulatedDelay(int no)
        {
            int result = 1;
            for (int i = 1; i <= no; i++)
            {
                Thread.Sleep(500);
                result = result * i;
            }
            return result;
        }


    }
}
