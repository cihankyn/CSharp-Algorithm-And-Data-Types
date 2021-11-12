using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.DoublyLinkedList
{
    public partial class DoublyLinkedList<T>:IEnumerable
    {
        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current is not null)
            {
                list.Add(current);
                current = current.Next;
            }

            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }
    }
}
