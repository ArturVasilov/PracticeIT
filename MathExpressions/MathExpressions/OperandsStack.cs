using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class OperandsStack
    {
        private int count;
        private int pointer;

        private double[] operands;

        public int getCount()
        {
            return pointer;
        }

        public OperandsStack(int count)
        {
            if (count < 0)
                throw new Exception("Illegal capacity!");
            this.count = count;
            operands = new double[count];
            for (int i = 0; i < count; i++)
                operands[i] = 0;
            pointer = 0;
        }

        public void pushOperand(double operand, int index)
        {
            if (index < 0 || index > pointer)
                throw new Exception("Illegal index!");
            for (int i = count - 1; i > index; i--)
                operands[i] = operands[i - 1];
            operands[index] = operand;
            pointer++;
        }

        public double getOperand(int index)
        {
            if (index < 0 || index >= pointer)
                throw new Exception("WTF? We have no more operands!");
            return operands[index];
        }

        public double popOperand(int index)
        {
            if (index < 0 || index >= pointer)
                throw new Exception("WTF? We have no more operands!");
            pointer--;
            double result = operands[index];
            for (int i = index; i < count - 1; i++)
                operands[i] = operands[i + 1];
            return result;
        }

        public void pushBack(double operand)
        {
            pushOperand(operand, pointer);
        }
    }
}
