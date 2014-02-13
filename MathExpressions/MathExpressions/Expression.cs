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
                if (StackScobs.checkScobs(expr))
                    this.expr = expr;
                else throw new Exception("Illegal scobs in expression!!");
            else throw new Exception("Illegal Expression!!");
        }


        private static class StackScobs
        {
            String str;

            public String Str
            {
                get { return str; }
                set { str = value; }
            }

            public StackScobs(String str)
            {
                Str = str;
            }

            public static bool checkScobs(String checkString) 
            {
                return true;
            }
        }


        public double exprResult()
        {
            return 0;
        }

        private bool rightString(String checkString)
        {
            return true;
        }
    }

}
