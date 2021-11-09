using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {

        private T[] InnerList;
        public int Count { get; private set; }
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }
        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
                Add(item);
        }

        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.Count()];
            Count = 0;
            foreach (var item in collection)
                Add(item);
        }

        public void Add(T item)
        {
            if (InnerList.Length == Count)
            {
                IncreaseSizeOfArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        public T Remove(T item)
        {
            if (Count == 0)
            {
                throw new Exception("There is no more item to be removed from the array.");
            }
            T temp = InnerList[Count - 1];
            if (Count > 0)
                Count--;

            if (Count == Capacity / 4)
                DecreaseSizeofArray();
            return temp;
        }

        private void IncreaseSizeOfArray()
        {
            T[] temp = new T[InnerList.Length * 2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }
        private void DecreaseSizeofArray()
        {
            if (Capacity > 2)
            {
                T[] temp = new T[Capacity / 2];
                System.Array.Copy(InnerList, temp, Capacity / 4);
                InnerList = temp;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Count/Capacity : {this.Count}/{this.Capacity}");
            stringBuilder.Append("\n");
            stringBuilder.Append("items : [");
            foreach(var item in InnerList.Take(Count))
            {
                stringBuilder.Append($"{item}, ");
            }
            stringBuilder.Remove(stringBuilder.Length - 2, 1);
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }


        public object Clone()
        {
            return (Array<T>)this.MemberwiseClone();
        }


        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
