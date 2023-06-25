using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class ReverseArrayNumber
    {
        public List<int> reverse(int[] array)
        {           
            var elements = array.Reverse().Select(x => x).ToList();
            return elements;           
        }
        public int[] reverseD(int[] array)
        {
            int n = array.Length;
            int size = n - 1;
            int[] rev = new int[n];
            for (int i = size; i >= 0; i--)
            {
                rev[n-1-i] = i + 1;
            }
            Console.WriteLine("");
            return rev;
        }
        public void print()
        {
            int[] arr;
            int x = 0;
            Console.Write("\n\nREVERSE:\n");
            Console.Write("---------------------\n");
            Console.Write("Input values to reverse : ");
            x = Convert.ToInt32(Console.ReadLine());
            arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //var print = reverse(arr);
            var printD = reverseD(arr);
            Console.WriteLine("REVERSE : {0}", string.Join(" ", printD));
            //foreach (var a in print)
            //{
            //    Console.WriteLine("REVERSE : {0}  ", a);
            //}
        }
    }
}
