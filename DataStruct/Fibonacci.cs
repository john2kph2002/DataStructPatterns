using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class Fibonacci
    {
        private void fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        private void fibonacci_Recursive(int len)
        {
            fibonacci_Rec_Temp(0, 1, 1, len);
        }
        private void fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }
        public void print()
        {
            var watch = new Stopwatch();           

            int value;
            Console.Write("Input a value to compute Fibonacci :");
            value = Convert.ToInt32(Console.ReadLine());

            watch.Start();
            fibonacci_Recursive(value);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
