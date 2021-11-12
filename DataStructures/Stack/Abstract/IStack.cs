namespace DataStructures.Stack.Abstract
{
    public interface IStack<T>
    {
        void Push(T value);
        T Peek();
        T Pop();
        int Count { get; }
    }
}
