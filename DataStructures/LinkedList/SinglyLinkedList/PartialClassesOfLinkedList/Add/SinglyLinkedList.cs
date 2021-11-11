using DataStructures.LinkedList.SinglyLinkedList.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList.Concrete
{
    public partial class SinglyLinkedList<T> : IEnumerable<T>
    {
        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }
        public void AddLast(T value)
        {
            if (Head is null)
            {
                Head = new SinglyLinkedListNode<T>(value);
                return;
            }
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new SinglyLinkedListNode<T>(value);
        }
        public void AddRange(T[] values)
        {
            foreach (var item in values)
                this.AddLast(item);
        }
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                this.AddLast(item);
        }
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
                throw new ArgumentNullException();
            if (IsHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("The node reference not found");
        }
        public void AddAfter(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> value)
        {
            if (node == null)
                throw new ArgumentNullException();
            if (IsHeadNull)
            {
                Head = value;
                return;
            }
            var current = Head;
            while (current != null)
            {
                if (current == value)
                {
                    value.Next = current.Next;
                    current.Next = value;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("The node reference not found");
        }
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node is null)
                throw new ArgumentNullException();
            if (IsHeadNull)
            {
                Head = new SinglyLinkedListNode<T>(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            if (Head.Equals(node))
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }
            var current = Head;
            while (current != null)
            {
                if (current.Next.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("The node reference not found");
        }
        public void AddBefore(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> value)
        {
            if (node is null)
                throw new ArgumentNullException();
            if (IsHeadNull)
            {
                Head = value;
                return;
            }
            if (Head == node)
            {
                value.Next = Head;
                Head = value;
                return;
            }
            var current = Head;
            while (current != null)
            {
                if (current.Next == node)
                {
                    value.Next = current.Next;
                    current.Next = value;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("The node reference not found");
        }

    }
}
