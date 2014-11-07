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

        private const double FILLED_COEFF = 2;
        private const double EMPTY_COEFFICIENT = 2;

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
            int newCapacity = (int)(capacity * ENSURE_CAPACITY);
            T[] newValues = new T[newCapacity];
            copyCurrentValues(ref newValues, newCapacity);
            capacity = newCapacity;
        }

        private void decreaseCapacity()
        {
            if (capacity == INITIAL_CAPACITY)
            {
                return;
            }
            int newCapacity = max(INITIAL_CAPACITY, (int)(capacity / ENSURE_CAPACITY));
            T[] newValues = new T[newCapacity];
            copyCurrentValues(ref newValues, newCapacity);
            capacity = newCapacity;
        }

        private void copyCurrentValues(ref T[] newValues, int newCapacity)
        {
            int size = this.size();
            if (frontIndex > backIndex)
            {
                for (int i = 0; i < size; i++)
                {
                    newValues[i] = values[backIndex + 1 + i];
                }
            }
            else
            {
                int i = 0;
                for (; i < capacity - backIndex - 1; i++)
                {
                    newValues[i] = values[backIndex + 1 + i];
                }
                for (int j = 0; j < frontIndex; j++)
                {
                    newValues[i + j] = values[j];
                }
            }
            frontIndex = size;
            backIndex = newCapacity - 1;
            this.values = newValues;
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
                return;
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
                return;
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
                T value = values[frontIndex];
                if (capacity / size() >= EMPTY_COEFFICIENT) 
                {
                    decreaseCapacity();
                }
                return value;
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
                T value = values[backIndex];
                if (capacity / size() >= EMPTY_COEFFICIENT)
                {
                    decreaseCapacity();
                }
                return value;
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
                builder.Remove(builder.Length - 2, 2);
                builder.Append("]");
            }
            else
            {
                builder.Append("[");
                for (int i = frontIndex - 1; i >= 0; i--)
                {
                    builder.Append(values[i]).Append(", ");
                }
                for (int i = capacity - 1; i > backIndex; i--)
                {
                    builder.Append(values[i]).Append(", ");
                }
                builder.Remove(builder.Length - 2, 2);
                builder.Append("]");
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
