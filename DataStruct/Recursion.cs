using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    class Recursion
    {
        public int sumN(int n)
        {
            return n * (n + 1) / 2;
        }
        public int sumnIteration(int n)
        {
            int total = 0;
            int i = 1;
            while(i <= n)
            {
                total = total + i;
                i++;
            }
            return total;
        }
        public int sumnRecursion(int n)
        {
            if (n == 0)
                return 0;
            return sumnRecursion(n - 1) + n;
        }
        public void print()
        {
            Recursion sum = new Recursion();
            Console.WriteLine("Sum: " + sum.sumN(5));
            Console.WriteLine("Sum: " + sum.sumnIteration(5));
            Console.WriteLine("Sum: " + sum.sumnRecursion(5));
            Console.ReadKey();
        }
    }
}
