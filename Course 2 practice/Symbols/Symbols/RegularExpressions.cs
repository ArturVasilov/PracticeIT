using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Symbols
{
    class RegularExpressions
    {
        private RegularExpressions() { }

        public static void Task1()
        {
            String input = "Java, Sharp, Groovy, C++11, 12, 13, 15, 29, 1, PHP, R, D, Python";
            Console.WriteLine("input text : " + input);
            Console.WriteLine("Type word:");
            String word = Console.ReadLine();
            Regex regex = new Regex(@"\b" + word + @"\b");
            CheckAndPrintAnswer(input, regex);
        }

        public static void Task2()
        {
            String input = "Java, Sharp, Groovy, C++11, 12, 13, 15, 29, 1, PHP, R, D, Python";
            Console.WriteLine("input text : " + input);
            Console.WriteLine("Type length:");
            int len = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"\b[a-z]{" + len + @"}\b");
            CheckAndPrintAnswer(input, regex);
            MatchCollection collection = regex.Matches(input);
            Console.WriteLine("Matches:");
            foreach (Match match in collection)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Task3()
        {
            String input = "Java, Sharp, Groovy, C++11, 12, 13, 15, 29, 1, PHP, R, D, Python";
            Console.WriteLine("input text : " + input);
            Regex regex = new Regex(@"\b[A-Z][a-z]*\b");
            CheckAndPrintAnswer(input, regex);
            MatchCollection collection = regex.Matches(input);
            Console.WriteLine("Matches:");
            foreach (Match match in collection)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Task4()
        {
            String input = "Java, Sharp, Groovy, C++11, 12, 13, 15, 29, 1, PHP, R, D, Python, Lisp, Haskell, F#";
            Console.WriteLine("input text : " + input);
            Regex regex = new Regex(@"\b[0-9]+\b");
            CheckAndPrintAnswer(input, regex);
            MatchCollection collection = regex.Matches(input);
            Console.WriteLine("Matches:");
            int max = Int32.MinValue;
            foreach (Match match in collection)
            {
                int value = int.Parse(match.Value);
                if (value > max)
                {
                    max = value;
                }
                Console.WriteLine(value);
            }
            Console.WriteLine("Max number - " + max);
        }

        public static void Task5()
        {
            String input = "Java, Sharp, Groovy, C++11, 12, 13, 15, 29, 1, PHP, R, D, Python, Lisp, Haskell, F#";
            Console.WriteLine("input text : " + input);
            Regex regex = new Regex(@"\b[0-9]+\b");
            CheckAndPrintAnswer(input, regex);
            MatchCollection collection = regex.Matches(input);
            Console.WriteLine("Matches:");
            int sum = 0;
            foreach (Match match in collection)
            {
                int value = int.Parse(match.Value);
                sum += value;
                Console.WriteLine(value);
            }
            Console.WriteLine("Middle - " + sum * 1.0 / collection.Count);
        }

        public static void RegexDemo()
        {
            String phoneNumber = Console.ReadLine();
            Regex regex = new Regex(@"\d{3}(-\d{2}){2}");
            CheckAndPrintAnswer(phoneNumber, regex);
            MatchCollection collection = regex.Matches(phoneNumber);
            Console.WriteLine("Matches:");
            foreach (Match match in collection)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Task6() 
        {
            String input = "273-91-19, +79197111111, +7(919)7112221, 54466111, +7(9197112221";
            Console.WriteLine("input text : " + input);
            Regex regex = new Regex(@"(\d{3}(-\d{2}){2})|" + @"(\+7\(\d{3}\)\d{7})|" + @"(\+7\d{10})");
            CheckAndPrintAnswer(input, regex);
            MatchCollection collection = regex.Matches(input);
            Console.WriteLine("Matches:");
            foreach (Match match in collection)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Task7()
        {
            //TODO : work with double and negative numbers
            String input = "Java, Sharp, Groovy, C++11, -12, -11, -15, -21, -19, PHP, R, D, Python, Lisp, Haskell, F#";
            Console.WriteLine("input text : " + input);
            Regex regex = new Regex(@"(\-)?[0-9]+");
            CheckAndPrintAnswer(input, regex);
            MatchCollection collection = regex.Matches(input);
            Console.WriteLine("Matches:");
            int max = Int32.MinValue;
            foreach (Match match in collection)
            {
                int value = int.Parse(match.Value);
                if (value > max)
                {
                    max = value;
                }
                Console.WriteLine(value);
            }
            Console.WriteLine("Max number - " + max);
        }

        private static void CheckAndPrintAnswer(String input, Regex regex)
        {
            Console.WriteLine("input - " + input + "; regular expression - " +
                regex + "; matches - " + regex.IsMatch(input));
        }

        
    }
}
