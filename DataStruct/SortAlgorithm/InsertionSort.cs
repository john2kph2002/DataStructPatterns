using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.SortAlgorithm
{
    public class InsertionSort
    {
        public static void insertion(int[] array) //O(n²) worst Quadratic Stable, best O(n) 
        {
            int arrSize = array.Length;
            for (int i = 1; i < arrSize; i++)
            {
                int temp = array[i];
                int position = i;
                //for (position = i; position > 0 && array[position - 1] > temp; position--)
                //{
                //    array[position] = array[position - 1];
                //}
                while (position > 0 && array[position - 1] > temp)
                {
                    array[position] = array[position - 1];
                    position--;
                }
                array[position] = temp;
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
            Console.Write("\n\nInsertion Sort:\n");
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
            insertion(arr);
            Console.Write("Sorted elements : ");
            display(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
