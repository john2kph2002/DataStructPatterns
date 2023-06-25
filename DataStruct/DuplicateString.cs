using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStruct
{
    public class DuplicateString
    {
        string[] duplicate(string[] arr)
        {
            List<string> duplicates = new List<string>();
            string[] sortedAr = arr;

            Array.Sort(sortedAr);
            for (int i = 0; i < sortedAr.Length - 1; i++)
            {
                var sortedArPlus1 = sortedAr[i + 1];
                var sortedArs = sortedAr[i];
                if (sortedArs == sortedArPlus1)
                {
                    object _dv = duplicates.Find(s => s.Contains(sortedAr[i]));
                    if (_dv == null)
                    {
                        duplicates.Add(sortedAr[i]);
                    }
                }
            }

            return duplicates.ToArray();
        }
        public void print()
        {
            var watch = new Stopwatch();
            string[] arr;
            int x;
            Console.Write("\n\nDuplicates :\n");
            Console.Write("---------------------\n");
            Console.Write("Input how many string elements : ");
            x = Convert.ToInt32(Console.ReadLine());
            arr = new string[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.Write("Duplicates: ");
            watch.Start();
            string[] duplicates = duplicate(arr);
            foreach(var dup in duplicates)
            {
                Console.Write(" {0}",dup);
            }
            Console.WriteLine();
            //Console.WriteLine($"Original: {String.Join(",", cities)}");

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
