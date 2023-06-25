using System;
using System.Diagnostics;

namespace DataStruct.SortAlgorithm
{
    public class SelectionSort
    {
        public static void selection(int[] array) //O(n²) worst Quadratic  Unstable
        {
            int lastIndex = array.Length - 1;
            for (int i = lastIndex; i > 0; i--)
            {
                int position = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(array[j] > array[position])
                    {
                        position = j;
                    }                    
                    swap(array, i, position);
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
            for (int i = 0; i< arrSize; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public void print()
        {
            var watch = new Stopwatch();
                 
            //int[] arr;
            int x;
            int[] arr = { 2, 1, 2, 5, 3 };
            Console.Write("\n\nSelection Sort:\n");
            Console.Write("---------------------\n");
            Console.Write("Input how many elements : ");

            watch.Start();
            //x = Convert.ToInt32(Console.ReadLine());
            //arr[] = new int[x];
            //for (int i = 0; i < x; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            Console.WriteLine("");
            selection(arr);
            Console.Write("Sorted elements : ");
            display(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
