using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class StringSplitOut
    {
        void Split(string name, out string firstNames, out string lastName, out string middleName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
            middleName = name.Substring(5,3);
        }
        public void print()
        {
            var watch = new Stopwatch();           

            string a, b, c, value;
            Console.Write("Input Your Fullname :");
            value = Console.ReadLine();

            watch.Start();
            Split(value, out a, out b,out c);
            Console.WriteLine("Name: {0}",a); // Stevie Ray
            Console.WriteLine("Last Name: {0}", b);
            Console.WriteLine("Middle Name: {0}", c);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
