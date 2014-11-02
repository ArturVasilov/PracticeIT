using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    interface StackQueue<T>
    {
        void push(T element);

        T pop();

        T peek();

        void pushAll(IEnumerable<T> collection);

        void clear();

        int size();

        bool isEmpty();
    }
}
