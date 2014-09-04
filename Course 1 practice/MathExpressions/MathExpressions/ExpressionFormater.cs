using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class ExpressionFormater
    {
        private String expr;

        private const char PLUS = '+';
        private const char MINUS = '-';
        private const char PRODUCTION = '*';
        private const char DIVISION = '/';

        public String getExpr()
        {
            return expr;
        }

        public ExpressionFormater(String expr)
        {
            this.expr = expr;
        }

        public String rightExpressionString()
        {
            expr = deleteIrrSymbols(expr);
            if (rightString(expr))
            {
                StackScobs stack = new StackScobs(expr);
                if (stack.checkScobs())
                    return expr;
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
                if (sc == '(')
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

                return (pointer == 0);
            }
        }

        private bool rightString(String checkString)
        {
            if (checkString.Equals("")) return false;

            int n = checkString.Length;
            for (int i = 0; i < n; i++)
            {
                if (checkString[i] == '(' && (i < n - 1) &&
                    (isSign(checkString[i + 1]) && checkString[i + 1] != MINUS))
                    return false;

                if (isSign(checkString[i]) && checkString[i] == ')')
                    return false;
            }
            return true;
        }

        private bool isRightSymbol(char c)
        {
            return (c >= '0' && c <= '9') || (isSign(c)) || (c == '(') || (c == ')');
        }

        private bool isSign(char c)
        {
            return (c == PLUS) || (c == MINUS) || (c == PRODUCTION) || (c == DIVISION);
        }

        private String deleteIrrSymbols(String expr)
        {
            for (int i = 0; i < expr.Length; i++)
                if (!isRightSymbol(expr[i]))
                {
                    expr = expr.Remove(i, 1);
                    i--;
                }
            return expr;
        }
    }
}
