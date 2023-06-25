using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Pattern
{
    public class Space
    {
        private void pattern(int val)
        {
            for (int i = 0; i < val; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write("*");
                }

                if (i != val - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" * ");
                }
                for (int j = 0; j <= i; ++j)
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
