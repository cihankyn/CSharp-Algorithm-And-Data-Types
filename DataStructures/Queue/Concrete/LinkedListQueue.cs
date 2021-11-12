using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.Queue.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue.Concrete
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        //We will use DoublyLinkedList on this scenario.You can find this definition under of DataStructures.LinkedList
        private readonly DoublyLinkedList<T> _list = new DoublyLinkedList<T>();
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfQueueIsNull();
            Count--;
            return _list.RemoveFirst();
        }

        public void EnQueue(T value)
        {
            Constants.Constant.ThrowIfNull(value, Constants.Constant.NullParameterMessage);
            _list.AddLast(value);
            Count++;            
        }

        public T Peek()
        {
            if (Count == 0)
                Constants.Constant.ThrowIfQueueIsNull();
            // You can use both of these for return
            return _list.GetFirst.Value;
            //return _list.Head.Value;
        }

        //Short use for Peek
        //public T Peek => Count == 0 ? throw new Exception("Queue is null...") : _list.GetFirst.Value;
    }
}
