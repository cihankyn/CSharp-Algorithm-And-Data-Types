using DataStructures.LinkedList.SinglyLinkedList.Concrete;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apps
{
    class Program
    {

        static void Main(string[] args)
        {
            //ArrayOperations.Start();
            OneWayListOperations.Start();
            Console.ReadKey();
        }


    }
    class OneWayListOperations
    {
        public static SinglyLinkedList<Product> linkedList = new SinglyLinkedList<Product>();
        public static void Start()
        {
            //ConstuctorOverloads();
            //AddLast();
            //AddFirst();
            //AddAfter();
            //AddBefore();
            //Remove();
            //RemoveFirst();
            //RemoveLast();
            //GetEnumerator();
            //SendCustomLinkedListTOList();
            //Find();
            //LinqExpressions();
            //Order();
            //OrderByDescending();
            //GetOperations();
            //Print();
        }
        public static void ConstuctorOverloads()
        {
            //linkedList = new SinglyLinkedList<Product>(Product.CreateFakeDatas(20));

            //var arr = Product.CreateFakeDatas(20).ToArray();
            //linkedList = new SinglyLinkedList<Product>(arr);

            //linkedList = new SinglyLinkedList<Product>(Product.GetFakeProduct(), Product.GetFakeProduct(), Product.GetFakeProduct());

            //linkedList = new SinglyLinkedList<Product>(Product.GetFakeProduct());

            linkedList = new SinglyLinkedList<Product>();
            linkedList.AddRange(Product.CreateFakeDatas(20).ToList());
            linkedList.AddRange(Product.CreateFakeDatas(20).ToArray());
            Print();
        }
        private static void AddLast()
        {
            linkedList.AddRange(Product.CreateFakeDatas(4));
            Print();
        }
        private static void AddAfter()
        {
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());

            //linkedList.AddAfter(linkedList.Head.Next.Next, Product.GetFakeProduct());
            linkedList.AddAfter(linkedList.Head, new SinglyLinkedListNode<Product>(Product.GetFakeProduct()));
            Print();
        }
        private static void AddBefore()
        {
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());
            linkedList.AddLast(Product.GetFakeProduct());

            //linkedList.AddBefore(linkedList.Head.Next.Next.Next.Next,Product.GetFakeProduct());
            linkedList.AddBefore(linkedList.Head.Next, new SinglyLinkedListNode<Product>(Product.GetFakeProduct()));
            Print();
        }
        private static void AddFirst()
        {
            linkedList.AddFirst(Product.GetFakeProduct());
            linkedList.AddFirst(Product.GetFakeProduct());
            linkedList.AddFirst(Product.GetFakeProduct());
            linkedList.AddFirst(Product.GetFakeProduct());
            linkedList.AddFirst(Product.GetFakeProduct());
            Print();
        }
        private static void Remove()
        {
            //Remove by node
            //Product[] products = Product.CreateFakeDatas(4).ToArray();
            //linkedList.AddRange(products);
            //Print();

            //Console.WriteLine();
            //linkedList.Remove(linkedList.Head);
            //linkedList.Remove(linkedList.Head);
            //Print();

            //Remove by item
            Product[] products = Product.CreateFakeDatas(4).ToArray();
            linkedList.AddRange(products);
            Print();

            Console.WriteLine();
            //linkedList.Remove(products[4]);
            linkedList.Remove(Product.GetFakeProduct());
            Print();

        }
        private static void RemoveFirst()
        {
            linkedList.AddRange(Product.CreateFakeDatas(8));
            Console.WriteLine("Before Remove");
            Print();

            Console.WriteLine();
            Console.WriteLine("Deleted : " + linkedList.RemoveFirst());
            Console.WriteLine("Deleted : " + linkedList.RemoveFirst());
            Print();
        }
        private static void RemoveLast()
        {

            linkedList.AddRange(Product.CreateFakeDatas(8));
            Console.WriteLine("Before Remove");
            Print();

            Console.WriteLine();
            Console.WriteLine("Deleted : " + linkedList.RemoveLast());
            Console.WriteLine("Deleted : " + linkedList.RemoveLast());
            Print();
        }
        private static void GetEnumerator()
        {
            linkedList.AddRange(Product.CreateFakeDatas(4));
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
        private static void SendCustomLinkedListTOList()
        {
            linkedList.AddRange(Product.CreateFakeDatas(20));
            var newList = new List<Product>(linkedList);
            foreach (var item in newList)
                Console.WriteLine(item);
        }
        private static void Find()
        {
            var product = Product.GetFakeProduct();//the id of the product will  be 1
            linkedList.AddRange(Product.CreateFakeDatas(5));
            linkedList.AddLast(product);
            linkedList.AddRange(Product.CreateFakeDatas(5));

            var search = linkedList.Find(product);
            Console.WriteLine(search);
        }
        private static void LinqExpressions()
        {
            linkedList.AddRange(Product.CreateFakeDatas(10));
            //Query syntax
            var result = from item in linkedList
                         where item.Id <= 3 || item.Id > 6
                         select item;
            //Method Syntax
            result = linkedList.Where(x => x.Id <= 2 || x.Id > 7).ToList();


            foreach (var item in result)
                Console.WriteLine(item);
        }
        private static void Order()
        {
            linkedList.AddRange(Product.CreateFakeDatas(6));
            Console.WriteLine("Before Order");
            Print();
            Console.WriteLine();

            var orderedItems = linkedList.OrderBy(p=>p.Name,true);

            Console.WriteLine("After Order");

            foreach (var item in orderedItems)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("After ordered Original list");
            Print();

        }
        private static void OrderByDescending()
        {
            linkedList.AddRange(Product.CreateFakeDatas(6));
            Console.WriteLine("Before Order");
            Print();
            Console.WriteLine();

            var orderedItems = linkedList.OrderByDescending(p => p.Name, true);

            Console.WriteLine("After Order");

            foreach (var item in orderedItems)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("After ordered Original list");
            Print();

        }
        private static void GetOperations()
        {
    
            linkedList.AddRange(Product.CreateFakeDatas(10));
            Console.WriteLine($"Linkedlist items count : {linkedList.Count}");
            Print();
            Console.WriteLine();
            Console.WriteLine($"First item : {linkedList.GetFirst}");
            Console.WriteLine();
            Console.WriteLine($"Last item : {linkedList.GetLast}");

        }
        private static void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nitems : [\n");
            foreach (var item in linkedList)
                sb.Append("\t").Append(item).Append("\n");
            sb.Append(" ]\n");
            Console.WriteLine(sb.ToString());
        }
    }
    class ArrayOperations
    {
        private static DataStructures.Array.Array<int> arr = new DataStructures.Array.Array<int>();
        public static void Start()
        {
            AddSomeItems(150);
            Console.WriteLine();
            RemoveSomeItems(28);
            Console.WriteLine();
            Clone();
            Console.WriteLine();
        }
        private static void AddSomeItems(int count)
        {
            Console.WriteLine("-- AddSomeItems --");

            for (int i = 0; i < count; i++)
            {
                arr.Add(i + 1);
            }
            Console.WriteLine(arr.ToString());
        }
        private static void RemoveSomeItems(int count)
        {
            Console.WriteLine("-- RemoveSomeItems --");

            for (int i = 1; i < count; i++)
            {
                arr.Remove(i);
            }
            Console.WriteLine(arr.ToString());
        }
        private static void Clone()
        {
            Console.WriteLine("-- Clone --");
            var crr = arr.Clone();
            Console.WriteLine(crr.ToString());
        }
    }
}
