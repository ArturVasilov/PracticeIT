using System;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace DocumentsSecurity
{
    class XmlController
    {
        private string fileName;

        public XmlController(string fileName)
        {
            this.fileName = fileName;
        }

        public void addDocument(Document document)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement documentElement = xmlDocument.CreateElement("document");
            documentElement.SetAttribute("id", document.Id.ToString());

            XmlElement descriptionElement = xmlDocument.CreateElement("description");
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(document.Description));

            documentElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.AppendChild(documentElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public void addProgrammer(Programmer programmer)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement programmerElement = xmlDocument.CreateElement("document");
            programmerElement.SetAttribute("id", programmer.Id.ToString());
            programmerElement.SetAttribute("type", "employee");

            XmlElement nameElement = xmlDocument.CreateElement("name");
            nameElement.AppendChild(xmlDocument.CreateTextNode(programmer.Name));

            XmlElement salaryElement = xmlDocument.CreateElement("salary");
            salaryElement.AppendChild(xmlDocument.CreateTextNode(programmer.Salary.ToString()));

            XmlElement skillsElement = xmlDocument.CreateElement("skills");
            foreach (string skill in programmer.Skills)
            {
                XmlElement skillElement = xmlDocument.CreateElement("skill");
                skillElement.AppendChild(xmlDocument.CreateTextNode(skill));
                skillsElement.AppendChild(skillElement);
            }

            XmlElement descriptionElement = xmlDocument.CreateElement("description");
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(programmer.Description));

            programmerElement.AppendChild(nameElement);
            programmerElement.AppendChild(salaryElement);
            programmerElement.AppendChild(skillsElement);
            programmerElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.AppendChild(programmerElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public void addProject(Project project)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement projectElement = xmlDocument.CreateElement("document");
            projectElement.SetAttribute("id", project.Id.ToString());
            projectElement.SetAttribute("type", "project");

            XmlElement customerElement = xmlDocument.CreateElement("customer");
            customerElement.AppendChild(xmlDocument.CreateTextNode(project.Customer));

            XmlElement costElement = xmlDocument.CreateElement("cost");
            costElement.AppendChild(xmlDocument.CreateTextNode(project.Cost.ToString()));

            XmlElement dateElement = xmlDocument.CreateElement("date");
            dateElement.AppendChild(xmlDocument.CreateTextNode(project.Date));

            XmlElement performersElement = xmlDocument.CreateElement("performers");
            foreach (string performer in project.PerformersNames)
            {
                XmlElement performerElement = xmlDocument.CreateElement("performer");
                performerElement.AppendChild(xmlDocument.CreateTextNode(performer));
                performersElement.AppendChild(performerElement);
            }

            XmlElement descriptionElement = xmlDocument.CreateElement("description");
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(project.Description));

            projectElement.AppendChild(customerElement);
            projectElement.AppendChild(costElement);
            projectElement.AppendChild(dateElement);
            projectElement.AppendChild(performersElement);
            projectElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.AppendChild(projectElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public void addFinance(Finance finance)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement financeElement = xmlDocument.CreateElement("document");
            financeElement.SetAttribute("id", finance.Id.ToString());
            financeElement.SetAttribute("type", "finance");

            XmlElement expenseElement = xmlDocument.CreateElement("expense");
            expenseElement.AppendChild(xmlDocument.CreateTextNode(finance.Expense.ToString()));

            XmlElement incomeElement = xmlDocument.CreateElement("income");
            incomeElement.AppendChild(xmlDocument.CreateTextNode(finance.Income.ToString()));

            XmlElement profitElement = xmlDocument.CreateElement("profit");
            profitElement.AppendChild(xmlDocument.CreateTextNode(finance.Profit.ToString()));

            XmlElement descriptionElement = xmlDocument.CreateElement("description");
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(finance.Description));

            financeElement.AppendChild(expenseElement);
            financeElement.AppendChild(incomeElement);
            financeElement.AppendChild(profitElement);
            financeElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.AppendChild(financeElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public string FileName
        {
            get { return fileName; }
        }
    }
}
