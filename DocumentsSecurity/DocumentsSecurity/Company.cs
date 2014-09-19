using System;

using System.Collections.Generic;

using System.Data;

namespace DocumentsSecurity
{
    public class Company
    {
        public const string FILENAME = "alldocuments.xml";

        private DataSet dataSet;

        private static volatile Company instance;
        private static object syncRoot = new Object();

        private Company() 
        {
            dataSet = new DataSet();
            initDataSet();
        }

        private void initDataSet()
        {
            DataTable reportsTable = new DataTable(Report.DOCUMENTS_TYPE);
            //TODO create database
        }

        public void addDocument(Report report)
        { 
            if (report == null)
            {
                throw new ArgumentNullException("tried to add null reference for a document");
            }
        }

        public void addProgrammer(Programmer programmer)
        {
            if (programmer == null)
            {
                throw new ArgumentNullException("tried to add null reference for a programmer document");
            }
        }

        public void addProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("tried to add null reference for a project document");
            }
        }

        public void addFinance(Finance finance)
        {
            if (finance == null)
            {
                throw new ArgumentNullException("tried to add null reference for a finance document");
            }
        }

        public bool containsId(long id)
        {
            return false;
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
