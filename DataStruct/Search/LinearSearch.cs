using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.Search
{
    class LinearSearch
    {
        public int linearSearch(int[] linearArray, int length, int searchKey)
        {
            int index = 0;
            while (index < length)
            {
                if(linearArray[index] == searchKey)
                {
                    return index;
                }
                index ++;
            }
            return -1;
        }
        public void print()
        {
            int[] arr;
            int x = 0, searchKey;
            Console.Write("\n\nLinear Search:\n");
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
            var indexAt = linearSearch(arr, x, searchKey);
            Console.WriteLine("Result is at index: {0}", indexAt);
        }
    }
}
