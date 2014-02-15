using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class Expression
    {
        private String expr;

        private const char PLUS = '+';
        private const char MINUS = '-';
        private const char PRODUCTION = '*';
        private const char DIVISION = '/';

        public Expression(String expr)
        {
            expr = deleteSpaces(expr);
            if (rightString(expr))
            {
                StackScobs stack = new StackScobs(expr);
                if (stack.checkScobs())
                    this.expr = expr;
                else throw new Exception("Illegal scobs in expression!!");
            }
            else throw new Exception("Illegal Expression!!");
        }

        private class StackScobs
        {
            String str;
            char[] scobs;
            int pointer;
            bool isAllOkYet;

            public String Str
            {
                get { return str; }
                set { str = value; }
            }

            public StackScobs(String str)
            {
                isAllOkYet = true;
                pointer = 0;
                Str = str;
                scobs = new char[Str.Length];
            }

            public StackScobs(int count)
            {
                pointer = 0;
                scobs = new char[count];
            }

            private bool isRigthScob(char sc)
            {
                return (sc == '(' || sc == ')');
            }

            public void putScob(char sc)
            {
                if (sc == ')')
                {
                    scobs[pointer] = sc;
                    pointer++;
                }
                else if (pointer == 0)
                    isAllOkYet = false;
                else pointer--;
            }

            public bool checkScobs() 
            {
                int n = str.Length;
                for (int i = 0; i < n; i++)
                {
                    if (isRigthScob(str[i]))
                        putScob(str[i]);

                    if (!isAllOkYet)
                        return false;
                }
                return true;
            }
        }


        public double exprResult()
        {
            //TODO
            //refactor
            //made just for simple operation (a + b)
            string[] string_values = expr.Split('(', ')', PLUS, MINUS,
                PRODUCTION, DIVISION);
            double[] values = new double[string_values.Length];
            for (int i = 0; i < string_values.Length; i++)
                values[i] = Convert.ToDouble(string_values[i]);

            double result = 0;
            int count = 0;

            StackScobs stack = new StackScobs(expr.Length);
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(' || expr[i] == ')')
                    stack.putScob(expr[i]);
                else if (isSign(expr[i]))
                {
                    //To remake
                    result = doMathFromSymbol(expr[i], values[count], values[count + 1]);
                    count++;
                }
            }
            return result;
        }

        private bool rightString(String checkString)
        {
            int n = checkString.Length;
            for (int i = 0; i < n; i++) 
            {
                if (!isRightSymbol(checkString[i]))
                    return false;

                if (checkString[i] == '(' && 
                    (isSign(checkString[i + 1]) || checkString[i+1] == MINUS))
                    return false;

                if (isSign(checkString[i]) && checkString[i] == ')')
                    return false;
            }
            return true;
        }

        private bool isRightSymbol(char c)
        {
            return (c >= '0' && c <= '9') || isSign(c) || (c == '(') || (c == ')');
        }

        private bool isSign(char c)
        {
            return (c == PLUS) || (c == MINUS) || (c == PRODUCTION) || (c == DIVISION);
        }

        private String deleteSpaces(String expr)
        {
            for (int i = 0; i < expr.Length; i++)
                if (expr[i] == ' ')
                    expr = expr.Remove(i, 1);
            return expr;
        }

        private double doMathFromSymbol(char chOperator, double first, double second)
        {
            switch (chOperator)
            {
                case PLUS:
                    return first + second;
                case MINUS:
                    return first - second;
                case PRODUCTION:
                    return first * second;
                case DIVISION:
                    try
                    {
                        double result = first / second;
                        return result;
                    }
                    catch (DivideByZeroException)
                    {
                        throw new Exception("Divide by zero!!");
                    }
                default:
                    throw new Exception("Smth strange with operator!!");
            }
        }
    }

}
