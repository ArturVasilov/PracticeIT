using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test ListDequeue");
            DEQueue<int> dequeue = new ListDequeue<int>(3, 4, 5);
            testDequeue(dequeue);

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Test ArrayDequeue");
            dequeue = new ArrayDequeue<int>(10);
            testDequeue(dequeue);

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Test ConcurrentDequeue");
            dequeue = new ConcurrentDequeue<int>(new int[] {3, 4, 5});
            testDequeue(dequeue);

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Test Stack");
            DEQueue<string> sd = new ListDequeue<string>();
            StackQueue<string> sq = new StackAdapter<string>(sd);
            testStackQueue(sq);

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Test Queue");
            sd = new ListDequeue<string>();
            sq = new QueueAdapter<string>(sd);
            testStackQueue(sq);

            Console.ReadLine();
        }

        static void testDequeue(DEQueue<int> dequeue)
        {
            Console.WriteLine(dequeue);
            dequeue.addBack(4);
            dequeue.addFront(2);
            dequeue.addFront(3);
            Console.WriteLine(dequeue);
            dequeue.addAllBack(new int[] { 7, 8, 9, 10 });
            dequeue.addBack(17);
            dequeue.addAllFront(new List<int>(new int[] { 11, 15, 22, 45, 72 }));
            Console.WriteLine(dequeue);
            Console.WriteLine(dequeue.peekBack() == dequeue.popBack());
            Console.WriteLine(dequeue.popBack());
            Console.WriteLine(dequeue.peekBack());
            Console.WriteLine(dequeue);
            Console.WriteLine(dequeue.peekFront() == dequeue.popFront());
            Console.WriteLine(dequeue.popFront());
            Console.WriteLine(dequeue.peekFront());
            Console.WriteLine(dequeue);
            Console.WriteLine(dequeue.size());
            dequeue.clear();
            Console.WriteLine(dequeue);
        }

        static void testStackQueue(StackQueue<string> sq)
        {
            Console.WriteLine(sq);
            sq.push("aaa");
            sq.push("bbbb");
            sq.pushAll(new string[] { "xx", "12", "16", "17" });
            Console.WriteLine(sq);
            Console.WriteLine(sq.peek() == sq.pop());
            Console.WriteLine(sq.peek());
            Console.WriteLine(sq.pop());
            Console.WriteLine(sq);
            Console.WriteLine(sq.size());
            sq.clear();
            Console.WriteLine(sq);
        }
    }
}
