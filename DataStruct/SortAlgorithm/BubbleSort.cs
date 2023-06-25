using System;
using System.Diagnostics;

namespace DataStruct.SortAlgorithm
{
    public class BubbleSort
    {
        public static void bubble(int[] array) //n(n-1)/2 = O(n²) worst Stable,  best case = O(n)
        {
            int lastIndex = array.Length - 1;
            for (int pass = lastIndex; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        swap(array, i, i + 1);
                    }
                }
            }
        }
        private static void swap(int[] array, int i, int j)
        {
            if (i == j)
                return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
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
            Console.Write("\n\nBubble Sort:\n");
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
            bubble(arr);
            Console.Write("Sorted elements : ");
            display(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
