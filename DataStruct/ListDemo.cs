using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    public class Customer
    {
        public string name { get; set; }
        public DateTime birthdate { get; set; }
    }
    public class ListDemo
    {
        public static void run()
        {
            List<int> list = new List<int>();
            logCountAndCapacity(list);

            for(int i = 0; i < 16; i++)
            {
                list.Add(i);
                logCountAndCapacity(list);
            }
            for (int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                logCountAndCapacity(list);
            }

            list.TrimExcess();
            logCountAndCapacity(list);

            list.Add(1);
            logCountAndCapacity(list);
        }
        public static void apiMember()
        {
            var list = new List<int>() { 1, 0, 3, 5, 4 };
            list.Sort();

            int indexBinSearch = list.BinarySearch(3);

            list.Reverse();           

            var listOfCustomer = new List<Customer>
            {
                new Customer {birthdate = new DateTime(1983, 08, 12), name = "Elias"},
                new Customer {birthdate = new DateTime(1980, 06, 09), name = "Marina"},
                new Customer {birthdate = new DateTime(2005, 06, 17), name = "Ann"},
            };
            listOfCustomer.Sort((left, right) =>
                {
                    if (left.birthdate > right.birthdate)
                        return 1;
                    if (right.birthdate > left.birthdate)
                        return -1;
                    return 0;
                });
        }
        private static void logCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count={list.Count}. Capacity={list.Capacity}");
        }
    }
}
