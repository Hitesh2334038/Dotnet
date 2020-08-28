using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> citynames = new List<string>() { "chennai","bangalore","mumbai"};
            citynames.Insert(1, "hyderabad");
            Console.WriteLine(citynames[0]);
            Console.WriteLine(citynames[1]);
            Console.WriteLine(citynames[2]);

            //Add<int>(50, 100);

            Dictionary<string, int> citypop = new Dictionary<string, int>();
            citypop.Add("chennai", 100000000);
            citypop.Add("delhi", 300000000);
            citypop.Add("mumbai", 250000000);

            SortedList<string, int> citypopsort = new SortedList<string, int>();
            citypopsort.Add("mumbai", 250000000);
            citypopsort.Add("chennai", 100000000);
            citypopsort.Add("delhi", 300000000);
          
            Console.WriteLine(citypop["delhi"]);


            SortedSet<int> sset = new SortedSet<int>();
            sset.Add(75);
            sset.Add(20);
            sset.Add(452);
            sset.Add(865);
            sset.Add(150);


            Stack<int> st = new Stack<int>();
            st.Push(50);
            st.Push(75);
            Console.WriteLine(st.Pop());


            Queue<int> qu = new Queue<int>();
            qu.Enqueue(90);
            qu.Enqueue(50);

            LinkedList<int> ll = new LinkedList<int>();


            Console.ReadLine();
        }


        public static void Add<T> (T x,T y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

    }
}
