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
            this.expr = new ExpressionFormater(expr).rightExpressionString();
        }

        private String scobExpr(String expr)
        {
            //delete all '(' and ')' from expression
            String s = "";
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    String someRes = "";
                    i++;
                    while (i < expr.Length && expr[i] != ')')
                    {
                        if (expr[i] == '(')
                        {
                            someRes += scobExpr(expr.Substring(i));
                            break;
                        }
                        someRes += expr[i];
                        i++;
                    }
                    s += exprResult(someRes);    
                }
            }
            return s;
        }

        public double expressionResult()
        {
            return exprResult(scobExpr(expr));
        }

        private bool stringHasScob(String expr)
        {
            for (int i = 0; i < expr.Length; i++)
                if (expr[i] == '(' || expr[i] == ')')
                    return true;
            return false;
        }

        private double exprResult(String expr)
        {
            OperandsStack operandsStack = new OperandsStack(expr.Length);
            OperatorsStack operatorsStack = new OperatorsStack(expr.Length);

            double current_number = 0;
            double result = 0;

            int i = 0;
            //first symbol - number
            current_number = (int)expr[i] - (int)'0';
            i++;
            int n = expr.Length;
            while (i < n)
            {
                if (isNumber(expr[i]))
                {
                    current_number *= 10;
                    current_number += (int)expr[i] - (int)'0';
                    i++;
                }

                else //sign
                {
                    operandsStack.pushBack(current_number);
                    current_number = 0;
                    operatorsStack.pushBack(expr[i]);
                    i++;
                }
            }
            operandsStack.pushBack(current_number);
            //production or division
            //a + b + c * b
            //0 0 1 1 2 2 3
            for (int j = 0; j < operatorsStack.getCount(); j++)
            {
                if (operatorsStack.getOperator(j) == PRODUCTION ||
                    operatorsStack.getOperator(j) == DIVISION)
                {
                    double first = operandsStack.popOperand(j);
                    double second = operandsStack.popOperand(j);
                    char sign = operatorsStack.popOperator(j);
                    operandsStack.pushOperand(doMathFromSymbol(sign, first, second), j);
                    j--;
                }
            }

            for (int j = 0; j < operatorsStack.getCount(); j++)
            {
                if (operatorsStack.getOperator(j) == MINUS)
                {
                    double first = operandsStack.popOperand(j);
                    double second = operandsStack.popOperand(j);
                    char sign = operatorsStack.popOperator(j);
                    operandsStack.pushOperand(doMathFromSymbol(sign, first, second), j);
                }
            }

            while (operandsStack.getCount() > 0)
            {
                result = doMathFromSymbol(PLUS,
                    operandsStack.popOperand(operandsStack.getCount() - 1), result); 
            }
            return result;
        }

        private bool isSign(char c)
        {
            return (c == PLUS) || (c == MINUS) || (c == PRODUCTION) || (c == DIVISION);
        }

        private bool isNumber(char c)
        {
            return (c >= '0' && c <= '9');
        }

        private double doMathFromSymbol(char chOperator, double second, double first)
        {
            switch (chOperator)
            {
                case PLUS:
                    return second + first;
                case MINUS:
                    return second - first;
                case PRODUCTION:
                    return second * first;
                case DIVISION:
                    return second / first;
                default:
                    throw new Exception("Smth strange with operator!!");
            }
        }
        
        private bool isSecondHigherFirst(char firstSign, char secondSign)
        {
            if (firstSign == PRODUCTION || firstSign == DIVISION)
                return false;

            if (secondSign == PRODUCTION || secondSign == DIVISION)
                return true;

            if (secondSign == MINUS && firstSign == PLUS)
                return true;

            return false;
        }
    }

}

