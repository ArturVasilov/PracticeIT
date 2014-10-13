using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols
{
    class Symbol
    {
        private char value { get; set; }

        private static Random rnd = new Random();

        public Symbol(char value)
        {
            this.value = value;
        }

        public static Symbol newLetterInstance()
        {
            bool isUpper = rnd.Next(10) % 2 == 0;
            char c = isUpper ? (char)rnd.Next('a', 'z' + 1) : (char)rnd.Next('A', 'Z' + 1);
            return new Symbol(c);
        }

        public static Symbol newDigitInstace()
        {
            return new Symbol((char) rnd.Next('0', '9' + 1));
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public bool isUpper()
        {
            return value >= 'A' && value <= 'Z';
        }

        public bool isLower()
        {
            return value >= 'a' && value <= 'z';
        }

        public void toUpper()
        {
            if (isLower())
            {
                value = (char)(value - 'a' + 'A');
            }
        }

        public void toLower()
        {
            if (isUpper())
            {
                value = (char)(value - 'A' + 'a');
            }
        }

        public bool isDigit()
        {
            return value >= '0' && value <= '9';
        }

        public static explicit operator int(Symbol symbol)
        {
            if (symbol.isDigit())
            {
                return symbol.value - '0';
            }
            return symbol.value;
        }

        public static implicit operator Symbol(char c)
        {
            return new Symbol(c);
        }

        public static implicit operator Symbol(int x)
        {
            if (x / 10 == 0) 
            {
                return new Symbol((char)(x + '0'));
            }
            return new Symbol((char)x);
        }
    }
}
