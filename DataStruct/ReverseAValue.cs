using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class ReverseAValue
    {
        private List<int> reverseList(int value)
        {
            List<int> firstlist = new List<int>();

            // Adding elements to List
            for (int i = 1; i <= value; i++)
            {
                firstlist.Add(i);
            }

            Console.Write("Elements Present in List : ");

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.Write(" {0}",k);
            }
            Console.WriteLine();
            Console.Write("After Reversing : ");

            // using method Reverse()
            firstlist.Reverse();          

            return firstlist;
        }
        public void print()
        {
            var watch = new Stopwatch();

            int value;
            Console.Write("Display a number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("Input An Integer :");
            value = Convert.ToInt32(Console.ReadLine());

            watch.Start();
            var rev = reverseList(value);
            // Displaying the elements of List
            foreach (int k in rev)
            {
                Console.Write(" {0}", k);
            }
            Console.WriteLine();
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
