using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class Equilibrium
    {
        int equilibrium(int[] arr)
        {
            int arrLength = arr.Length;
            int i, j;
            int leftSum, rightSum;
            for (i = 0; i < arrLength; ++i)
            {
                leftSum = 0;
                rightSum = 0;
                for (j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (j = i + 1; j < arrLength; j++)
                {
                    rightSum += arr[j];
                }
                if (leftSum == rightSum)
                    return i;
            }
            return -1;
        }
        public void print()
        {
            var watch = new Stopwatch();

            int[] arr;
            int x;
            Console.Write("\n\nEquilibrium Sort:\n");
            Console.Write("---------------------\n");
            Console.Write("Input how many elements : ");
            x = Convert.ToInt32(Console.ReadLine());
            arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            watch.Start();
            int result = equilibrium(arr);
            Console.WriteLine("Equilibrium is {{ {0} }}", result);          

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
