using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            testSet(new TreeSet<int>(11, 15, 13, 17, 19, 21, 25));

            //testSetFactory();

            Console.ReadLine();
        }

        private static void testFactory()
        {
            Set<int> set = new ListSet<int>(1, 5, 3, 7, 9, 11, 15, 12, 14, 2, 8, 20);
            Console.WriteLine("set - " + set);
            List<int> list = new List<int>(new int[] { 2, 4, 6, 8, 15, 21 });
            Console.WriteLine("list - [2, 4, 6, 8, 15, 21]");
            Console.WriteLine("unite - " + SetFactory.unite(set, list));
            Console.WriteLine("intersect - " + SetFactory.intersect(set, list));
            Console.WriteLine("difference - " + SetFactory.difference(set, list));
            Console.WriteLine("difference set with set - " + SetFactory.difference(set, set));
        }

        private static void testSet(Set<int> set)
        {
            Console.WriteLine(set);
            Console.WriteLine("Add value 5, result - " + set.add(5));
            Console.WriteLine(set);
            Console.WriteLine("Add array [12, 13, 14, 22, 23, 24], result - " + set.addAll(new int[] { 12, 13, 14, 22, 23, 24 }));
            Console.WriteLine(set);
            Console.WriteLine("Contains [12, 13, 14] - " + set.containsAll(new int[] { 12, 13, 14 }));
            Console.WriteLine("Remove 11, result - " + set.remove(11));
            Console.WriteLine(set);
            Console.WriteLine("Remove [12, 13, 14] - " + set.removeAll(new LinkedList<int>(new int[] { 12, 13, 14 })));
            Console.WriteLine(set);
        }
    }
}
