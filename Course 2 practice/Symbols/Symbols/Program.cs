using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

using System.Text.RegularExpressions;

namespace Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularExpressions.Task7();

            Console.ReadLine();
        }

        

        private static void TextTest()
        {
            //StringBuilderVersusStringTest();
            //SymbolTest();
            //StringTest();

            Text text = Text.RandomText();
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine(text.Reverse());
            Console.WriteLine();
            Console.WriteLine("size - " + text.Length);
        }

        private static void StringBuilderVersusStringTest()
        {
            const int iterations = 100000;

            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                s.Append(i);
            }
            sw.Stop();
            Console.WriteLine("StringBuilder work time in milliseconds - " + sw.ElapsedMilliseconds.ToString());

            sw = Stopwatch.StartNew();
            String str = "";
            for (int i = 0; i < iterations; i++)
            {
                str += i;
            }
            sw.Stop();
            Console.WriteLine("String work time in milliseconds - " + sw.ElapsedMilliseconds.ToString());
        }

        private static void SymbolTest()
        {
            Symbol symbol = Symbol.newLetterInstance();
            Console.WriteLine(symbol);
            symbol = 'c';
            Console.WriteLine(symbol);
            symbol.toUpper();
            Console.WriteLine(symbol);
            symbol.toLower();
            Console.WriteLine(symbol);
            Console.WriteLine(symbol.isLower());
            Console.WriteLine(symbol.isUpper());
            symbol = Symbol.newDigitInstace();
            Console.WriteLine(symbol);
            symbol = 5;
            Console.WriteLine(symbol.isDigit());
            Console.WriteLine((int)symbol);
            symbol = 'a';
            Console.WriteLine((int)symbol);
        }

        private static void StringTest()
        {
            MyString s = new MyString("55");
            Console.WriteLine(s.isNumber());
            Console.WriteLine(55 == (int)s);
            s = MyString.newNumberInstance();
            Console.WriteLine(s);
            Console.WriteLine(s[0]);
            s = MyString.newRandomInstance();
            Console.WriteLine(s);
            s.toUpper();
            Console.WriteLine(s);
            s.toLower();
            Console.WriteLine(s);
            s = "AAA";
            Console.WriteLine(s);
            Console.WriteLine(s.isUpper());
            s.toLower();
            Console.WriteLine(s);
            Console.WriteLine(s.isLower());
        }
    }
}
