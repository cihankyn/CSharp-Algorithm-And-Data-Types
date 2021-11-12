using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Stack.Abstract;

namespace DataStructures.Stack.Concrete
{
    public class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
        public int Count => list.Count;

        public T Peek()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfStackIsNull();
            return list.GetFirst.Value;
        }

        public T Pop()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfStackIsNull();
            return list.RemoveFirst();
        }

        public void Push(T value)
        {
            // Statics is not good chooice.
            if (value is null)
                Constants.Constant.ThrowIfStackIsNull();

            // We will add front of list
            list.AddFirst(value);
        }
    }
}
