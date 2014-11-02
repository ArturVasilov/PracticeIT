using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class StackAdapter<T> : StackQueue<T>
    {
        private DEQueue<T> dequeue;

        public StackAdapter(DEQueue<T> dequeue)
        {
            this.dequeue = dequeue;
        }

        public void push(T element)
        {
            dequeue.addBack(element);
        }

        public T pop()
        {
            return dequeue.popBack();
        }

        public T peek()
        {
            return dequeue.peekBack();
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
    }
}
