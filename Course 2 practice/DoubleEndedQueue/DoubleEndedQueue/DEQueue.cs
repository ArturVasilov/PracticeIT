using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    interface DEQueue<T> : IEnumerable<T>
    {
        void addFront(T element);

        void addBack(T element);

        T popFront();

        T popBack();

        T peekFront();

        T peekBack();

        void addAllBack(IEnumerable<T> collection);

        void addAllFront(IEnumerable<T> collection);

        void clear();

        int size();

        bool isEmpty();
    }
}
