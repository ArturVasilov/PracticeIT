using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    interface Set<T> : IEnumerable<T>
    {
        bool add(T element);

        bool remove(T element);

        bool contains(T element);

        bool addAll(IEnumerable<T> collection);

        bool removeAll(IEnumerable<T> collection);

        bool containsAll(IEnumerable<T> collection);

        bool isEmpty();

        int size();
    }
}
