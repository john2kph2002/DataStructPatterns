using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStruct.LinkList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public GenericNode<T> Head { get; private set; }
        public GenericNode<T> Tail { get; private set; }

        public int Count { get; set; }
        public void AddFirst(T value)
        {
            AddFirst(new GenericNode<T>(value));
        }
        private void AddFirst(GenericNode<T> node)
        {
            //save current head
            GenericNode<T> tmp = Head;

            Head = node;

            //shift the former head
            Head.Next = tmp;

            Count++;

            if(Count == 1)
            {
                Tail = Head;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new GenericNode<T>(value));
        }

        private void AddLast(GenericNode<T> node)
        {
            if (IsEmpty)
                Head = node;
            else
                Tail.Next = node;

            Tail = node;

            Count++;
        }
        public bool IsEmpty => Count == 0;
        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next;
            if (Count == 1)
                Tail = null;

            Count--;
        }
        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if(Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                var current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }
            Count--;
        }
        public IEnumerator<T> GetEnumerator()
        {
            GenericNode<T> current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
