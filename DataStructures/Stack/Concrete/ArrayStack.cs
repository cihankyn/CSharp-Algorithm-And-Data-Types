using DataStructures.Stack.Abstract;
using System;
using System.Collections.Generic;

namespace DataStructures.Stack.Concrete
{
    public class ArrayStack<T> : IStack<T>
    {
        private readonly List<T> list = new List<T>();
        public int Count => list.Count;

        public T Peek()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfStackIsNull();

            return list[list.Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfStackIsNull();

            var temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return temp;
        }

        public void Push(T value)
        {
            // Static is not best practices, But I used too.
            Constants.Constant.ThrowIfNull(value, Constants.Constant.NullParameterMessage);
            list.Add(value);
        }
    }
}
