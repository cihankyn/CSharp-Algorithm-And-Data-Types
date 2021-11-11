using DataStructures.LinkedList.SinglyLinkedList.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList.Concrete
{
    public partial class SinglyLinkedList<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


    }
}
