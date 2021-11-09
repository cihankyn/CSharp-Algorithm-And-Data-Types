using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Apps
{
    class Program
    {
        private static DataStructures.Array.Array<int> arr = new DataStructures.Array.Array<int>();
        static void Main(string[] args)
        {
            AddSomeItems(150);
            Console.WriteLine();
            RemoveSomeItems(28);
            Console.WriteLine();
            Clone();
            Console.WriteLine();


            Console.ReadKey();
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
