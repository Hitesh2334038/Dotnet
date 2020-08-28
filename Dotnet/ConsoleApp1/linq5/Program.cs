using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();
            var result4 = numbers.Count();

            var result5 = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result5);

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result4);

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);

            int[] numbers1 = { 6, 9, 3, 7, 5 };

            var result1 = numbers1.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result1);

            int[] numbers2 = { 2, 8, 5, 6, 1 };

            var result2 = numbers2.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result2);

            var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));
            Int64 result3 = largeArr.LongCount();
            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result3);


            Console.ReadLine();
        }
    }
}
