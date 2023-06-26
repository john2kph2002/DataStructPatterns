using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.LinkList
{
    class LinkList
    {
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;

        public void addLast(int item)
        {
            var node = new Node(item);

            if(isEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }
        public void addFirst(int item)
        {
            var node = new Node(item);

            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
        }
        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }
        public bool contains(int item)
        {          
            return indexOf(item) != -1;
        }
        public void removeFirst(int item)
        {
            if (isEmpty())
                throw new ArgumentNullException();
            if(first == last)
            {
                first = last = null;
                return;
            }
            var second = first.next;
            first.next = null;
            first = second;
        }
        public void removeLast(int item)
        {
            if (isEmpty())
                throw new ArgumentNullException();
            if (first == last)
            {
                first = last = null;
                return;
            }
            //var current = first;
            //while (current.next == last)
            //    break;
            //current = current.next;
            var previous = getPrevious(last);
            last = previous;
            last.next = null;
        }

        private Node getPrevious(Node node)
        {
            var current = first;
            while(current != null)
            {
                if (current.next == node)
                    return current;
                current = current.next;
            }
            return null;
        }
        private bool isEmpty()
        {
            return first == null;
        }
        public void print()
        {
            addLast(10);
            addLast(20);
            addLast(30);
            removeFirst(20);
            Console.WriteLine(indexOf(30));
        }
    }
}
