using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class ArrayDequeue<T> : DEQueue<T>
    {
        private const int INITIAL_CAPACITY = 16;

        private const double ENSURE_CAPACITY = 1.5;

        private const double FILLED_COEFF = 1.2;

        private int capacity;

        private T[] values;

        private int backIndex;

        private int frontIndex;

        public ArrayDequeue()
        {
            capacity = INITIAL_CAPACITY;
            values = new T[capacity];
        }

        public ArrayDequeue(int initialCapacity)
        {
            capacity = max(initialCapacity, INITIAL_CAPACITY);
            values = new T[capacity];
        }

        public ArrayDequeue(T element)
        {
            capacity = INITIAL_CAPACITY;
            values = new T[INITIAL_CAPACITY];
            addBack(element);
        }

        public ArrayDequeue(params T[] values)
        {
            capacity = max((int)(values.Length * ENSURE_CAPACITY), INITIAL_CAPACITY);
            this.values = new T[capacity];
            addAllBack(values);
        }

        public ArrayDequeue(IEnumerable<T> collection)
        {
            capacity = max((int)(collection.Count() * ENSURE_CAPACITY), INITIAL_CAPACITY);
            this.values = new T[capacity];
            addAllBack(values);
        }

        private void ensureCapacity()
        {
            capacity = (int)(capacity * ENSURE_CAPACITY);
            T[] newValues = new T[capacity];

            values = newValues;
        }

        private void decreaseCapacity()
        {
            if (capacity == INITIAL_CAPACITY)
            {
                return;
            }
            capacity = max(INITIAL_CAPACITY, (int)(capacity / ENSURE_CAPACITY));

        }

        private int max(int a, int b)
        {
            return a < b ? b : a;
        }

        public void addFront(T element)
        {
            if (isEmpty())
            {
                values[0] = element;
                backIndex = capacity - 1;
                frontIndex = 1;
            }
            if ((1.0 * capacity) / size() < FILLED_COEFF)
            {
                ensureCapacity();
            }
            if (frontIndex == capacity - 1)
            {
                frontIndex = 0;
                values[capacity - 1] = element;
            }
            else
            {
                values[frontIndex] = element;
                frontIndex++;
            }
        }

        public void addBack(T element)
        {
            if (isEmpty())
            {
                values[0] = element;
                backIndex = capacity - 1;
                frontIndex = 1;
            }
            if ((1.0 * capacity) / size() < FILLED_COEFF)
            {
                ensureCapacity();
            }
            if (backIndex == 0)
            {
                backIndex = capacity - 1;
                values[0] = element;
            }
            else
            {
                values[backIndex] = element;
                backIndex--;
            }
        }

        public T popFront()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            if (frontIndex == 0)
            {
                frontIndex = capacity - 1;
                if (capacity / size() >= 2) 
                {
                    decreaseCapacity();
                }
                return values[frontIndex];
            }
            frontIndex--;
            return values[frontIndex];
        }

        public T popBack()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            if (backIndex == capacity - 1)
            {
                backIndex = 0;
                if (capacity / size() >= 2)
                {
                    decreaseCapacity();
                }
                return values[backIndex];
            }
            backIndex++;
            return values[backIndex];
        }

        public T peekFront()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            if (frontIndex == 0)
            {
                return values[capacity - 1];
            }
            return values[frontIndex - 1];
        }

        public T peekBack()
        {
            if (isEmpty())
            {
                throw new EmptyQueueException();
            }
            if (backIndex == capacity - 1)
            {
                return values[0];
            }
            return values[backIndex + 1];
        }

        public void addAllBack(IEnumerable<T> collection)
        {
            foreach (T value in collection)
            {
                addBack(value);
            }
        }

        public void addAllFront(IEnumerable<T> collection)
        {
            for (int i = collection.Count() - 1; i >= 0; i--)
            {
                addFront(collection.ElementAt(i));
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (isEmpty())
            {
                builder.Append("[]");
            }
            else if (frontIndex > backIndex)
            {
                builder.Append("[");
                for (int i = frontIndex - 1; i > backIndex; i--)
                {
                    builder.Append(values[i]).Append(", ");
                }
                builder.Append("]");
                builder.Remove(builder.Length - 2, 2);
            }
            else
            {
                builder.Append("[");
                for (int i = frontIndex - 1; i >= 0; i--)
                {
                    builder.Append(values[i]).Append(", ");
                }
                for (int i = backIndex + 1; i < capacity - 1; i++)
                {
                    builder.Append(values[i]).Append(", ");
                }
                builder.Append("]");
                builder.Remove(builder.Length - 2, 2);
            }
            return builder.ToString();
        }

        public void clear()
        {
            capacity = INITIAL_CAPACITY;
            values = new T[capacity];
            frontIndex = 0;
            backIndex = 0;
        }

        public int size()
        {
            if (isEmpty())
            {
                return 0;
            }
            if (frontIndex > backIndex)
            {
                return frontIndex - backIndex - 1;
            }
            else
            {
                return frontIndex + capacity - backIndex - 1;
            }
        }

        public bool isEmpty()
        {
            return frontIndex == backIndex;
        }

    }
}
