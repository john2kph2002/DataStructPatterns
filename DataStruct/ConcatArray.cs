using System;
using System.Diagnostics;
using System.Linq;

namespace DataStruct
{
    public class ConcatArray
    {
        public int[] concatLinq(int[] array1,int[]array2)
        {
            return array1.Concat(array2)
                .OrderByDescending(x => x)
                .ToArray();
        }
        public int[] concat(int[] array1, int[] array2)
        {
            int count1 = array1.Length;
            int count2 = array2.Length;
            int[] arrayResult = new int[count1 + count2];

            int a = 0, b = 0;   // indexes in origin arrays
            int i = 0;          // index in result array

            // join
            while (a < count1 && b < count2)
            {
                if (array1[a] <= array2[b])
                {
                    // element in first array at current index 'a'
                    // is less or equals to element in second array at index 'b'
                    arrayResult[i++] = array1[a++];
                }
                else
                {
                    arrayResult[i++] = array2[b++];
                }
            }

            // tail
            if (a < count1)
            {
                // fill tail from first array
                for (int j = a; j < count1; j++)
                {
                    arrayResult[i++] = array1[j];
                }
            }
            else
            {
                // fill tail from second array
                for (int j = b; j < count2; j++)
                {
                    arrayResult[i++] = array2[j];
                }
            }

            return arrayResult;
        }

        public void print()
        {
            var watch = new Stopwatch();
            watch.Start();

            Console.Write("\n\nConcat Array:\n");
            Console.Write("---------------------\n");
            int[] array1;
            int[] array2;
            Console.Write("Enter values for the first array : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            array1 = new int[input1];
            for (int i = 0; i < input1; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter values for the second array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            array2 = new int[input2];
            for (int i = 0; i < input2; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }           
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("{0} ", array1[i]);
            }
            Console.WriteLine("Elements in the first array:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("{0} ", array2[i]);
            }
            Console.WriteLine("Elements in the second array:");
            var concatArray = concat(array1, array2);
            foreach (int arrays in concatArray)
            {
                Console.Write("{0} ", arrays);
            }
            Console.WriteLine("Concatenated Array Elements:");

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
