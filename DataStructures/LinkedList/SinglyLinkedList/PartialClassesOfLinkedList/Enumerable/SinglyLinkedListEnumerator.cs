using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedList.SinglyLinkedList.Concrete
{
    internal class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head;
        private SinglyLinkedListNode<T> _current;
        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            Head = head;
            _current = null;
        }
        public T Current => _current.Value;
        object IEnumerator.Current => Current;


        public bool MoveNext()
        {
            if (_current is null)
                _current = Head;
            else
                _current = _current.Next;
            return _current is not null; //C# 9.0 see:DataSctuctures.csproj
        }

        public void Reset()
        {
            _current = null;
        }
        public void Dispose()
        {
            Head = null;
        }
    }
}