using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class RemoveDuplicateString
    {
        string[] removeDuplicates(string[] inputArr, string[] duplicateVal)
        {
            List<string> result = new List<string>();

            // create a list object from string array 
            List<string> inputList = new List<string>(inputArr);

            foreach (string s in duplicateVal)
            {
                // remove all the items that match the value of s
                inputList.RemoveAll(p => p == s);

                // remember which item is completely removed; so one instance can be added back.
                result.Add(s);
            }

            // now add those unique value back to the list 
            foreach (string r in result)
            {
                inputList.Add(r);
            }

            return inputList.ToArray();
        }
        public void print()
        {
            var watch = new Stopwatch();
            Console.Write("\n\nRemove Duplicates :\n");
            Console.Write("---------------------\n");
            string[] array1;
            string[] array2;
            Console.Write("Enter values for the first array : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            array1 = new string[input1];
            for (int i = 0; i < input1; i++)
            {
                array1[i] = Console.ReadLine();
            }

            Console.Write("Enter values for the second array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            array2 = new string[input2];
            for (int i = 0; i < input2; i++)
            {
                array2[i] = Console.ReadLine();
            }
            Console.Write("Unique: ");
            watch.Start();
            string[] unique = removeDuplicates(array1, array2);
            foreach (var uni in unique)
            {
                Console.Write(" {0}", uni);
            }
            Console.WriteLine();
            //Console.WriteLine($"Original: {String.Join(",", cities)}");

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
