using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class OneWayList<T> : ILinked_List<T>
    {
        class Refer
        {
            //класс, описывающий элемент связного списка
            public T data;
            public Refer Next;

            public Refer(T data)
            {
                this.data = data;
            }
        }

        Refer first_element;
        Refer last_element;
        Refer current_element;
        int count = 0;
        int current_index = 0;

        Refer Get_Element(int index)
        {
            if (index > count || index < 1)
                throw new Exception("There are no element this such index");
            if (index == 1)
                return first_element;
            if (index == count)
                return last_element;

            if (current_index >= index || current_element == null)
            {
                current_index = 1;
                current_element = first_element;
            }
            while (current_index < index)
            {
                current_element = current_element.Next;
                current_index++;
            }
            return current_element;
        }
        public T Get_Element_Data(int index)
        {
            return Get_Element(index).data;
        }

        public void Ins_Front(T data)
        {
            Refer ins_refer = new Refer(data);
            if (count == 0)
            {
                first_element = ins_refer;
                last_element = ins_refer;
            }
            else
            {
                ins_refer.Next = first_element;
                first_element = ins_refer;
            }
            count++;
        }
        public void Ins_Back(T data)
        {
            Refer ins_refer = new Refer(data);
            if (count == 0)
            {
                first_element = ins_refer;
                last_element = ins_refer;
            }
            else
            {
                last_element.Next = ins_refer;
                last_element = ins_refer;
            }
            count++;
        }
        public void Ins_Element(T data, int index)
        {
            if (index < 1 || index > count + 1)
                throw new Exception("Index is bad!!");

            if (count == 0 || index == 1)
                Ins_Front(data);
            else if (index == count + 1)
                Ins_Back(data);

            else
            {
                Refer ins_refer = new Refer(data);
                Refer curr_element = Get_Element(index - 1);

                ins_refer.Next = Get_Element(index);
                curr_element.Next = ins_refer;

                count++;
            }
        }

        public void Delete_Front()
        {
            if (count == 0)
                throw new Exception("List is Empty!!");
            else if (count == 1)
            {
                first_element = null;
                last_element = null;
            }
            else
            {
                first_element = first_element.Next;
            }
            count--;
        }
        public void Delete_Back()
        {
            if (count == 0)
                throw new Exception("List is Empty!!");
            else if (count == 1)
            {
                Delete_Front();
            }
            else
            {
                last_element = Get_Element(count - 1);
                last_element.Next = null;
            }
            count--;
        }
        public void Delete_Element(int index)
        {
            if (index < 1 && index > count)
                throw new Exception("Index is bad");
            if (index == 1) Delete_Front();
            else if (index == count) Delete_Back();

            else
            {
                Refer curr_element = Get_Element(index - 1);
                curr_element.Next = Get_Element(index).Next;
                count--;
            }
        }
        public void Clear_List()
        {
            while (count > 0)
                Delete_Front();
        }

        public int Find_By_Value(T data)
        {
            current_index = 1;
            current_element = first_element;
            while (current_index <= count)
            {
                if (!current_element.data.Equals(data))
                {
                        current_index++;
                        current_element = current_element.Next;
                }
                else return current_index;
            }
            if (current_index > count)
            {
                current_element = first_element;
                current_index = 1;
                throw new Exception("There are no such element!!");
            }
            return 0; //это никогда не произойдет!
        }

        public void Show()
        {
            if (count > 0)
            {
                Console.WriteLine("Datas from the List: ");
                Refer show_element = first_element;
                while (show_element != null)
                {
                    Console.Write(show_element.data + " ");
                    show_element = show_element.Next;
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Unfortunately, there are no elements in the List:(");
        }
        public void Show_Back()
        {
            if (count > 0)
            {
                Console.WriteLine("Datas from the List reversed: ");
                for (int i = count; i > 0; i--)
                {
                    Console.Write(Get_Element(i).data.ToString() + " ");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Unfortunately, List is Empty:(");
        }

    }
}
