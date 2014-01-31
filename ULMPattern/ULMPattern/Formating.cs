using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMPattern
{
    public static class Formating
    {
        public static String formatClassName(String name)
        {
            name = formatFirstLetter(name, "C");
            name = formatString(name);
            return name;
            //return formatString(formatFirstLetter(name, "C"));
        }

        public static String formatType(String type)
        {
            return formatString(formatFirstLetter(type, "t"));
        }

        public static String formatField(String name)
        {
            return formatString(formatFirstLetter(name, "f"));
        }

        public static String formatAttribute(String name)
        {
            return formatString(formatFirstLetter(name, "a"));
        }

        public static String formatMehtod(String name)
        {
            return formatString(formatFirstLetter(name, "m"));
        }

        private static bool isTrueLetter(char c)
        {
            return ((c >= '0' && c <= '9') || (c == '_') ||
                (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }
        private static bool isTrueFirstLetter(char c)
        {
            return ((c == '_') ||
                (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }

        private static String formatFirstLetter(String s, String first_letter)
        {
            if (!isTrueFirstLetter(s[0]))
                s = s.Insert(0, first_letter);
            return s;
        }
        private static String formatString(String s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!isTrueLetter(s[0]))
                    s = s.Remove(i, 1);
            return s;
        }
    }
}
