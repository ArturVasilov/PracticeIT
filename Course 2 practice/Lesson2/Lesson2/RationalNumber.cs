using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lesson2
{
    [Serializable]
    class RationalNumber : IComparable<RationalNumber>
    {
        private const int DEFAULT_VALUE = 0;

        public int a { get; protected set; }

        public int b { get; protected set; }

        protected static Random rnd = new Random();

        #region constructors
        public RationalNumber() : this(DEFAULT_VALUE, DEFAULT_VALUE + 1)
        {
        }

        public RationalNumber(int a) : this (a, a)
        {
        }

        public RationalNumber(int a, int b)
        {
            setValues(a, b);
        }

        public RationalNumber(RationalNumber number)
        {
            a = number.a;
            b = number.b;
        }

        public RationalNumber(string s) : this(Parse(s))
        {
        }
        #endregion

        #region serialization
        private const string SERIALIZATION_FILENAME = "rational.dat";

        public void serialize()
        {
            serialize(SERIALIZATION_FILENAME);
        }

        public RationalNumber deserialize()
        {
            return deserialize(SERIALIZATION_FILENAME);
        }

        public void serialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            formatter.Serialize(fileStream, this);
        }

        public RationalNumber deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                return (RationalNumber)formatter.Deserialize(fileStream);
            } catch (FileNotFoundException)
            {
                throw new ArgumentException("There are no such file");
            }
        }
        #endregion

        private void setValues(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero!");
            }
            int divider = gcd(a, b);
            this.a = a / divider;
            this.b = b / divider;
            if ((a < 0 && b < 0) || b < 0)
            {
                a = -a;
                b = -b;
            }
        }

        #region overriding Objects methods
        public override string ToString()
        {
            if (b == 1)
            {
                return a.ToString();
            }
            return a + "/" + b;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return this == (RationalNumber)obj;
        }

        public override int GetHashCode()
        {
            return a.GetHashCode() + b.GetHashCode();
        }
        #endregion

        public static RationalNumber Parse(string s)
        {
            string[] numbers = s.Split('/');
            try
            {
                return new RationalNumber(Int32.Parse(numbers[0]), Int32.Parse(numbers[1]));
            }
            catch (FormatException)
            {
                throw new ArgumentException("Error parsing string to rational number");
            }
        }

        #region random numbers
        public static RationalNumber random()
        {
            const int MAX = 1000;
            int a = rnd.Next(MAX) + 1;
            int b = rnd.Next(MAX) + 1;
            return new RationalNumber(a, b);
        }

        public static RationalNumber random(int max)
        {
            //TODO
            return new RationalNumber(1, 1);
        }

        public static RationalNumber random(int min, int max)
        {
            //TODO
            return new RationalNumber(1, 1);
        }
        #endregion

        #region file operaions
        public void generateFileWithRandomRationalNumbers(string fileName)
        {
            generateFileWithRandomRationalNumbers(fileName, 10);
        }

        public void generateFileWithRandomRationalNumbers(string fileName, int numbersCount)
        {
            StreamWriter writer = new StreamWriter(fileName);
            for (int i = 0; i < numbersCount; i++)
            {
                writer.WriteLine(RationalNumber.random().ToString());
            }
            writer.Close();
        }

        public void valuesInFileWithRationalNumbers(string fileName, 
            out RationalNumber max, out RationalNumber min, out RationalNumber middle)
        {
            StreamReader reader = new StreamReader(fileName);
            RationalNumber currentMax = new RationalNumber(-100000000, 1);
            RationalNumber currentMin = new RationalNumber(100000000, 1);
            RationalNumber sum = new RationalNumber(0, 1);
            int size = 0;
            while (!reader.EndOfStream)
            {
                RationalNumber current = new RationalNumber(reader.ReadLine());
                if (current > currentMax)
                {
                    currentMax = new RationalNumber(current);
                }
                if (current < currentMin)
                {
                    currentMin = new RationalNumber(current);
                }
                sum += current;
                size++;
            }
            max = currentMax;
            min = currentMin;
            middle = sum / size;
            reader.Close();
        }

        public RationalNumber maxInTwoFirstDifferent(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            RationalNumber firstNumber = RationalNumber.Parse(reader.ReadLine());
            RationalNumber secondNumber = RationalNumber.Parse(reader.ReadLine());
            while (!reader.EndOfStream && firstNumber != secondNumber)
            {
                secondNumber = RationalNumber.Parse(reader.ReadLine());
            }
            reader.Close();
            int compare = firstNumber.CompareTo(secondNumber);
            return compare > 0 ? firstNumber : secondNumber;
        }

        public void printNumbersWithMaxDenominator(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            List<RationalNumber> numbers = new List<RationalNumber>();
            int max = -1000000;
            while (!reader.EndOfStream)
            {
                RationalNumber current = RationalNumber.Parse(reader.ReadLine());
                if (current.b > max)
                {
                    numbers.Clear();
                    max = current.b;
                    numbers.Add(max);
                }
            }
            foreach (RationalNumber number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            reader.Close();
        }
        #endregion

        public int CompareTo(RationalNumber number)
        {
            const double EPS = 0.0000001;
            double a = this;
            double b = number;
            if (Math.Abs(a - b) < EPS)
            {
                return 0;
            }
            return a > b ? 1 : -1;
        }

        #region operations overriding
        public static RationalNumber operator +(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int b = rationalNumber1.b * rationalNumber2.b;
            int a = rationalNumber1.a * rationalNumber2.b + rationalNumber2.a * rationalNumber1.b;
            return new RationalNumber(a, b);
        }

        public static RationalNumber operator -(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            int b = rationalNumber1.b * rationalNumber2.b;
            int a = rationalNumber1.a * rationalNumber2.b - rationalNumber2.a * rationalNumber1.b;
            return new RationalNumber(a, b);
        }

        public static RationalNumber operator *(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber(rationalNumber1.a * rationalNumber2.a, 
                rationalNumber1.b * rationalNumber2.b);
        }

        public static RationalNumber operator /(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return new RationalNumber(rationalNumber1.a * rationalNumber2.b,
                rationalNumber1.b * rationalNumber2.a);
        }

        public static bool operator ==(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.CompareTo(rationalNumber2) == 0;
        }

        public static bool operator !=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.CompareTo(rationalNumber2) != 0;
        }

        public static bool operator >(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.CompareTo(rationalNumber2) > 0;
        }

        public static bool operator <(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.CompareTo(rationalNumber2) < 0;
        }

        public static bool operator >=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.CompareTo(rationalNumber2) >= 0;
        }

        public static bool operator <=(RationalNumber rationalNumber1, RationalNumber rationalNumber2)
        {
            return rationalNumber1.CompareTo(rationalNumber2) <= 0;
        }
        #endregion

        public int gcd(int a, int b)
        {
            //b isn't 0
            if (a == 0 || a == b)
            {
                return b;
            }
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            if (a < b)
            {
                return gcd(b, a);
            }
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        #region implicit & explicit casting with numbers
        public static implicit operator RationalNumber(int x)
        {
            return new RationalNumber(x, 1);
        }

        public static explicit operator int(RationalNumber rationalNumber)
        {
            return rationalNumber.a / rationalNumber.b;
        }

        public static implicit operator double(RationalNumber rationalNumber)
        {
            return 1.0 * rationalNumber.a / rationalNumber.b;
        }

        public static explicit operator float(RationalNumber rationalNumber)
        {
            return (float)(1.0 * rationalNumber.a / rationalNumber.b);
        }
        #endregion
    }
}
