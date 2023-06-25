using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    class Arrays
    {
        private int[] items;
        private int count;
        public Arrays(int length)
        {
            items = new int[length];
        }
        public void insert(int item)
        {
            if (count == items.Length)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
            items[count++] = item;
        }
        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentException();
            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
        public int indexOf(int item)
        {
            //int a;
            for (int i = 0; i < count; i++)
            {
                //a = items[i];
                //if (item == i)
                //    return a;
                if (items[i] == item)
                    return i;
            }
            return -1;
        }
        public void printArray()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void print()
        {
            insert(10);
            insert(20);
            insert(30);
            insert(40);
            insert(50);
            insert(60);
            //removeAt(3);
            Console.WriteLine(indexOf(20));
            printArray();
        }
    }     
}
