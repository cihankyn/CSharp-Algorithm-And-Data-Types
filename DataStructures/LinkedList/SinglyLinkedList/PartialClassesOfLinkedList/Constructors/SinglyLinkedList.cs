using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList.Concrete
{
    public partial class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        private bool IsHeadNull => Head is null;
        public int Count
        {
            get
            {
                int start = 0;
                var current = Head;
                while (current is not null)
                {
                    start++;
                    current = current.Next;
                }
                return start;
            }
        }
        public SinglyLinkedListNode<T> GetFirst => Head;

        public SinglyLinkedListNode<T> GetLast
        {
            get
            {
                var temp = Head;
                while (temp.Next is not null)
                    temp = temp.Next;
                return temp;
            }
        }

        #region Constructors
        public SinglyLinkedList()
        {

        }
        public SinglyLinkedList(T value)
        {
            Head = new SinglyLinkedListNode<T>(value);
        }
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                this.AddLast(item);
        }
        public SinglyLinkedList(params T[] arr)
        {
            foreach (var item in arr)
                this.AddLast(item);
        }
        #endregion

        public SinglyLinkedListNode<T> Find(T value)
        {
            SinglyLinkedListNode<T> result = null;
            if (IsHeadNull)
            {
                throw new Exception("List is null");
            }
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    result = current;
                    return result;
                }
                current = current.Next;
            }
            return result;
        }


    }
}
