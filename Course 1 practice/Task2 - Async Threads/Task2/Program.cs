using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace Task2
{
    class Program
    {
        static List<string> strs = new List<string>();
        static List<int> sums = new List<int>();

        static bool isEnd = false;

        static ManualResetEvent ev12 = new ManualResetEvent(false);
        static ManualResetEvent ev23 = new ManualResetEvent(false);

        static void Main(string[] args)
        {
            Thread RFFile = new Thread(new ThreadStart(Read_From_FileF));
            Thread Act = new Thread(new ThreadStart(Transf_And_Sum_ValuesF));
            Thread WTFile = new Thread(new ThreadStart(Write_To_FileF));

            RFFile.Start();
            Act.Start();
            WTFile.Start();
        }

        public static void Read_From_FileF()
        {
            StreamReader fi = new StreamReader("input.txt");
            while (!fi.EndOfStream)
            {
                string s = fi.ReadLine();
                lock (strs)
                {
                    strs.Add(s);
                }
                ev12.Set();
            }
            isEnd = true;
            fi.Close();
        }

        public static void Transf_And_Sum_ValuesF()
        {
            while (!isEnd || strs.Count > 0)
            {
                if (strs.Count == 0) ev12.WaitOne();
                int sum = 0;
                string[] s_work = strs[0].Split(new char[] { ' ', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);
                strs.RemoveAt(0);
                for (int i = 0; i < s_work.Length; i++)
                {
                    sum += Convert.ToInt32(s_work[i]);
                }
                sums.Add(sum);
                ev23.Set();
            }
        }

        public static void Write_To_FileF()
        {
            StreamWriter fw = new StreamWriter("output.txt");
            while (!isEnd || sums.Count > 0)
            {
                if (sums.Count == 0) ev23.WaitOne();
                lock (sums)
                {
                    fw.WriteLine(sums[0].ToString());
                }
                sums.RemoveAt(0);
            }
            fw.Close();
        }
    }
}
