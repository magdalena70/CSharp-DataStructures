using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_Demo
{
    class Program
    {
        static void Main()
        {
            var set = new SortedSet<int>(); // black-red tree
            set.Add(8); // 8
            set.Add(6); // 6, 8
            set.Add(-3); // -3, 6, 8
            set.Add(-78); // -78, -3, 6, 8
            set.Add(1); // -78, -3, 1, 6, 8
            set.Add(12); // -78, -3, 1, 6, 8, 12
            set.ToList().ForEach(s => Console.Write(s + " "));
            
            var subset = set.GetViewBetween(-78, 6); // O(log(n)) running time
            Console.WriteLine("\nGetViewBetween(-78, 6) ->");
            subset.ToList().ForEach(Console.WriteLine);

            set.Remove(-3);
            Console.WriteLine("Remove(-3) ->");
            Console.WriteLine(string.Join(" , ", set));

            //---------------------------//

            Random random = new Random();
            var randomSet = new SortedSet<int>();
            for (int i = 0; i < 10; i++)
            {
                randomSet.Add(random.Next(50)); // non repeating elements
            }
            Console.WriteLine(string.Join(" , ", randomSet));

            //--------------------------//

            var startTime = DateTime.Now;
            var sortedSet = new SortedSet<int>(); // tree
            for (int i = 0; i < 1000000; i++)
            {
                sortedSet.Add(i);
            }
            Console.WriteLine(DateTime.Now - startTime); // logarithm

            startTime = DateTime.Now;
            var list = new List<int>(); // list
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i);
                //list.Insert(0, i); // very slow
            }
            Console.WriteLine(DateTime.Now - startTime); //constant
        }
    }
}
