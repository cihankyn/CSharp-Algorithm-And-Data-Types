using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public partial class DoublyLinkedList<T> : IEnumerable
    {
        public T RemoveFirst()
        {
            ThrowIfNull(Head);
            var temp = Head.Value;
            if (Head==Tail)
            {
                Head = Tail = null;

            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            return temp;
        }
        public T RemoveLast()
        {
            ThrowIfNull(Tail);
            var temp = Tail.Value;
            if(Head==Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            return temp;
        }
        public T Remove(DoublyLinkedListNode<T> node)
        {
            ThrowIfNull(node);
            ThrowIfNull(Head);
            if (Head == Tail)
                return RemoveFirst();
            if (Head == node)
                return RemoveFirst();
            if (Tail == node)
                return RemoveLast();
            var temp = Head.Next;
            bool isThere = false;
            while (temp is not null)
            {
                if (temp == node)
                {
                    isThere = true;
                    break;
                }
                temp = temp.Next;
            }
            if (isThere)
            {
                temp.Prev.Next = temp.Next;
                temp.Next.Prev = temp.Prev;
                return temp.Value;
            }
            throw new Exception($"{node.Value} not found");
        }
    }
}
