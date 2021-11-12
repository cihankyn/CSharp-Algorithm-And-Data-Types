using DataStructures.Stack.Abstract;

namespace DataStructures.Stack.Concrete
{
    public partial class Stack<T>
    {
        private readonly IStack<T> _stack;
        public int Count => _stack.Count;

        public Stack(IStack<T> stack)
        {
            _stack = stack;
        }

        public T Pop() => _stack.Pop();
        public T Peek() => _stack.Peek();
        public void Push(T value) => _stack.Push(value);

    }
}
