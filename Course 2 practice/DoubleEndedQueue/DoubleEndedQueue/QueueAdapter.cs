using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class QueueAdapter<T> : StackQueue<T>
    {
        private DEQueue<T> dequeue;

        public QueueAdapter(DEQueue<T> dequeue)
        {
            this.dequeue = dequeue;
        }

        public void push(T element)
        {
            dequeue.addBack(element);
        }

        public T pop()
        {
            return dequeue.popFront();
        }

        public T peek()
        {
            return dequeue.peekFront();
        }

        public void pushAll(IEnumerable<T> collection)
        {
            dequeue.addAllBack(collection);
        }

        public void clear()
        {
            dequeue.clear();
        }

        public int size()
        {
            return dequeue.size();
        }

        public bool isEmpty()
        {
            return dequeue.isEmpty();
        }

        public override string ToString()
        {
            return dequeue.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return dequeue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dequeue.GetEnumerator();
        }
    }
}
