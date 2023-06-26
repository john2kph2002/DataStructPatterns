
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.LinkList
{
    public class GenericDoublyLinkedNode<T>
    {
        public GenericDoublyLinkedNode<T> Next { get; internal set; }
        public GenericDoublyLinkedNode<T> Previous { get; internal set; }

        public T Value { get; set; }

        public GenericDoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
}
