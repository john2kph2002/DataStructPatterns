using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    class Factorial
    {
        public int factorialIterative(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public int factorialRecursive(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return factorialRecursive(n - 1) * n;
            }
        }
        public int factorialLinq(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                var fact = (int)Enumerable.Range(1, n)
                                   .Aggregate(1L, (acc, x) => acc * x);
                return fact;
            }
        }

        public void print()
        {
            var watch = new Stopwatch();

            int num = 0;           
            Console.Write("\n\nFACTORIAL:\n");
            Console.Write("---------------------\n");
            Console.Write("Input how many elements : ");
            num = Convert.ToInt32(Console.ReadLine());

            watch.Start();

            Factorial fact = new Factorial();
            for (int i = 0; i < num; i++)
            {
                Console.Write("Factorial of - {0} = ", i);
                //arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fact.factorialIterative(i));
                //Console.WriteLine(fact.factorialIterative(i));
            }
            //Console.Write("\nFactorial of: ");
            //for (i = 0; i < x; i++)
            //{               
            //    Console.Write("{0}  ", arr[i]);
            //}
            //Console.Write("\n");

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
