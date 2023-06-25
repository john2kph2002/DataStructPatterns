using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Pattern
{
    public class Arrow
    {
        private void pattern(int val)
        {
            int column;
            while (val >= 1)
            {
                column = 1;
                while (column <= 10)
                {
                    if (val % 2 == 1)
                    {
                        Console.Write("<");
                    }
                    else
                    {
                        Console.Write(">");
                    }
                    column = column + 1;
                }
                val = val - 1;
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
