using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue.Abstract
{
    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }
}
