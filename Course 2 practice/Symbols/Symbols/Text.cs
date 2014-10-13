using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols
{
    class Text
    {
        private StringBuilder builder;

        private string Value { get { return builder.ToString(); } }

        private static Random rnd = new Random();

        public Text()
        {
            builder = new StringBuilder();
        }

        public Text(string s)
        {
            builder = new StringBuilder(s);
        }

        public Text(StringBuilder sb)
        {
            if (sb == null)
            {
                throw new ArgumentException("StringBuilder argument is null!");
            }
            this.builder = sb;
        }

        public static Text newRandomInstance()
        {
            StringBuilder builder = new StringBuilder();
            int len = rnd.Next(1, 21);
            for (int i = 0; i < len; i++)
            {
                builder.Append(rnd.Next(1, 100));
            }
            return new Text(builder);
        }

        public static Text RandomWord()
        {
            StringBuilder builder = new StringBuilder();
            int len = rnd.Next(1, 15);
            for (int i = 0; i < len; i++)
            {
                builder.Append(RandomChar());
            }
            return new Text(builder);
        }

        public static Text RandomText()
        {
            StringBuilder builder = new StringBuilder();
            int wordsCount = rnd.Next(1, 200);
            for (int i = 0; i < wordsCount; i++)
            {
                builder.Append(RandomWord().builder);
                builder.Append(RandomSymbol());
                builder.Append(' ');
            }
            return new Text(builder);
        }

        private static char RandomChar()
        {
            return rnd.Next(5) == 0 ? (char)rnd.Next('A', 'Z' + 1) : (char)rnd.Next('a', 'z' + 1);
        }

        private static char RandomSymbol()
        {
            int index = rnd.Next(5);
            switch (index)
            {
                case 0:
                    return '.';

                case 1:
                    return ',';

                case 2:
                    return '!';

                case 3:
                    return '?';

                case 4:
                    return ':';

                default:
                    //lol, it'll never happen
                    return '$';
            }
        }

        public Text Append(string s)
        {
            builder.Append(s);
            return this;
        }

        public Text Append(Object obj)
        {
            builder.Append(obj);
            return this;
        }

        public Text Reverse()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.builder.Length; i++)
            {
                builder.Append(this.builder[this.builder.Length - i - 1]);
            }
            this.builder = builder;
            return this;
        }

        public Text RemoveCentral()
        {
            int len = Length;
            if (len % 2 == 1)
            {
                this.builder.Remove(len / 2 + 1, 1);
            }
            return this;
        }

        public int Length { get { return builder.Length; } }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator Text(string s)
        {
            return new Text(s);
        }
    }
}
