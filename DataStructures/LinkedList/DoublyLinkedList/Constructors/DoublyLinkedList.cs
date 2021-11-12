using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public partial class DoublyLinkedList<T>:IEnumerable
    {
        // First Node
        public DoublyLinkedListNode<T> Head { get; set; }

        // Last Node
        public DoublyLinkedListNode<T> Tail { get; set; }
        public bool IsHeadNull => Head is null;
        public bool IsTailNull => Tail is null;
        public DoublyLinkedListNode<T> GetFirst => Head;
        public DoublyLinkedListNode<T> GetLast => Tail;
        public int Count
        {
            get
            {
                if (IsHeadNull)
                    return 0;
                int starter = 0;
                var current = Head;
                while(current is not null)
                {
                    starter++;
                    current = current.Next;
                }
                return starter;
            }
        }
        // Constructors
        public DoublyLinkedList()
        {

        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            // add each item front of other
            foreach (var item in collection)
                this.AddFirst(item);
        }
        public DoublyLinkedList(params T[] arr)
        {
            foreach (var item in arr)
                this.AddFirst(item);
        }

        private void ThrowIfNull(DoublyLinkedListNode<T> node)
        {
            if (node is null)
                throw new ArgumentNullException(null, "Node cannot be null");
        }

    }
}
