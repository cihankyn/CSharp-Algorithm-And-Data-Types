using DataStructures.LinkedList.DoublyLinkedList;
using DataStructures.LinkedList.SinglyLinkedList;
using DataStructures.Queue.Abstract;
using DataStructures.Queue.Concrete;
using DataStructures.Stack.Concrete;
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
            //OneWayListOperations.Start();
            //TwoWayListOperations.Start();
            //StackOperations.Start();
            QueueOperations.Start();
            Console.ReadKey();
        }
    }
    public class QueueOperations
    {
        public static void Start()
        {
            ArrayListOperations.Start();
            LinkedListOperations.Start();
        }

        // Sub classes
        class ArrayListOperations
        {
            static IQueue<Product> _queue = new ArrayQueue<Product>();
            public static void Start()
            {
                Console.WriteLine("ArrayQueue working...");

                var products = Product.CreateFakeDatas(3);

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");
                Console.WriteLine();

                products.ForEach(p =>
                {
                    _queue.EnQueue(p);
                    Console.WriteLine($"The {p} added to queue");
                });

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Peek() => {_queue.Peek()}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");

                //Throws error: because all items removed.
                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"ArrayQueue.Count() => {_queue.Count}");


            }
        }
        class LinkedListOperations
        {
            static IQueue<Product> _queue = new LinkedListQueue<Product>();
            public static void Start()
            {
                Console.WriteLine("ArrayQueue working...");

                var products = Product.CreateFakeDatas(3);

                Console.WriteLine();
                Console.WriteLine($"LinkedLinsQueue.Count() => {_queue.Count}");
                Console.WriteLine();

                products.ForEach(p =>
                {
                    _queue.EnQueue(p);
                    Console.WriteLine($"The {p} added to queue");
                });

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Peek() => {_queue.Peek()}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Count() => {_queue.Count}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Count() => {_queue.Count}");

                //Throws error: because all items removed.
                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.DeQueue() => {_queue.DeQueue()}");

                Console.WriteLine();
                Console.WriteLine($"LinkedListQueue.Count() => {_queue.Count}");


            }
        }
    }
    public class StackOperations
    {
        public static void Start()
        {
            ArrayListOperations.Start();
            LinkedListOperations.Start();
        }

        // Sub classes

        class ArrayListOperations
        {
            static DataStructures.Stack.Concrete.Stack<Product> _stack = new DataStructures.Stack.Concrete.Stack<Product>(new ArrayStack<Product>());
            public static void Start()
            {
                Console.WriteLine("ArrayStack working...");

                var products = Product.CreateFakeDatas(5);

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");
                Console.WriteLine();

                products.ForEach(p =>
                {
                    _stack.Push(p);
                    Console.WriteLine($"The {p} added to stack");
                });

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Peek() => {_stack.Peek()}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Pop() => {_stack.Pop()}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Pop() => {_stack.Pop()}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");


            }
        }

        class LinkedListOperations
        {
            static DataStructures.Stack.Concrete.Stack<Product> _stack = new DataStructures.Stack.Concrete.Stack<Product>(new LinkedListStack<Product>());
            public static void Start()
            {

                Console.WriteLine("LinkedListStack working...");

                var products = Product.CreateFakeDatas(5);

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");
                Console.WriteLine();

                products.ForEach(p =>
                {
                    _stack.Push(p);
                    Console.WriteLine($"The {p} added to stack");
                });

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Peek() => {_stack.Peek()}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Pop() => {_stack.Pop()}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Pop() => {_stack.Pop()}");

                Console.WriteLine();
                Console.WriteLine($"Stack.Count() => {_stack.Count}");



            }
        }


    }
    class TwoWayListOperations
    {
        private static DoublyLinkedList<Product> linkedlist = new DoublyLinkedList<Product>();
        public static void Start()
        {
            //AddFirst();
            //AddLast();
            //AddAfter();
            //AddBefore();
            //GetAllNodes();
            //Constructors();
            Remove();
            //Properties();
        }
        private static void AddFirst()
        {
            linkedlist.AddFirst(Product.GetFakeProduct());
            linkedlist.AddFirst(Product.GetFakeProduct());
            linkedlist.AddFirst(Product.GetFakeProduct());
            linkedlist.AddFirst(Product.GetFakeProduct());
            Print();
        }
        private static void AddLast()
        {
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            Print();
        }
        private static void AddAfter()
        {
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());

            Console.WriteLine("Before");
            Print();

            var afterNode = linkedlist.Head;// Adds to after head

            afterNode = linkedlist.Head.Next;// Adds to after head.next

            afterNode = linkedlist.Head.Next.Next.Next; //Adds to after last item

            // This node is not in the list
            afterNode = new DoublyLinkedListNode<Product>(Product.GetFakeProduct());

            afterNode = null; // Throws ArgumentNullException

            linkedlist.AddAfter(afterNode, Product.GetFakeProduct());
            Console.WriteLine("After");
            Print();
        }
        private static void AddBefore()
        {
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());
            linkedlist.AddLast(Product.GetFakeProduct());

            Console.WriteLine("Before");
            Print();

            var beforeNode = linkedlist.Head;// Adds to before of head

            beforeNode = linkedlist.Head.Next;// Adds to before head.next

            beforeNode = linkedlist.Head.Next.Next.Next; //Adds to before last item

            // This node is not in the list
            beforeNode = new DoublyLinkedListNode<Product>(Product.GetFakeProduct());

            beforeNode = null; // Throws ArgumentNullException

            linkedlist.AddBefore(beforeNode, Product.GetFakeProduct());
            Console.WriteLine("After");
            Print();
        }
        private static void GetAllNodes()
        {
            Product.CreateFakeDatas(15).ForEach(p => linkedlist.AddLast(p));

            foreach (var item in linkedlist)
                Console.WriteLine(item);
        }
        private static void Constructors()
        {
            var list = Product.CreateFakeDatas(5);
            var arr = list.ToArray();

            linkedlist = new DoublyLinkedList<Product>(arr);

            linkedlist = new DoublyLinkedList<Product>(Product.GetFakeProduct(), Product.GetFakeProduct(), Product.GetFakeProduct());
            Print();
        }
        private static void Remove()
        {
            Product.CreateFakeDatas(1).ForEach(p => linkedlist.AddLast(p));
            Console.WriteLine("Before");
            Print();
            Console.WriteLine();
            Console.WriteLine("After");


            //Console.WriteLine($"{linkedlist.RemoveFirst()} (removed)");
            //Console.WriteLine($"{linkedlist.RemoveLast()} (removed)");

            linkedlist.Remove(linkedlist.Head);
            //linkedlist.Remove(linkedlist.Tail);
            //linkedlist.Remove(linkedlist.Head.Next);
            //linkedlist.Remove(new DoublyLinkedListNode<Product>(Product.GetFakeProduct()));//Throws error
            Print();
        }
        private static void Properties()
        {
            Product.CreateFakeDatas(5).ForEach(p => linkedlist.AddLast(p));
            Console.WriteLine("items : \n [");

            foreach (var item in linkedlist)
                Console.WriteLine($"\t{item}");
            Console.WriteLine(" ]");
            Console.WriteLine();
            Console.WriteLine($"Head : {linkedlist.GetFirst}");
            Console.WriteLine($"Tail : {linkedlist.GetLast}");
            Console.WriteLine($"Count : {linkedlist.Count}");
        }
        private static void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Items : [\n");
            var current = linkedlist.Head;
            while (current is not null)
            {
                sb.Append($" \t{current.Value} \n");
                current = current.Next;
            }
            sb.Append(" ]\n");
            if (linkedlist.Head is not null)
                sb.Append($"Head : {linkedlist.Head.Value}\n");
            if (linkedlist.Tail is not null)
                sb.Append($"Tail : {linkedlist.Tail.Value}\n");
            Console.WriteLine(sb);
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
    class OneWayListOperations
    {
        private static SinglyLinkedList<Product> linkedList = new SinglyLinkedList<Product>();
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

            var orderedItems = linkedList.OrderBy(p => p.Name, true);

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
}
