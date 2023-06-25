using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.SortAlgorithm
{
    public class ShellSort
    {
        public static void shell(int[] array) //log2(n) =  O(n log(n)) best, worst O(n²) Unstable
        {
            int arrSize = array.Length;
            int gap = arrSize / 2;
            //for (int gap = length / 2; gap > 0; gap = gap / 2)
            //{
            //    for (int i = gap; i < arrSize; i++)
            //    {
            //        int temp = shellArray[i];
            //        int j;
            //        for (j = i - gap; j >= 0 && shellArray[j] > temp; j = j - gap)
            //        {
            //            shellArray[j + gap] = shellArray[j];
            //        }
            //        shellArray[j + gap] = temp;
            //    }
            //}
            while (gap > 0)
            {
                int i = gap;
                while (i < arrSize)
                {
                    int temp = array[i];
                    int j = i - gap;
                    while (j >= 0 && array[j] > temp)
                    {
                        array[j + gap] = array[j];
                        j = j - gap;
                    }
                    array[j + gap] = temp;
                    i++;
                }
                gap = gap / 2;
            }
        }
        private void display(int[] array)
        {
            int arrSize = array.Length;
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void print()
        {
            var watch = new Stopwatch();
           
            //int[] arr;
            int[] arr = { 2, 1, 2, 5, 3 };
            int x;
            Console.Write("\n\nShell Sort:\n");
            Console.Write("---------------------\n");
            Console.Write("Input how many elements : ");

            watch.Start();
            //x = Convert.ToInt32(Console.ReadLine());
            //arr = new int[x];
            //for (int i = 0; i < x; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            Console.WriteLine("");
            shell(arr);
            Console.Write("Sorted elements : ");
            display(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
