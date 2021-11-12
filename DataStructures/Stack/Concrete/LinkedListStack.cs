using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Stack.Abstract;

namespace DataStructures.Stack.Concrete
{
    public class LinkedListStack<T> : IStack<T>
    {
        //We will use SinglyLinkedList on this scenario.You can find this definition under of DataStructures.SinglyLinkedList
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public int Count => _list.Count;

        public T Peek()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfStackIsNull();
            return _list.GetFirst.Value;
        }

        public T Pop()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfStackIsNull();
            return _list.RemoveFirst();
        }

        public void Push(T value)
        {
            // Statics is not good chooice.
            if (value is null)
                Constants.Constant.ThrowIfStackIsNull();

            // We will add front of _list
            _list.AddFirst(value);
        }
    }
}
