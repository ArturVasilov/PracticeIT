using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TwoWaysList<T>: ILinked_List<T>
    {
        class Refer
        {
            //класс, описывающий элемент связного списка
            public T data;
            public Refer Previous;
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

            if (current_element == null)
            {
                current_index = 1;
                current_element = first_element;
            }
            else if (Math.Abs(count - index) < Math.Abs(current_index - index))
            {
                current_index = count;
                current_element = last_element;
                while (current_index != index)
                {
                    current_index--;
                    current_element = current_element.Previous;
                }
                return current_element;
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
            if (count == 0)   //если список пустой
            {
                first_element = ins_refer;
                last_element = ins_refer;
            }
            else
            {
                ins_refer.Next = first_element;
                first_element = ins_refer;
                ins_refer.Next.Previous = ins_refer; 
            }
            count++;
        }
        public void Ins_Back(T data)
        {
            Refer ins_refer = new Refer(data);
            if (count == 0)   //если список пустой
            {
                first_element = ins_refer;
                last_element = ins_refer;
            }
            else
            {
                ins_refer.Previous = last_element;
                last_element = ins_refer;
                ins_refer.Previous.Next = last_element;
            }
            count++;
        }
        public void Ins_Element(T data, int index)
        {
            if (index < 1 || index > count + 1)
            {
                throw new Exception("I cant do this!! Index is bad!!!");
            }
            else
            {
                if (count == 0)
                {
                    Ins_Front(data);
                    return;
                }

                if (index == 1)
                    Ins_Front(data);
                else if (index == count + 1)
                    Ins_Back(data);

                else
                {
                    Refer ins_refer = new Refer(data);
                    Refer curr_element = Get_Element(index);

                    curr_element.Previous.Next = ins_refer;
                    ins_refer.Previous = curr_element.Previous;
                    curr_element.Previous = ins_refer;
                    ins_refer.Next = curr_element;
                    count++;
                }
            }
        } 

        public void Delete_Front()
        {
            if (count == 0)
                throw new Exception("List is empty!!");
            else
            {
                if (first_element.Next != null)
                {
                    first_element.Next.Previous = null;
                }
                first_element = first_element.Next;
            }
            count--;
        }
        public void Delete_Back()
        {
            if (count == 0)
                throw new Exception("List is empty!!");
            if (count == 1)
                Delete_Front();
                else if (last_element.Previous != null)
                {
                    last_element.Previous.Next = null;
                    last_element = last_element.Previous;
                }
            else last_element = null;
            count--;
        }

        public void Delete_Element(int index)
        {
            if (index < 1 || index > count)
            {
                throw new Exception("There are no element with such index!!");
            }
            else
            {
                if (index == 1)
                    Delete_Front();
                else if (index == count)
                    Delete_Back();
                else
                {
                    Refer del_refer = Get_Element(index);

                    del_refer.Previous.Next = del_refer.Next;
                    del_refer.Next.Previous = del_refer.Previous;
                    count--;
                }
            }
        }

        public void Clear_List()
        {
            current_element = first_element;
            while (current_element != null && count > 0)
            {
                current_element = current_element.Next;
                Delete_Front();
            }
        }

        public int Find_By_Value(T data)
        {
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
        }

        public void Show()
        {
            if (count > 0)
            {
                Console.WriteLine("Datas from the List: ");
                Refer show_element = first_element;
                while (show_element != null)
                {
                    Console.Write(show_element.data.ToString() + " ");
                    show_element = show_element.Next;
                }
                Console.WriteLine();
            }
            else Console.Write("Unfortunately, there are no elements in the List:(");
        }
        public void Show_Back()
        {
            if (count > 0)
            {
                Console.WriteLine("Datas from the List reversed: ");
                Refer show_element = last_element;
                while (show_element != null)
                {
                    Console.Write(show_element.data.ToString() + " ");
                    show_element = show_element.Previous;
                }
                Console.WriteLine();
            }
            else Console.Write("Unfortunately, there are no elements in the List:(");
        }
    }
}
