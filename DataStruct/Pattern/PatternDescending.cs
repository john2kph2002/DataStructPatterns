using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Pattern
{
    public class PatternDescending
    {
        private void pattern(int val)
        {
            for (int row = val; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void print()
        {
            var watch = new Stopwatch();
            watch.Start();

            int value;
            Console.Write("Input number of rows for this pattern :");
            value = Convert.ToInt32(Console.ReadLine());
            pattern(value);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
