using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.SortAlgorithm
{
    public class MergeSort
    {
        public static void mergeSortRec(int[] array) //O(n log(n)) best, worst linearithmic Stable
        {
            int firstIndex = 0;
            int lastIndex = array.Length - 1;
            mergeSort(firstIndex, lastIndex);      
            void mergeSort(int firstIndex, int lastIndex)
            {
                if (firstIndex < lastIndex)
                {
                    int middle = (firstIndex + lastIndex) / 2;
                    mergeSort(firstIndex, middle);
                    mergeSort(middle + 1, lastIndex);
                    merge(array, firstIndex, middle, lastIndex);
                }
            }          
        }
        private static void merge(int[] array, int firstIndex, int middle, int lastIndex) //O(n1 + n2)
        {
            if (array[middle] <= array[middle + 1])
                return;
            int i = firstIndex; int j = middle + 1; int k = firstIndex;

            int[] bArray = new int[lastIndex + 1];
            while (i <= middle && j <= lastIndex)
            {
                if (array[i] < array[j])
                {
                    bArray[k] = array[i];
                    i = i + 1;
                }
                else
                {
                    bArray[k] = array[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while (i <= middle)
            {
                bArray[k] = array[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= lastIndex)
            {
                bArray[k] = array[j];
                j = j + 1;
                k = k + 1;
            }
            for (int x = firstIndex; x < lastIndex + 1; x++)
            {
                array[x] = bArray[x];
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
            Console.Write("\n\nMerge Sort:\n");
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
            mergeSortRec(arr);
            Console.Write("Sorted elements : ");
            display(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
