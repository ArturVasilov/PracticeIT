using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue testing:");
            Queue<int> queue = new Queue<int>(3, 4, 5, 7, 9, 10);
            queue.add(2);
            Console.WriteLine("Init and ToString():");
            Console.WriteLine(queue.ToString());
            Console.WriteLine("Size:");
            Console.WriteLine(queue.size());
            Console.WriteLine("Show top without deleting:");
            Console.WriteLine(queue.peek());
            Console.WriteLine("Show 2 top with deleting:");
            Console.WriteLine(queue.pop());
            Console.WriteLine(queue.pop());
            Console.WriteLine("Size now:");
            Console.WriteLine(queue.size());
            Console.WriteLine("ToString:");
            Console.WriteLine(queue.ToString());
            Console.WriteLine("Size after clear:");
            queue.clear();
            Console.WriteLine(queue.size());
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Stack testing:");
            Stack<int> stack = new Stack<int>(5, 10, 15, 20, 51, 41, 43);
            stack.add(2);
            Console.WriteLine("Init and ToString():");
            Console.WriteLine(stack.ToString());
            Console.WriteLine("Size:");
            Console.WriteLine(stack.size());
            Console.WriteLine("Show top without deleting:");
            Console.WriteLine(stack.peek());
            Console.WriteLine("Show 2 top with deleting:");
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine("Size now:");
            Console.WriteLine(stack.size());
            Console.WriteLine("ToString:");
            Console.WriteLine(stack.ToString());
            Console.WriteLine("Size after clear:");
            stack.clear();
            Console.WriteLine(stack.size());

            Console.ReadLine();
        }
    }
}
