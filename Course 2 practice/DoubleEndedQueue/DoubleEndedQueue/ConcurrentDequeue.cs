using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class ConcurrentDequeue<T> : DEQueue<T>
    {
        private static readonly object monitor = new object();

        //I can use adapter here, but list implementation is much more powerful for it;
        private ListDequeue<T> dequeue;

        public ConcurrentDequeue()
        {
            dequeue = new ListDequeue<T>();
        }

        public ConcurrentDequeue(T element)
        {
            dequeue = new ListDequeue<T>(element);
        }

        public ConcurrentDequeue(IEnumerable<T> collection)
        {
            dequeue = new ListDequeue<T>(collection);
        }

        public void addFront(T element)
        {
            lock (monitor)
            {
                dequeue.addFront(element);
            }
        }

        public void addBack(T element)
        {
            lock (monitor)
            {
                dequeue.addBack(element);
            }
        }

        public T popFront()
        {
            lock (monitor)
            {
                return dequeue.popFront();
            }
        }

        public T popBack()
        {
            lock (monitor)
            {
                return dequeue.popBack();
            }
        }

        public T peekFront()
        {
            lock (monitor)
            {
                return dequeue.peekFront();
            }
        }

        public T peekBack()
        {
            lock (monitor)
            {
                return dequeue.peekBack();
            }
        }

        public void addAllBack(IEnumerable<T> collection)
        {
            lock (monitor)
            {
                dequeue.addAllBack(collection);
            }
        }

        public void addAllFront(IEnumerable<T> collection)
        {
            lock (monitor)
            {
                dequeue.addAllFront(collection);
            }
        }

        public void clear()
        {
            lock (monitor)
            {
                dequeue.clear();
            }
        }

        public int size()
        {
            lock (monitor)
            {
                return dequeue.size();
            }
        }

        public bool isEmpty()
        {
            lock (monitor)
            {
                return dequeue.isEmpty();
            }
        }

        public override string ToString()
        {
            lock (monitor)
            {
                return dequeue.ToString();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            lock (monitor)
            {
                return dequeue.GetEnumerator();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            lock (monitor)
            {
                return dequeue.GetEnumerator();
            }
        }
    }
}
