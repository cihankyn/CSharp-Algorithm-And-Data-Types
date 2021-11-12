using DataStructures.Queue.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue.Concrete
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> _list = new List<T>();
        //public int Count => _list.Count;
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count <= 0)
                Constants.Constant.ThrowIfQueueIsNull();

            var temp = _list[0];
            _list.RemoveAt(0);
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            Constants.Constant.ThrowIfNull(value, Constants.Constant.NullParameterMessage);
            Count++;
            _list.Add(value);
        }

        public T Peek()
        {
            if (Count <= 0)
                Constants.Constant.ThrowIfQueueIsNull();
            return _list[0];
        }
    }
}
