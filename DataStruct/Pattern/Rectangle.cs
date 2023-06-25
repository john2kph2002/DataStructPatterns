using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Pattern
{
    public class Rectangle
    {
        private void pattern(int val)
        {
            for (int i = 0; i < val; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < val; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < val; j++)
                    {
                        if (j == 0 || j == 6)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
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
