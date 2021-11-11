using DataStructures.LinkedList.SinglyLinkedList.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList.Concrete
{
    public partial class SinglyLinkedList<T> : IEnumerable<T>
    {
        public void Remove(SinglyLinkedListNode<T> value)
        {
            if (value is null)
                throw new ArgumentNullException(null,"Value cannot be null");

            if (IsHeadNull)
            {
                throw new ArgumentNullException(null, "The Head element is null");
            }

            var current = Head;
            var prev = current;
            if (Head == value)
            {
                Head = Head.Next;
                return;
            }

            while (current != null)
            {

                if (current.Equals(value))
                {
                    prev.Next = current.Next;
                    break;
                }
                prev = current;
                current = current.Next;

            }
            current = null;
            return;
        }
        public void Remove(T value)
        {
            if (value is null)
                throw new ArgumentNullException(null, "Value cannot be null...");
            if (IsHeadNull)
                throw new ArgumentNullException(null, "The Head cannot be null");
            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                return;
            }
            SinglyLinkedListNode<T> prev = null;
            SinglyLinkedListNode<T> current = Head;
            do
            {
                if (current.Value.Equals(value))
                {
                    prev.Next = current.Next;
                    break;
                }
                prev = current;
                current = current.Next;
            } while (current != null);
            throw new ArgumentException("The value could not be found");
        }
        public T RemoveFirst()
        {
            if (Head is null)
                throw new ArgumentNullException(null,"The Head/Root is null.So, the first element could not be removed.");
            var value = Head.Value;
            Head = Head.Next;
            return value;
        }
        public T RemoveLast()
        {
            var current = Head;
            if (current is null)
                throw new ArgumentNullException(null, "Head is null");
            if (current.Next is null)
            {
                Head = null;
            }
            //else
            //{
            var prev = current;
                while (current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                }
                prev.Next = null;
            //}
            return current.Value;

        }

    }
}
