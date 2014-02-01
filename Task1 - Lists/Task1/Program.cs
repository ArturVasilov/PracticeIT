using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //односвязный список
            OneWayList<int> a = new OneWayList<int>();
            a.Ins_Front(5);
            a.Ins_Front(10);
            a.Ins_Front(100);
            a.Ins_Front(105);
            a.Ins_Front(106);
            a.Ins_Front(108);
            a.Ins_Back(99);
            a.Ins_Element(18, 3);
            a.Ins_Element(199, 5);
            a.Ins_Element(199, 6);
            a.Ins_Back(99);
            a.Show();

            a.Delete_Front();
            a.Show();
            a.Delete_Back(); 
            a.Show();
            a.Delete_Element(4);
            a.Show();

            Console.WriteLine(a.Find_By_Value(5));
            Console.WriteLine(a.Get_Element_Data(3));

            a.Clear_List();
            a.Show();

            //Двусвязный список
            TwoWaysList<int> b = new TwoWaysList<int>();
            b.Ins_Front(5);
            b.Ins_Front(10);
            b.Ins_Front(100);
            b.Ins_Front(105);
            b.Ins_Front(106);
            b.Ins_Front(108);
            b.Show();
            b.Ins_Back(99);
            b.Show();
            b.Ins_Element(5, 2);
            b.Show();
            b.Show_Back();

            b.Delete_Front();
            b.Show();
            b.Delete_Back();
            b.Show();
            b.Delete_Element(4);
            b.Show();

            Console.WriteLine(b.Find_By_Value(5));
            Console.WriteLine(b.Get_Element_Data(3));

            b.Clear_List();
            b.Show();

            Console.ReadLine();
        }
    }
}
