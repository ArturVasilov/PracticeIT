using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols
{
    class MyString
    {
        private String value { get; set; }

        private static Random rnd = new Random();

        public MyString(string value)
        {
            this.value = value;
        }

        public static MyString newRandomInstance()
        {
            StringBuilder builder = new StringBuilder();
            int len = rnd.Next(1, 21);
            for (int i = 0; i < len; i++)
            {
                builder.Append(rnd.Next(1, 100));
            }
            return new MyString(builder.ToString());
        }

        public static MyString newNumberInstance()
        {
            StringBuilder builder = new StringBuilder();
            int len = rnd.Next(1, 21);
            for (int i = 0; i < len; i++)
            {
                builder.Append(rnd.Next('0', '9' + 1));
            }
            return new MyString(builder.ToString());
        }

        public override string ToString()
        {
            return value;
        }

        public char this[int index]
        {
            get { return value[index]; }
        }

        public bool isLower()
        {
            foreach (char c in value)
            {
                if (!isLower(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isUpper()
        {
            foreach (char c in value)
            {
                if (!isUpper(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void toUpper()
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in value)
            {
                builder.Append(toUpper(c));
            }
            value = builder.ToString();
        }

        public void toLower()
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in value)
            {
                builder.Append(toLower(c));
            }
            value = builder.ToString();
        }

        public bool isNumber()
        {
            foreach (char c in value)
            {
                if (!isDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isUpper(char value)
        {
            return value >= 'A' && value <= 'Z';
        }

        public bool isLower(char value)
        {
            return value >= 'a' && value <= 'z';
        }

        public char toUpper(char value)
        {
            if (isLower(value))
            {
                return (char)(value - 'a' + 'A');
            }
            return value;
        }

        public char toLower(char value)
        {
            if (isUpper())
            {
                return (char)(value - 'A' + 'a');
            }
            return value;
        }

        public bool isDigit(char value)
        {
            return value >= '0' && value <= '9';
        }

        public static explicit operator int(MyString myString)
        {
            if (myString.isNumber())
            {
                return Convert.ToInt32(myString.value);
            }
            throw new ArgumentException("Casting string to number failed!");
        }

        public static implicit operator MyString(int x)
        {
            return new MyString(x.ToString());
        }

        public static implicit operator MyString(string s)
        {
            return new MyString(s);
        }
    }
}
