using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface List<T>
    {
        int size();
        bool isEmpty();

        void append(T data);
        void prepend(T data);
        void insert(T data, int index);

        void append(LinkedList<T> list);
        void prepend(LinkedList<T> list);
        void insert(LinkedList<T> list, int index);

        void removeBack();
        void removeFront();
        void remove(int index);

        void clear();

        LinkedList<T> subList(int startIndex);
        LinkedList<T> subList(int startIndex, int endIndex);

        T first();
        T last();
        T get(int index);
        int getIndexByValue(T data);

        bool contains(T data);

        T[] toArray();

        bool equals(LinkedList<T> list);
        String toString();
    }
}
