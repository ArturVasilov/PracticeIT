using System;

using System.Collections.Generic;

namespace DocumentsSecurity
{
    class Company
    {
        public const string FILENAME = "alldocuments.xml";

        private XmlController xml;

        private static volatile Company instance;
        private static object syncRoot = new Object();

        private LinkedList<Document> allDocuments;

        private Company() 
        {
            //TODO : change to XmlSecurityWrapper
            xml = new XmlController(FILENAME);
            allDocuments = new LinkedList<Document>();
        }

        public void addDocument(Document document)
        { 
            if (document == null)
            {
                throw new ArgumentNullException("tried to add null reference for a document");
            }
            xml.addDocument(document);
            allDocuments.AddLast(document);
        }

        public void addProgrammer(Programmer programmer)
        {
            if (programmer == null)
            {
                throw new ArgumentNullException("tried to add null reference for a programmer document");
            }
            xml.addProgrammer(programmer);
            allDocuments.AddLast(programmer);
        }

        public void addProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("tried to add null reference for a project document");
            }
            xml.addProject(project);
            allDocuments.AddLast(project);
        }

        public void addFinance(Finance finance)
        {
            if (finance == null)
            {
                throw new ArgumentNullException("tried to add null reference for a finance document");
            }
            xml.addFinance(finance);
            allDocuments.AddLast(finance);
        }

        public static Company Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Company();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
