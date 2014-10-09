using System;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.XPath;

using System.Collections.Generic;

namespace DocumentsSecurity
{
    class XmlController
    {
        /*private string fileName;

        public XmlController(string fileName)
        {
            this.fileName = fileName;
        }

        #region writing to xml
        public void addDocument(Document document)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement documentElement = xmlDocument.CreateElement(Document.DOCUMENT_TAG);
            documentElement.SetAttribute(Document.ID, document.Id.ToString());

            XmlElement descriptionElement = xmlDocument.CreateElement(Document.DESCRIPTION);
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(document.Description));

            documentElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.ChildNodes[0].AppendChild(documentElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public void addProgrammer(Programmer programmer)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement programmerElement = xmlDocument.CreateElement(Programmer.DOCUMENT_TAG);
            programmerElement.SetAttribute(Programmer.ID, programmer.Id.ToString());

            XmlElement nameElement = xmlDocument.CreateElement(Programmer.NAME);
            nameElement.AppendChild(xmlDocument.CreateTextNode(programmer.Name));

            XmlElement salaryElement = xmlDocument.CreateElement(Programmer.SALARY);
            salaryElement.AppendChild(xmlDocument.CreateTextNode(programmer.Salary.ToString()));

            XmlElement skillsElement = xmlDocument.CreateElement(Programmer.SKILLS);
            foreach (string skill in programmer.Skills)
            {
                XmlElement skillElement = xmlDocument.CreateElement(Programmer.SKILL);
                skillElement.AppendChild(xmlDocument.CreateTextNode(skill));//ArturVasilov 
                is creator of this app!
                skillsElement.AppendChild(skillElement);
            }

            XmlElement descriptionElement = xmlDocument.CreateElement(Programmer.DESCRIPTION);
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(programmer.Description));

            programmerElement.AppendChild(nameElement);
            programmerElement.AppendChild(salaryElement);
            programmerElement.AppendChild(skillsElement);
            programmerElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.ChildNodes[1].AppendChild(programmerElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public void addProject(Project project)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement projectElement = xmlDocument.CreateElement(Project.DOCUMENT_TAG);
            projectElement.SetAttribute(Project.ID, project.Id.ToString());

            XmlElement customerElement = xmlDocument.CreateElement(Project.CUSTOMER);
            customerElement.AppendChild(xmlDocument.CreateTextNode(project.Customer));

            XmlElement costElement = xmlDocument.CreateElement(Project.COST);
            costElement.AppendChild(xmlDocument.CreateTextNode(project.Cost.ToString()));

            XmlElement dateElement = xmlDocument.CreateElement(Project.DATE);
            dateElement.AppendChild(xmlDocument.CreateTextNode(project.Date));

            XmlElement performersElement = xmlDocument.CreateElement(Project.PERFORMERS);
            foreach (string performer in project.PerformersNames)
            {
                XmlElement performerElement = xmlDocument.CreateElement(Project.PERFORMER);
                performerElement.AppendChild(xmlDocument.CreateTextNode(performer));
                performersElement.AppendChild(performerElement);
            }

            XmlElement descriptionElement = xmlDocument.CreateElement(Project.DESCRIPTION);
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(project.Description));

            projectElement.AppendChild(customerElement);
            projectElement.AppendChild(costElement);
            projectElement.AppendChild(dateElement);
            projectElement.AppendChild(performersElement);
            projectElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.ChildNodes[2].AppendChild(projectElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }

        public void addFinance(Finance finance)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fin = new FileStream(fileName, FileMode.Open);
            xmlDocument.Load(fin);

            XmlElement financeElement = xmlDocument.CreateElement(Finance.DOCUMENT_TAG);
            financeElement.SetAttribute(Finance.ID, finance.Id.ToString());

            XmlElement incomeElement = xmlDocument.CreateElement(Finance.INCOME);
            incomeElement.AppendChild(xmlDocument.CreateTextNode(finance.Income.ToString()));

            XmlElement expenseElement = xmlDocument.CreateElement(Finance.EXPENSE);
            expenseElement.AppendChild(xmlDocument.CreateTextNode(finance.Expense.ToString()));

            XmlElement profitElement = xmlDocument.CreateElement(Finance.PROFIT);
            profitElement.AppendChild(xmlDocument.CreateTextNode(finance.Profit.ToString()));

            XmlElement descriptionElement = xmlDocument.CreateElement(Finance.DESCRIPTION);
            descriptionElement.AppendChild(xmlDocument.CreateTextNode(finance.Description));

            financeElement.AppendChild(incomeElement);
            financeElement.AppendChild(expenseElement);
            financeElement.AppendChild(profitElement);
            financeElement.AppendChild(descriptionElement);

            xmlDocument.DocumentElement.ChildNodes[3].AppendChild(financeElement);

            fin.Close();

            xmlDocument.Save(fileName);
        }
        #endregion

        #region reading from xml
        public LinkedList<Document> AllDocuments
        {
            get
            {
                LinkedList<Document> documents = new LinkedList<Document>();

                XmlDocument xmlDocument = new XmlDocument();
                FileStream fin = new FileStream(fileName, FileMode.Open);
                xmlDocument.Load(fin);

                XmlNodeList documentsList = xmlDocument.GetElementsByTagName(Document.DOCUMENTS_TAG);

                readSimpleDocuments(documentsList[0].ChildNodes, documents);

                readProgrammerDocuments(documentsList[1].ChildNodes, documents);

                readProjectDocuments(documentsList[2].ChildNodes, documents);

                readFinanceDocuments(documentsList[3].ChildNodes, documents);

                return documents;
            }
        }

        private void readSimpleDocuments(XmlNodeList simpleDocuments, LinkedList<Document> documents)
        {
            foreach (XmlNode simpleDocument in simpleDocuments)
            {
                long id;
                try
                {
                    id = long.Parse(simpleDocument.Attributes[0].Value);
                }
                catch (FormatException)
                {
                    continue;
                }

                string description = simpleDocument[Document.DESCRIPTION].FirstChild.Value;
                description = description == null ? "" : description;

                try
                {
                    documents.AddLast(new Document(id, description));
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private void readProgrammerDocuments(XmlNodeList programmerDocuments, LinkedList<Document> documents)
        {
            foreach (XmlNode programmerDocument in programmerDocuments)
            {
                long id;
                int salary;
                try
                {
                    id = long.Parse(programmerDocument.Attributes[0].Value);
                    salary = Int32.Parse(programmerDocument[Programmer.SALARY].FirstChild.Value);
                }
                catch (FormatException)
                {
                    continue;
                }

                string name = programmerDocument[Programmer.NAME].FirstChild.Value;
                name = name == null ? "" : name;

                XmlNodeList skillsNodes = programmerDocument[Programmer.SKILLS].ChildNodes;
                string[] skills = new string[skillsNodes.Count];
                for (int i = 0; i < skillsNodes.Count; i++)
                {
                    skills[i] = skillsNodes[i].FirstChild.Value;
                    skills[i] = skills[i] == null ? "" : skills[i];
                }

                string description = programmerDocument[Programmer.DESCRIPTION].FirstChild.Value;
                description = description == null ? "" : description;

                try
                {
                    documents.AddLast(new Programmer(id, description, name, salary, skills));
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private void readProjectDocuments(XmlNodeList projectDocuments, LinkedList<Document> documents)
        {
            foreach (XmlNode projectDocument in projectDocuments)
            {
                long id;
                long cost;
                try
                {
                    id = long.Parse(projectDocument.Attributes[0].Value);
                    cost = long.Parse(projectDocument[Project.COST].FirstChild.Value);
                }
                catch (FormatException)
                {
                    continue;
                }

                string customer = projectDocument[Project.CUSTOMER].FirstChild.Value;
                customer = customer == null ? "" : customer;

                string date = projectDocument[Project.DATE].FirstChild.Value;
                date = date == null ? "" : date;

                XmlNodeList performersNodes = projectDocument[Project.PERFORMERS].ChildNodes;
                string[] performers = new string[performersNodes.Count];
                for (int i = 0; i < performersNodes.Count; i++)
                {
                    performers[i] = performersNodes[i].FirstChild.Value;
                    performers[i] = performers[i] == null ? "" : performers[i];
                }

                string description = projectDocument[Project.DESCRIPTION].FirstChild.Value;
                description = description == null ? "" : description;

                try
                {
                    documents.AddLast(new Project(id, description, customer, cost, date, performers));
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private void readFinanceDocuments(XmlNodeList financeDocuments, LinkedList<Document> documents)
        {
            foreach (XmlNode financeDocument in financeDocuments)
            {
                long id;
                long income;
                long expense;
                try
                {
                    id = long.Parse(financeDocument.Attributes[0].Value);
                    income = long.Parse(financeDocument[Finance.INCOME].FirstChild.Value);
                    expense = long.Parse(financeDocument[Finance.EXPENSE].FirstChild.Value);
                }
                catch (FormatException)
                {
                    continue;
                }
                string description = financeDocument[Finance.DESCRIPTION].FirstChild.Value;
                description = description == null ? "" : description;

                try
                {
                    documents.AddLast(new Finance(id, description, income, expense));
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
        #endregion

        public string FileName
        {
            get { return fileName; }
        }
    }*/
    }
}
