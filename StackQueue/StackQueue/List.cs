using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    interface List<T>
    {
        bool isEmpty();
        void add(T data);
        T pop();
        T peek();
        int size();
        void clear();
    }
}
