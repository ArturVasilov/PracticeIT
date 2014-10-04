using System;

using System.Collections.Generic;

namespace DocumentsSecurity
{
    public class Company
    {
        private Database database;

        private static volatile Company instance;
        private static object syncRoot = new Object();

        private Company() 
        {
            initDataSet();
        }

        private void initDataSet()
        {
            database = new Database();
            database.loadDatabase();
        }

        public void addReport(Report report)
        {
            database.addDocument(report);
        }

        public void addProgrammer(Programmer programmer)
        {
            database.addDocument(programmer);
        }

        public void addProject(Project project)
        {
            database.addDocument(project);
        }

        public void addFinance(Finance finance)
        {
            database.addDocument(finance);
        }

        public void save()
        {
            database.save();
        }

        public Database Database
        {
            get { return database; }
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
