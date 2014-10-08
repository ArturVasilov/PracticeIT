using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber[] array = new RationalNumber[] 
            {
                new RationalNumber(3, 5), new RationalNumber(2, 5), new RationalNumber(1, 5),
                new RationalNumber(4, 5), new RationalNumber(1), new RationalNumber(32, 33),
                new RationalNumber(3, 5), new RationalNumber(2, 5), new RationalNumber(1, 5),
                new RationalNumber(4, 5), new RationalNumber(1), new RationalNumber(32, 33),
            };
                                          
            Console.WriteLine("base array:");
            foreach (RationalNumber rational in array)
            {
                Console.Write(rational + " ");
            }
            Console.WriteLine();
            RationalSorter.sort(array);
            Console.WriteLine("array after sorting:");
            foreach (RationalNumber rational in array)
            {
                Console.Write(rational + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

