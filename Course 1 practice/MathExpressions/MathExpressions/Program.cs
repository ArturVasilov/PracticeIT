using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MathExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionGenerator gener = new ExpressionGenerator();
            String[] str = gener.gen(5);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(str[i]);
            Console.ReadLine();
        }

        private void test()
        {
            StreamReader sw = new StreamReader("input.txt");
            int n = 0;
            #region getN
            try
            {
                n = Convert.ToInt32(sw.ReadLine());
            }
            catch (FormatException)
            {
                throw new Exception("Invalid n!");
            }
            catch (Exception)
            {
                throw new Exception("Something strange with n!");
            }
            #endregion

            StreamWriter sr = new StreamWriter("input.txt");
            String str;
            for (int i = 0; i < n; i++)
            {
                str = sw.ReadLine();
                Expression expr = new Expression(str);
                sr.WriteLine(expr.expressionResult());
            }
            sr.Close();
            sw.Close();
        }
    }
}
