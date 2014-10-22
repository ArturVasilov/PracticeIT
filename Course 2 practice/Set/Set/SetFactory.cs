using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    class SetFactory
    {
        private SetFactory() { }

        public static Set<T> unite<T>(Set<T> set, IEnumerable<T> collection)
        {
            Set<T> result = new ListSet<T>();
            result.addAll(set);
            result.addAll(collection);
            return result;
        }

        public static Set<T> intersect<T>(Set<T> set, IEnumerable<T> collection)
        {
            Set<T> result = new ListSet<T>();
            foreach (T element in set)
            {
                if (collection.Contains(element))
                {
                    result.add(element);
                }
            }
            return result;
        }

        public static Set<T> difference<T>(Set<T> set, IEnumerable<T> collection)
        {
            Set<T> result = new ListSet<T>();
            foreach (T element in set)
            {
                if (!collection.Contains(element))
                {
                    result.add(element);
                }
            }
            return result;
        }

    }
}
