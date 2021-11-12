using DataStructures.Queue.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue.Concrete
{
    public class Queue<T>
    {
        private readonly IQueue<T> _queue;

        public Queue(IQueue<T> queue)
        {
            _queue = queue;
        }

        public int Count => _queue.Count;
        public void EnQueue(T value) => _queue.EnQueue(value);
        public T DeQueue() => _queue.DeQueue();
        public T Peek() => _queue.Peek();
    }
}
