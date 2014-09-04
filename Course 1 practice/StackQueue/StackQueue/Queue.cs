using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Queue<T> : List<T>
    {
        private LinkedList<T> list;

        public int size()
        {
            return list.getSize();
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        public Queue()
        {
            list = new LinkedList<T>();
        }

        public Queue(T data)
        {
            list = new LinkedList<T>(data);
        }

        public Queue(params T[] datas)
        {
            list = new LinkedList<T>();
            foreach (T t in datas)
                list.addBack(t);
        }

        public void add(T data)
        {
            list.addBack(data);
        }

        public T pop()
        {
            if (isEmpty())
                throw new Exception("Queue is empty!");
            return list.popFront();
        }

        public T peek()
        {
            if (isEmpty())
                throw new Exception("Queue is empty!");
            return list.peekFront();
        }

        public override string ToString()
        {
            return list.ToString();
        }

        public void clear()
        {
            list.clear();
        }
    }
}
