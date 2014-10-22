using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Symbols
{
    class RegularExpression2
    {
        private static string text = "Hello, my Dear Regular Expressions! I will have a good day with you! " +
            "But, here is a problem... You should know, that you\'re rather difficult, should not you? " +
            "But I will deal with you! Today I will use you to remove smth from this text." +
            "I will call you at 20.11.2014 and say that we will meet at 23.11.2014 or 30.11.2014. " +
            "Current time is 11:11, after 2 minutes and 21 second it will be 11:13 hehe.";

        public static void Task1()
        {
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Remove words WHERE LENGTH=1\n");
            Regex regex = new Regex(@"\b[a-zA-Z]\b");
            Console.WriteLine("New text - " + regex.Replace(text, "").ToString());
        }

        public static void Task2()
        {
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Remove punctuations\n");
            Regex regex = new Regex(@"[\.,!\?\-:]");
            Console.WriteLine("New text - " + regex.Replace(text, "").ToString());
        }

        public static void Task3()
        {
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Remove words WHERE starts with VOWEL\n");
            Regex regex = new Regex(@"\b[AEIJOUYaeijouy][A-Za-z]*\b");
            Console.WriteLine("New text - " + regex.Replace(text, "").ToString());
        }

        public static void Task4()
        {
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Replace english words to ...\n");
            Regex regex = new Regex(@"\b[A-Za-z]+\b");
            Console.WriteLine("New text - " + regex.Replace(text, "...").ToString());
        }

        public static void Task5()
        {
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Add 7 days to date\n");
            Regex regex = new Regex(@"\b[0-3][0-9]\.[0-1][0-9]\.\d{4}\b");
            Match match = regex.Match(text);
            while (match.Success)
            {
                DateTime date;
                if (DateTime.TryParse(match.Value, out date))
                {
                    date = date.AddDays(7);
                    text = regex.Replace(text, date.ToShortDateString(), 1, match.Index);
                }
                match = match.NextMatch();
            }
            Console.WriteLine("New text - " + text);
        }

        public static void Task6()
        {
            //TODO
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Replace time from hh:mm:ss to hh:mm\n");
            Regex regex = new Regex(@"\b[0-2][0-9]:[0-6][0-9]:[0-6][0-9]\b");
            Match match = regex.Match(text);
            while (match.Success)
            {
                text = regex.Replace(text, match.Value.Substring(0, 5), 1, match.Index);
                match = match.NextMatch();
            }
            Console.WriteLine("New text - " + text);
        }

        public static void Task7()
        {
            Console.WriteLine("Text - " + text);
            Console.WriteLine();
            Console.WriteLine("Replace time from hh:mm to hh-3:mm+5\n");
            Regex regex = new Regex(@"\b[0-2][0-9]:[0-6][0-9]\b");
            Match match = regex.Match(text);
            while (match.Success)
            {
                string[] value = match.Value.Split(':');
                DateTime time = new DateTime(2014, 10, 20, int.Parse(value[0]), int.Parse(value[1]), 0);
                time = time.AddHours(-3);
                time = time.AddMinutes(+5);
                Console.WriteLine("parsed time - " + time.ToShortTimeString());
                text = regex.Replace(text, match.Value.Substring(0, 5), 1, match.Index);
                match = match.NextMatch();
            }
            Console.WriteLine("New text - " + text);
        }
    }
}
