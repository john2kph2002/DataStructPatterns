using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class SquareNumbersTotal
    {
        private int squared(int val)
        {
            int y;
            int x = 1;
            int total = 0;
            while (x <= val)
            {
                y = x * x;
                Console.WriteLine(y.ToString());
                Console.WriteLine();
                total = total + y;
                x = x + 1;
            }
            return total;
        }
        public void print()
        {
            var watch = new Stopwatch();
            watch.Start();

            int value;
            Console.Write("Input square values :");
            value = Convert.ToInt32(Console.ReadLine());
            var total = squared(value);
            Console.Write("total is: ");
            Console.WriteLine(total);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
