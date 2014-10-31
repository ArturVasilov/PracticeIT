using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class ListDequeue<T> : DEQueue<T>
    {
        private class Refer
        {
            public T data;
            public Refer next;
            public Refer previous;
            public Refer(T data, Refer next, Refer previous)
            {
                this.data = data;
                this.next = next;
                this.previous = previous;
            }
        }

        private Refer firstElement;
        private Refer lastElement;

        private int count;

        public ListDequeue()
        {
            count = 0;
        }

        public ListDequeue(T element)
        {
            addBack(element);
        }

        public ListDequeue(IEnumerable<T> collection)
        {
            addAllBack(collection);
        }

        public ListDequeue(params T[] values)
        {
            addAllBack(values);
        }

        public void addFront(T element)
        {
            if (isEmpty())
            {
                firstElement = new Refer(element, null, null);
                lastElement = new Refer(element, null, null);
            }
            else if (size() == 1)
            {
                firstElement = new Refer(element, lastElement, null);
                lastElement.previous = firstElement;
            }
            else
            {
                Refer temp = firstElement;
                firstElement = new Refer(element, temp, null);
                temp.previous = firstElement;
            }
            count++;
        }

        public void addBack(T element)
        {
            if (isEmpty())
            {
                firstElement = new Refer(element, null, null);
                lastElement = new Refer(element, null, null);
            }
            else if (size() == 1)
            {
                lastElement = new Refer(element, null, firstElement);
                firstElement.next = lastElement;
            }
            else
            {
                Refer temp = lastElement;
                lastElement = new Refer(element, null, temp);
                temp.next = lastElement;
            }
            count++;
        }

        public T popFront()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            T value = firstElement.data;
            if (size() == 1)
            {
                clear();
            }
            else
            {
                firstElement.next.previous = null;
                firstElement = firstElement.next;
            }
            count--;
            return value;
        }

        public T popBack()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            T value = lastElement.data;
            if (size() == 1)
            {
                clear();
            }
            else
            {
                lastElement.previous.next = null;
                lastElement = lastElement.previous;
            }
            count--;
            return value;
        }

        public T peekFront()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            return firstElement.data;
        }

        public T peekBack()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            return lastElement.data;
        }

        public void addAllBack(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                addBack(element);
            }
        }

        public void addAllFront(IEnumerable<T> collection)
        {
            for (int i = collection.Count() - 1; i >= 0; i--)
            {
                addFront(collection.ElementAt(i));
            }
        }

        public void clear()
        {
            if (isEmpty())
            {
                return;
            }
            if (size() == 1)
            {
                firstElement = null;
                lastElement = null;
            }
            else
            {
                Refer current = firstElement.next;
                do
                {
                    current.previous = null;
                    current = current.next;
                } while (current.next != null);
                current.previous = null;
                current = null;
            }
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            if (size() == 0)
            {
                return "[]";
            }
            StringBuilder builder = new StringBuilder("[");
            Refer current = firstElement;
            while (current != null)
            {
                builder.Append(current.data.ToString()).Append(", ");
                current = current.next;
            }
            builder.Remove(builder.Length - 2, 2);
            return builder.Append("]").ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> list = new List<T>();
            Refer current = firstElement;
            while (current != null)
            {
                list.Add(current.data);
                current = current.next;
            }
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
