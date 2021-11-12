using System;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public partial class DoublyLinkedList<T>
    {

        public void AddFirst(T value)
        {
            var node = new DoublyLinkedListNode<T>(value);
            node.Prev = null;
            node.Next = null;
            if (IsHeadNull)
            {
                Head = node;
                Tail = node;
                return;
            }
            node.Next = Head;
            Head.Prev = node;
            Head = node;
        }
        public void AddLast(T value)
        {
            var node = new DoublyLinkedListNode<T>(value);
            node.Prev = null;
            node.Next = null;
            if (IsHeadNull)
            {
                Head = node;
                Tail = node;
                return;
            }
            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
        }

        public void AddAfter(DoublyLinkedListNode<T> afterNode, T value)
        {
            ThrowIfNull(afterNode);

            var node = new DoublyLinkedListNode<T>(value);
            node.Prev = null;
            node.Next = null;
            if (IsHeadNull)
            {
                Head = node;
                Tail = node;
                return;
            }
            var temp = Head;
            bool isThere = false;
            while (temp is not null)
            {
                if (temp == afterNode)
                {
                    isThere = true;
                    break;
                }
                temp = temp.Next;
            }
            if (isThere)//if afternode found
            {
                if (temp == Tail)
                    Tail = node;
                if (temp.Next is not null)
                    temp.Next.Prev = node;
                node.Next = temp.Next;
                node.Prev = temp;
                temp.Next = node;
            }
            else
            {
                //if not found / add last item
                node.Prev = Tail;
                Tail.Next = node;
                Tail = node;
            }

        }
        public void AddBefore(DoublyLinkedListNode<T> beforeNode, T value)
        {
            ThrowIfNull(beforeNode);

            var node = new DoublyLinkedListNode<T>(value);
            node.Prev = null;
            node.Next = null;
            if (IsHeadNull)
            {
                Head = node;
                Tail = node;
                return;
            }
            if (Head == beforeNode)
            {
                node.Next = Head;
                Head.Prev = node;
                Head = node;
                return;
            }
            var temp = Head;
            bool isThere = false;
            while (temp is not null)
            {
                if (temp.Next == beforeNode)
                {
                    isThere = true;
                    break;
                }
                temp = temp.Next;
            }
            if (isThere)
            {
                node.Prev = temp;
                node.Next = temp.Next;
                node.Next.Prev = node;
                temp.Next = node;
            }
            else
            {
                // if not found we'll add as first element(head)
                node.Next = Head;
                Head.Prev = node;
                Head = node;
            }
        }
    }
}
