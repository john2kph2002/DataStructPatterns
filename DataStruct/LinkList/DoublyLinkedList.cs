using System;

namespace DataStruct.LinkList
{
    public class DoublyLinkedList<T>
    {
        public GenericDoublyLinkedNode<T> Head { get; private set; }
        public GenericDoublyLinkedNode<T> Tail { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new GenericDoublyLinkedNode<T>(value));
        }

        private void AddFirst(GenericDoublyLinkedNode<T> node)
        {
            //save off the Head
            GenericDoublyLinkedNode<T> temp = Head;
            //point Head to node
            Head = node;

            //insert the rest of the list after the head
            Head.Next = temp;

            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                //before: 1(head) <-------> 5 <-> 7 -> null
                //after: 3(head) <-------> 1 <-> 5 <-> 7 -> null

                //update "previous" ref of the former head
                temp.Previous = Head;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            AddLast(new GenericDoublyLinkedNode<T>(value));
        }       
        private void AddLast(GenericDoublyLinkedNode<T> node)
        {
           if(IsEmpty)
            {
                Head = node;
                Tail = node;
            }
           else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
            Count++;
        }
        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            //shift head
            Head = Head.Next;

            Count--;

            if (IsEmpty)
                Tail = null;
            else
                Head.Previous = null;
        }
        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            
            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null; //null the last node
                Tail = Tail.Previous; //shift the Tail
            }

            Count--;
        }
        public int Count{ get; private set;}
        public bool IsEmpty => Count == 0;
    }
}
