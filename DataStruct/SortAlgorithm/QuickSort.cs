using System;
using System.Diagnostics;

namespace DataStruct.SortAlgorithm
{
    public class QuickSort
    {
        public static void quickRec(int[] array) //O(n log(n)) worst O(n²)  linearithmic Stable
        {
            int firstIndex = 0;
            int lastIndex = array.Length - 1;
            quickSort(firstIndex, lastIndex);
            void quickSort(int firstIndex, int lastIndex)
            {
                if (firstIndex < lastIndex)
                {
                    int pi = partition(array, firstIndex, lastIndex);
                    quickSort(firstIndex, pi - 1);
                    quickSort(pi + 1, lastIndex);
                }
            }
        }
        private static int partition(int[] array, int low, int high)
        {
            int pivot = array[low];
            int i = low + 1; 
            int j = high;
            do
            {
                while(i <= j && array[i] <= pivot)
                    i = i + 1;
                while (i <= j && array[j] > pivot)
                    j = j - 1;
                if (i <= j)
                    swap(array, i, j);

            } while (i < j);
            swap(array, low, j);
            return j;
        }
        private static void swap(int[] array, int i, int j)
        {
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
            Console.Write("\n\nQuick Sort:\n");
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
            quickRec(arr);
            Console.Write("Sorted elements : ");
            display(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
