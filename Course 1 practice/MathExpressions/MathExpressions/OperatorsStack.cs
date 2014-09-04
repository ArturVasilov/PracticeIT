using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class OperatorsStack
    {
        private const char PLUS = '+';
        private const char MINUS = '-';
        private const char PRODUCTION = '*';
        private const char DIVISION = '/';

        private int count;
        private int pointer = 0;

        private char[] operators;

        public int getCount()
        {
            return pointer;
        }

        public OperatorsStack(int count)
        {
            if (count < 0)
                throw new Exception("Illegal capacity!");
            this.count = count;
            operators = new char[count];
            for (int i = 0; i < this.count; i++)
                operators[i] = '\0';
        }

        public void pushOperator(char myOperator, int index)
        {
            if (index < 0 || index > pointer)
                throw new Exception("Illegal index!");
            for (int i = count - 1; i > index; i--)
                operators[i] = operators[i - 1];
            operators[index] = myOperator;
            pointer++;
        }

        public char getOperator(int index)
        {
            if (index < 0 || index >= pointer)
                throw new Exception("Illegal index!");
            return operators[index];
        }

        public char popOperator(int index)
        {
            if (index < 0 || index >= pointer)
                throw new Exception("Illegal index!");
            pointer--;
            char result = operators[index];
            for (int i = index; i < count - 1; i++)
                operators[i] = operators[i + 1];
            return result;
        }

        public void pushBack(char myOperator)
        {
            pushOperator(myOperator, pointer);
        }
    }
}
