using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    class BinarySearch
    {
        public int binarySearchIterative(int[] binaryArray, int length, int searchKey)//O(logn)
        {
            int left = 0;
            int right = length - 1;
            while(left <= right)
            {
                //var middle = Convert.ToInt32(Math.Floor((Convert.ToDouble(left) + Convert.ToDouble(right)) / 2));
                int middle = (left + right) / 2;
                if (searchKey == binaryArray[middle])
                {
                    return middle;
                }
                else if(searchKey < binaryArray[middle])
                {
                    right = middle - 1;
                }
                else if (searchKey > binaryArray[middle])
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
        public int binarySearchRecursive(int[] binaryArray, int searchKey, int left, int right) //O(logn)
        {
            if (left > right)
            {
                return -1;
            }
            else
            {
                int middle = (left + right) / 2;
                if (searchKey == binaryArray[middle])
                {
                    return middle;
                }
                else if (searchKey < binaryArray[middle])
                {
                    return binarySearchRecursive(binaryArray,searchKey,left, middle - 1);
                }
                else if (searchKey > binaryArray[middle])
                {
                    return binarySearchRecursive(binaryArray, searchKey, middle + 1, right);
                }
            }
            return -1;
        }
        public void print()
        {
            int[] arr;
            int x, searchKey;
            Console.Write("\n\nBinary Search:\n");
            Console.Write("---------------------\n");
            Console.Write("Input how many elements : ");
            x = Convert.ToInt32(Console.ReadLine());
            arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input what value to search : ");
            searchKey = Convert.ToInt32(Console.ReadLine());
            var indexAt = binarySearchIterative(arr, x, searchKey);
            //var indexAt = binarySearchRecursive(arr, searchKey, 0, x -1);
            Console.WriteLine("Result is at index: {0}", indexAt);
        }
    }
}
