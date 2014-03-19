using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : List<T>
    {
        public class Refer
        {
            private T data;
            private Refer next;
            private Refer previous;

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

            public Refer Previous
            {
                get { return previous; }
                set { previous = value; }
            }

            public Refer(T data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }

            public Refer(T data, Refer next, Refer previous)
            {
                Data = data;
                Next = next;
                Previous = previous;
            }
        }

        private int count = 0;

        private Refer firstElement;
        private Refer lastElement;

        public LinkedList()
        {
            count = 0;
            firstElement = null;
            lastElement = null;
        }

        public LinkedList(T data)
        {
            append(data);
        }

        public LinkedList(params T[] datas)
        {
            for (int i = 0; i < datas.Length; i++)
                append(datas[i]);
        }

        public LinkedList(LinkedList<T> list)
        {
            Refer currentElement = list.firstElement;
            while (currentElement != null)
            {
                append(currentElement.Data);
                currentElement = currentElement.Next;
            }
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return size() == 0;
        }

        public void append(T data)
        {
            if (isEmpty())
            {
                count++;
                firstElement = new Refer(data);
                lastElement = new Refer(data);
            }

            else if (size() == 1)
            {
                count++;
                lastElement = new Refer(data);
                firstElement.Next = lastElement;
                lastElement.Previous = firstElement;
            }

            else
            {
                count++;
                Refer insertElement = new Refer(data);
                insertElement.Previous = lastElement;
                lastElement.Next = insertElement;
                lastElement = insertElement;
            }
        }

        public void prepend(T data)
        {
            if (size() == 0)
                append(data);

            else if (size() == 1)
            {
                count++;
                lastElement = new Refer(data);
                firstElement.Next = lastElement;
            }

            else
            {
                Refer insertElement = new Refer(data);
                insertElement.Next = firstElement;
                firstElement.Previous = insertElement;
                firstElement = insertElement;
                count++;
            }
        }

        public void insert(T data, int index)
        {
            if (index < 0 || index > size())
                throw new Exception("Index out of bounds exception!");
            
            if (index == 0)
                append(data);

            else if (index == size())
                prepend(data);

            else
            {
                Refer insertElement = new Refer(data);
                Refer currentElement = getElement(index);

                currentElement.Previous.Next = insertElement;
                insertElement.Previous = currentElement.Previous;
                currentElement.Previous = insertElement;
                insertElement.Next = insertElement;

                count++;
            }
        }

        public void append(LinkedList<T> list)
        {
            count += list.size();
            lastElement.Next = list.firstElement;
            list.firstElement.Previous = lastElement;
            lastElement = list.lastElement;
        }

        public void prepend(LinkedList<T> list)
        {
            count += list.size();
            list.lastElement.Next = firstElement;
            firstElement.Previous = list.lastElement;
            firstElement = list.firstElement;
        }

        public void insert(LinkedList<T> list, int index)
        {
            if (index < 0 || index > size())
                throw new Exception("Index out of bounds exception!");
            if (index == 0)
                prepend(list);
            else if (index == size())
                append(list);
            else
            {
                count += list.size();
                Refer currentElement = getElement(index);
                currentElement.Previous.Next = list.firstElement;
                list.firstElement.Previous = currentElement.Previous;
                currentElement.Previous = list.lastElement;
                list.lastElement.Next = currentElement;
            }
        }

        public void removeBack()
        {
            if (isEmpty())
                throw new Exception("List is emtpy!");
            if (lastElement.Previous != null)
                lastElement.Previous.Next = null;
            lastElement = lastElement.Previous;
            count--;
        }

        public void removeFront()
        {
            if (isEmpty())
                throw new Exception("List is emtpy!");
            if (firstElement.Next != null)
                firstElement.Next.Previous = null;
            firstElement = firstElement.Next;
            count--;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size())
                throw new Exception("Index out of bounds exception!");

            if (index == 0)
                removeFront();

            else if (index == size() - 1)
                removeBack();

            else
            {
                Refer deleteRefer = getElement(index);

                deleteRefer.Previous.Next = deleteRefer.Next;
                deleteRefer.Next.Previous = deleteRefer.Previous;
                count--;
            }
        }

        public void clear()
        {
            while (!isEmpty())
                removeFront();
        }

        public LinkedList<T> subList(int startIndex)
        {
            if (startIndex < 0 || startIndex >= size())
                throw new Exception("Index out of bounds exception!");
            
            LinkedList<T> list = new LinkedList<T>();
            Refer currentElement = getElement(startIndex);
            while (currentElement != null)
            {
                list.append(currentElement.Data);
                currentElement = currentElement.Next;
            }
            return list;
        }

        public LinkedList<T> subList(int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= size())
                throw new Exception("Start index out of bounds exception!");
            if (endIndex < 0 || endIndex >= size())
                throw new Exception("End index out of bounds exception!");
            if (endIndex < startIndex)
                throw new Exception("Start index is higher than end index exception!");

            LinkedList<T> list = new LinkedList<T>();
            int currentIndex = startIndex;
            Refer currentElement = getElement(currentIndex);
            while (currentIndex <= endIndex)
            {
                list.append(currentElement.Data);
                currentElement = currentElement.Next;
                currentIndex++;
            }

            return list;
        }

        public T first()
        {
            if (isEmpty())
                throw new Exception("List is emtpy!");
            return firstElement.Data;
        }

        public T last()
        {
            if (isEmpty())
                throw new Exception("List is emtpy!");
            return lastElement.Data;
        }

        public T get(int index)
        {
            return getElement(index).Data;
        }

        public int getIndexByValue(T data)
        {
            int currentIndex = 0;
            Refer currentElement = firstElement;
            while (currentElement != null)
            {
                if (currentElement.Data.Equals(data))
                    return currentIndex;
                currentIndex++;
                currentElement = currentElement.Next;
            }
            return -1;
        }

        public T[] toArray()
        {
            T[] res = new T[size()];
            int currentIndex = 0;
            Refer currentElement = firstElement;
            while (currentElement != null)
            {
                res[currentIndex] = currentElement.Data;
                currentElement = currentElement.Next;
                currentIndex++;
            }
            return res;
        }

        public bool contains(T data)
        {
            Refer current = firstElement;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public bool equals(LinkedList<T> list)
        {
            Refer current = firstElement;
            Refer currentList = list.firstElement;
            while (current != null && currentList != null)
            {
                if (!current.Data.Equals(currentList.Data))
                    return false;
                current = current.Next;
                currentList = currentList.Next;
            }
            return (current == null && currentList == null);
        }

        public String toString()
        {
            String res = "";
            Refer current = firstElement;
            while (current != null)
            {
                res += current.Data + " ";
                current = current.Next;
            }
            return res.Substring(0, res.Length - 1);
        }

        private Refer getElement(int index)
        {
            if (index < 0 || index >= size())
                throw new Exception("Index out of bounds exception!");
            //we are looking for the shortest way - from start or from end
            if (index < size() - index)
            {
                Refer currentElement = firstElement;
                int currentIndex = 0;
                while (currentIndex < index)
                {
                    currentElement = currentElement.Next;
                    currentIndex++;
                }
                return currentElement;
            }

            else
            {
                Refer currentElement = lastElement;
                int currentIndex = size() - 1;
                while (currentIndex > index)
                {
                    currentElement = currentElement.Previous;
                    currentIndex--;
                }
                return currentElement;
            }
        }

        public Iterator getIterator()
        {
            return new Iterator(firstElement);
        }

        public Iterator getBackIterator()
        {
            return new Iterator(lastElement);
        }

        public class Iterator
        {
            Refer current;

            public Iterator(Refer current)
            {
                this.current = current;
            }

            public bool hasCurrent()
            {
                return (current != null);
            }

            public void next()
            {
                current = current.Next;
            }

            public void previous()
            {
                current = current.Previous;
            }
        }

    }
}
