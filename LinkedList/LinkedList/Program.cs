using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(4, 6, 7, 9, 10, 15);
            list.append(4);
            list.prepend(5);
            Console.WriteLine("list: " + list.toString());
            Console.WriteLine("size: " + list.size());
            Console.WriteLine("list contains 5? - " + list.contains(5));
            Console.WriteLine("index of 5: " + list.getIndexByValue(5));
            Console.WriteLine("list to array: ");
            int[] arr = list.toArray();
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("lists equals? - " + list.equals(new LinkedList<int>(
                5, 4, 6, 7, 9, 10, 15, 4)));
            Console.WriteLine("lists equals? - " + list.equals(new LinkedList<int>(
                5, 4, 6, 7, 9, 10, 15)));
            Console.WriteLine("sublist 1: " + list.subList(5).toString());
            Console.WriteLine("sublist 2: " + list.subList(3, 5).toString());
            Console.WriteLine("first: " + list.first());
            Console.WriteLine("last: " + list.last());
            list.removeFront();
            list.removeBack();
            Console.WriteLine("after removing back and front: " + list.toString());
            list.remove(3);
            list.remove(4);
            Console.WriteLine("after removing: " + list.toString());
            list.append(new LinkedList<int>(3));
            Console.WriteLine("append list: " + list.toString());
            list.prepend(new LinkedList<int>(new LinkedList<int>(4, 4)));
            Console.WriteLine("prepend list: " + list.toString());
            list.insert(new LinkedList<int>(81, 82), 3);
            Console.WriteLine("after list insert: " + list.toString());
            Console.WriteLine("Get element: " + list.get(3));
            list.clear();
            Console.WriteLine("Size after clearing: " + list.size());
            Console.ReadLine();
        }
    }
}
