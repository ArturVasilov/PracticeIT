using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class ExpressionGenerator
    {
        public ExpressionGenerator()
        {

        }

        public String[] gen(int n)
        {
            String[] expressions = new String[n];
            for (int i = 0; i < n; i++)
                expressions[i] = generateExpression();
            return expressions;
        }

        private String generateExpression()
        {
            String expression = "";
            Random rnd = new Random();
            int len = rnd.Next() % 100;
            
            for (int i = 0; i < len; i++)
            {
                int a = rnd.Next() % 3;
                switch (a)
                {
                    case 0:
                        expression += rnd.Next() % 10;
                        break;
                    case 1:
                        int b = rnd.Next() % 4;
                        switch (b)
                        {
                            case 0:
                                expression += "+";
                                break;
                            case 1:
                                expression += "-";
                                break;
                            case 2:
                                expression += "*";
                                break;
                            case 3:
                                expression += "/";
                                break;
                        }
                        break;
                    default:
                        expression += rnd.Next() % 10;
                        break;
                }
            }
            return expression;
        }
    }
}
