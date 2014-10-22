using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    class ListSet<T> : Set<T>
    {
        private class Refer
        {
            public T data;
            public Refer next;

            public Refer(T data, Refer next)
            {
                this.data = data;
                this.next = next;
            }
        }

        private Refer firstElement;
        private Refer lastElement;

        private int Count { get; set; }

        
        public ListSet()
        {
            Count = 0;
        }

        public ListSet(T element)
        {
            add(element);
        }

        public ListSet(params T[] elements)
        {
            addAll(elements);
        }

        public bool add(T element)
        {
            if (contains(element))
            {
                return false;
            }
            if (isEmpty())
            {
                firstElement = new Refer(element, null);
                lastElement = new Refer(element, null);
            }
            else if (Count == 1)
            {
                lastElement = new Refer(element, null);
                firstElement.next = lastElement;
            }
            else
            {
                lastElement.next = new Refer(element, null);
                lastElement = lastElement.next;
            }
            Count++;
            return true;
        }

        public bool remove(T element)
        {
            if (!contains(element))
            {
                return false;
            }
            Refer current = firstElement;
            if (Count == 1)
            {
                firstElement = null;
                lastElement = null;
                Count--;
                return true;
            }
            if (current.data.Equals(element))
            {
                firstElement = firstElement.next;
                Count--;
                return true;
            }
            while (current != null && !current.next.data.Equals(element))
            {
                current = current.next;
            }
            current.next = current.next.next;
            return true;
        }

        public bool contains(T element)
        {
            Refer current = firstElement;
            while (current != null)
            {
                if (current.data.Equals(element))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public bool addAll(IEnumerable<T> collection)
        {
            bool isAllAdded = true;
            foreach (T element in collection)
            {
                bool b = add(element);
                if (isAllAdded == true)
                {
                    isAllAdded = b;
                }
            }
            return isAllAdded;
        }

        public bool removeAll(IEnumerable<T> collection)
        {
            bool isAllRemoved = true;
            foreach (T element in collection)
            {
                bool b = remove(element);
                if (isAllRemoved == true)
                {
                    isAllRemoved = b;
                }
            }
            return isAllRemoved;
        }

        public bool containsAll(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                if (!contains(element))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isEmpty()
        {
            return Count == 0;
        }

        public int size()
        {
            return Count;
        }

        public override string ToString()
        {
            if (Count == 0)
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
