using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Stack<T> : List<T>
    {
        LinkedList<T> list;

        public Stack()
        {
            list = new LinkedList<T>();
        }

        public Stack(T data)
        {
            list = new LinkedList<T>(data);
        }

        public Stack(params T[] datas)
        {
            list = new LinkedList<T>();
            foreach (T t in datas)
                list.addFront(t);
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        public int size()
        {
            return list.getSize();
        }

        public void add(T data)
        {
            list.addFront(data);
        }

        public T pop()
        {
            if (isEmpty())
                throw new Exception("Stack is emtpy!");
            return list.popFront();
        }

        public T peek()
        {
            if (isEmpty())
                throw new Exception("Stack is emtpy!");
            return list.peekFront();
        }

        public override String ToString()
        {
            return list.ToString();
        }

        public void clear()
        {
            list.clear();
        }
    }
}
