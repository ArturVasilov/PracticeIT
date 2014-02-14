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

        public Expression(String expr)
        {
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

            private bool isRigthScob(char sc)
            {
                return (sc == '(' || sc == ')');
            }

            private void putScob(char sc)
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
            return 0;
        }

        private bool rightString(String checkString)
        {
            int n = checkString.Length;
            for (int i = 0; i < n; i++)
                if (!isRightSymbol(checkString[i]))
                    return false;
            return true;
        }

        private bool isRightSymbol(char c)
        {
            return (c >= '0' && c <= '9') || (c == '+') || (c == '-')
                || (c == '*') || (c == '/') || (c == '(') || (c == ')');
        }
    }

}
