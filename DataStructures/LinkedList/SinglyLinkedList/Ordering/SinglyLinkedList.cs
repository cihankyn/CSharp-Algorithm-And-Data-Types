using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataStructures.LinkedList.SinglyLinkedList
{
    public partial class SinglyLinkedList<T> : IEnumerable<T>
    {
        public IList<T> OrderBy<TOrder>(Func<T, TOrder> orderBy,bool setAsDefaultLinkedList=false)
        {
            var newList = new List<T>();
            var current = Head;
            while(current != null)
            {
                newList.Add(current.Value);
                current = current.Next;
            }
            newList = newList.OrderBy(orderBy).ToList();
            if (setAsDefaultLinkedList)
            {
                Head.Value = newList[0];
                current = Head.Next;
                
                int i = 1;
                while (i < newList.Count)
                {
                    current.Value = newList[i];
                    current = current.Next;
                    i++;
                }
            }
            return newList;
        }
        public IList<T> OrderByDescending<TOrder>(Func<T,TOrder> orderByDescending,bool setAsDefaultLinkedList = false)
        {
            var newList = new List<T>();
            var current = Head;
            while (current != null)
            {
                newList.Add(current.Value);
                current = current.Next;
            }
            newList = newList.OrderByDescending(orderByDescending).ToList();
            if (setAsDefaultLinkedList)
            {
                Head.Value = newList[0];
                current = Head.Next;
                int i = 1;
                while (i < newList.Count)
                {
                    //You can check if current not null
                    current.Value = newList[i];
                    current = current.Next;
                    i++;
                }
            }

            return newList;
        }
    }

}
