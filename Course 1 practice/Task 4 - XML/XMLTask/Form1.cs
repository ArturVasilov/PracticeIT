using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XMLTask
{
    public partial class Form1 : Form
    {
       [XmlRoot("Person")]struct Person
        {
            [XmlElement("fgf")]public string FirstName;
            [XmlAttribute("ghh")]public string LastName;
            public string SecondName;

            public int Age;
            public string Id;
        }

        List<Person> PersonCreating = new List<Person>(); //список людей для добавления в файл
        List<Person> PersonFromXml = new List<Person>(); //список людей, считываемых из файла

        private int RedactingPersonIndex = -1; 

        public Form1()
        {
            InitializeComponent();
        }

        private void AddPeopleToListOfCreatingButton_Click(object sender, EventArgs e)
        {
            XmlSerializer xmml = new XmlSerializer(typeof(Person));
            int age = 0;
            try
            {
                age = Convert.ToInt32(AgeEditN.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неправильно введен возраст!");
            }
            if (age < 0 || age >= 200)
                throw new Exception("Неправильно указан возраст!");

            PersonCreating.Add(CreatePersonToAddToList(LastNameEditN.Text, 
                FirstNameEditN.Text, SecondNameEditN.Text, IdEditN.Text, age));
            MessageBox.Show("Добавлен: " + FirstNameEditN.Text + " " + LastNameEditN.Text);
        }

        private void CreateXmlFileButton_Click(object sender, EventArgs e)
        {
            string filepath;
            if (NameOfCreatingXml.Text == "")
                filepath = "file.xml";
            else
                filepath = NameOfCreatingXml.Text;

            //создаем заготовку xml-файла
            XmlTextWriter textWritter = new XmlTextWriter(filepath, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("persons");
            textWritter.WriteEndElement();
            textWritter.Close();

            //начинаем записывать туда людей
            XmlDocument document = new XmlDocument();

            FileStream fin = new FileStream(filepath, FileMode.Open);
            document.Load(fin);

            for (int i = 0; i < PersonCreating.Count; i++)
            {
                WritePersonToXml(PersonCreating[i], document);
            }
            fin.Close();
            document.Save(filepath);
        }

        private void WritePersonToXml(Person p, XmlDocument document)
        {
            XmlElement person = document.CreateElement("Person");
            person.SetAttribute("id", p.Id);

            XmlElement FIO = document.CreateElement("FIO");

            XmlText LastName = document.CreateTextNode(p.LastName + " ");
            XmlText FirstName = document.CreateTextNode(p.FirstName + " ");
            XmlText SecondName = document.CreateTextNode(p.SecondName);

            FIO.AppendChild(LastName);
            FIO.AppendChild(FirstName);
            FIO.AppendChild(SecondName);

            XmlElement Age = document.CreateElement("Age");
            XmlText age = document.CreateTextNode(p.Age.ToString());
            Age.AppendChild(age);

            person.AppendChild(FIO);
            person.AppendChild(Age);

            document.DocumentElement.AppendChild(person);
        }

        private Person CreatePersonToAddToList(string last_name, string first_name,
            string second_name, string id, int age)
        {
            Person p = new Person();
            p.FirstName = first_name;
            p.LastName = last_name;
            p.SecondName = second_name;
            p.Id = IdEditN.Text;
            p.Age = age;

            return p;
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            string filepath;
            if (SelectedFileEdit.Text == "")
                filepath = "file.xml";
            else
                filepath = NameOfCreatingXml.Text;
            //открываем редактируемый файл
            XmlDocument document = new XmlDocument();
            FileStream fout = new FileStream(filepath, FileMode.Open);
            document.Load(fout);

            //считываем данные из файла
            ReadPersonsFromXmlToList(document);
            //добавляем в выпадающий список
            for (int i = 0; i < PersonFromXml.Count; i++)
                itemsAtXmlFile.Items.Add(PersonFromXml[i].FirstName + " " +
                    PersonFromXml[i].LastName);

            PanelOfChangingXml.Enabled = true;
            fout.Close();
        }

        private void ReadPersonsFromXmlToList(XmlDocument document)
        {
            //список для хранения xml-тегов
            XmlNodeList list = document.GetElementsByTagName("Person");
                for (int i = 0; i < list.Count; i++)  
                {
                    XmlElement id = (XmlElement)document.GetElementsByTagName("Person")[i]; 
                    XmlElement FIO = (XmlElement)document.GetElementsByTagName("FIO")[i];   
                    XmlElement Age = (XmlElement)document.GetElementsByTagName("Age")[i];

                    //считываем и преобразуем
                    string id_p;
                    string[] Names;
                    int age_p;

                    id_p = id.InnerText;
                    Names = FIO.InnerText.Split(' ');

                    age_p = Convert.ToInt32(Age.InnerText);

                    //добавляем людей в список для работы с ними
                    PersonFromXml.Add(CreatePersonToAddToList(Names[0], Names[1],
                        Names[2], id_p, age_p));
                }
        }

        private void itemsAtXmlFile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RedactingPersonIndex = itemsAtXmlFile.SelectedIndex;
            FirstNameEdit.Text = PersonFromXml[RedactingPersonIndex].FirstName;
            LastNameEdit.Text = PersonFromXml[RedactingPersonIndex].LastName;
            SecondNameEdit.Text = PersonFromXml[RedactingPersonIndex].SecondName;
            IdEdit.Text = PersonFromXml[RedactingPersonIndex].Id;
            AgeEdit.Text = PersonFromXml[RedactingPersonIndex].Age.ToString();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (RedactingPersonIndex == -1)
                throw new Exception("Вы не выбрали человека для редактирования!");
            int age = 0;
            try
            {
                age = Convert.ToInt32(AgeEdit.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неправильно введен возраст!");
            }
            if (age < 0 || age >= 200)
                throw new Exception("Неправильно указан возраст!");

            //вносим изменения
            Person p = CreatePersonToAddToList(LastNameEdit.Text, FirstNameEdit.Text,
                SecondNameEdit.Text, IdEdit.Text, age);
            PersonFromXml[RedactingPersonIndex] = p;

            MessageBox.Show("Изменен: " + FirstNameEdit.Text + " " + LastNameEdit.Text);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            //функция, просто переписывающая файл 
            string filepath;
            if (SelectedFileEdit.Text == "")
                filepath = "file.xml";
            else
                filepath = NameOfCreatingXml.Text;

            XmlTextWriter textWritter = new XmlTextWriter(filepath, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("persons");
            textWritter.WriteEndElement();
            textWritter.Close();

            XmlDocument document = new XmlDocument();

            FileStream fin = new FileStream(filepath, FileMode.Open);
            document.Load(fin);

            for (int i = 0; i < PersonCreating.Count; i++)
            {
                WritePersonToXml(PersonFromXml[i], document);
            }
            fin.Close();
            document.Save(filepath);
        }

    }

}