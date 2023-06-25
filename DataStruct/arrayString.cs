using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataStruct
{
    public class arrayString
    {
        private static string[] stringSplit(string str)
        {
            string[] strs = str.Split(' ').OrderBy(x => x).ThenBy(x => x.Length).ToArray();
            return strs;
        }
        public static void sortStringArray()
        {
            string[] arr = new string[] {
                 "Indian",
                 "Moroccon",
                 "American",
              };
            var sort = from a in arr
                       orderby a
                       select a;

            foreach (string res in sort)
            {
                Console.WriteLine(res);
            }
        }
        public static void sortStringList()
        {
            var test = new List<string> { "abb", "abacaba", "bcd", "edr", "output", "abacabaabbabcder" };
            var lexicographical = from s in test
                                  orderby s.Length descending, s
                                  select s;
            foreach (string res in lexicographical)
            {
                Console.WriteLine(res);
            }
        }
        public static void arrayContains()
        {
            string[] dict = new string[] { "this", "th", "is", "famous", "Word", "break", "b", "r", "e", "a", "k", "br", "bre", "brea", "ak", "problem" };
            string a = "Wordbreakproblem";
            foreach (string x in dict)
            {
                string b = string.Empty;
                if (a.Contains(x))
                {
                    b = x;
                    if (a == x)
                    {
                        Console.Write(x);
                    }
                }
                Console.Write(b);
            }
            Console.WriteLine();
        }
        public static void print()
        {
            var watch = new Stopwatch();
            watch.Start();

            Console.Write("\n\nSplit String Array:\n");
            Console.Write("---------------------\n");
            Console.Write("Enter String values : ");
            string str = Console.ReadLine();
            var strs = stringSplit(str);
            foreach (string x in strs)
            {
                Console.Write("{0}", x);
            }
            Console.WriteLine("String Array with Split Elements:");

            //watch.Stop();
            //Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
