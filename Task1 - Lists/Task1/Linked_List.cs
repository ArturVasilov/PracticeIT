using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ILinked_List<T>
    {
        T Get_Element_Data(int index);

        void Ins_Front(T data);
        void Ins_Back(T data);
        void Ins_Element(T data, int index);

        void Delete_Front();
        void Delete_Back();
        void Delete_Element(int index);
        void Clear_List();
        
        int Find_By_Value(T data);

        void Show();
        void Show_Back();
    }
}
