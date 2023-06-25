using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class CrushWhileLoop
    {
        private void crash(int val)
        {
            display(val);
        }
        private int display(int cnt)
        {
            if (cnt != 0)
            {
                Console.WriteLine(cnt);
            }
            display(cnt--);
            return 0;
        }
        public void print()
        {
            var watch = new Stopwatch();
            watch.Start();

            int value;
            Console.Write("Input a vaule to crash :");
            value = Convert.ToInt32(Console.ReadLine());
            crash(value);

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed:g} ms");
        }
    }
}
