using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Pattern
{
    public class W
    {
        private void pattern(int val)
        {
            for (int i = 0; i < val; ++i)
            {
                stars(i + 1);
                spaces(val - i - 1);
                stars(val - i + 1);
                spaces(2 * i);
                stars(val - i);
                spaces(val - i - 1);
                stars(i + 1);
                Console.WriteLine();
            }
        }
        static void stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write("*");
        }

        static void spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(" ");
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
