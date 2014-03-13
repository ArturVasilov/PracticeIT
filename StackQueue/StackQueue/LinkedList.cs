using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class LinkedList<T>
    {
        private class Refer
        {
            private T data;
            private Refer next;

            public Refer(T data, Refer next)
            {
                this.data = data;
                this.next = next;
            }

            public T Data
            {
                get { return data; }
                set { data = value; }
            }

            public Refer Next
            {
                get { return next; }
                set { next = value; }
            }
        }

        Refer firstElement;
        Refer lastElement;

        private int size = 0;

        public int getSize()
        {
            return size;
        }

        public bool isEmpty()
        {
            return getSize() == 0;
        }

        public LinkedList()
        {
            firstElement = null;
            lastElement = null;
            size = 0;
        }

        public LinkedList(T data)
        {
            firstElement = new Refer(data, null);
            lastElement = new Refer(data, null);
            size = 1;
        }

        //for queue
        public void addBack(T data)
        {
            if (isEmpty())
            {
                firstElement = new Refer(data, null);
                lastElement = new Refer(data, null);    
            }

            else if (getSize() == 1)
            {
                lastElement = new Refer(data, null);
                firstElement.Next = lastElement;
            }
            else
            {
                lastElement.Next = new Refer(data, null);
                lastElement = lastElement.Next;
            }

            size++;
        }

        public void addFront(T data)
        {
            if (isEmpty())
                addBack(data);

            else if (getSize() == 1)
            {
                firstElement = new Refer(data, null);
                firstElement.Next = lastElement;
            }
            else
            {
                Refer insElement = new Refer(data, null);
                insElement.Next = firstElement;
                firstElement = insElement;
            }
            size++;
        }

        //getters for both structures
        public T popFront()
        {
            if (isEmpty())
                throw new Exception("List is empty!");
            T t = firstElement.Data;
            if (getSize() == 1)
            {
                firstElement = firstElement.Next;
                lastElement = null;
            }
            else
                firstElement = firstElement.Next;
            size--;
            return t;
        }

        public T peekFront()
        {
            if (isEmpty())
                throw new Exception("List is empty!");
            return firstElement.Data;
        }

        public override string ToString()
        {
            String s = "";
            Refer current = firstElement;
            while (current != null)
            {
                s += current.Data + " ";
                current = current.Next;
            }
            return s;
        }

        public void clear()
        {
            size = 0;
            if (firstElement.Next != null)
                firstElement.Next = null;
            firstElement = null;
            lastElement = null;
        }
    }
}
