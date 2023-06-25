using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class ComputeJandK
    {
        void compute(int j, int val)
        {
            int k = 0;
            for (int i = val; i > 0; i--)
            {
                if (j == i - 1)
                {
                    k = i * 2;
                    j = j + k;
                }
            }
            Console.WriteLine(k.ToString());
            Console.WriteLine(j.ToString());
        }
        public void print()
        {
            var watch = new Stopwatch();  

            int j, value;
            Console.Write("Input for J :");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input for Value :");

            watch.Start();
            value = Convert.ToInt32(Console.ReadLine());
            compute(j, value);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
