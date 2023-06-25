using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class ReverseIntegers
    {
        private int reverse(int num)
        {
            int r, sum = 0, t;

            Console.WriteLine(num);

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
                Console.WriteLine(sum);
            }
            return sum;
          
        }
        public static void reverseList(int value)
        {
            List<int> firstlist = new List<int>();

            // Adding elements to List
            for (int i = 1; i <= value; i++)
            {
                firstlist.Add(i);
            }

            Console.WriteLine("Elements Present in List:");

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("After Reversing: ");

            // using method Reverse()
            firstlist.Reverse();

            // Displaying the elements of List
            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }

            //return text.ToString();
        }
        public void print()
        {
            var watch = new Stopwatch();         

            int value;
            Console.Write("Display the number in reverse order:\n");
            Console.Write("--------------------------------------");
            Console.Write("Input Integers :");
            value = Convert.ToInt32(Console.ReadLine());

            watch.Start();
            var sum = reverse(value);
            Console.Write(" : {0} \n", sum);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
