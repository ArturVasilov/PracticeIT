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

        public List<Programmer.NameIdPair> getAllProgrammers
        {
            get 
            {
                return database.getAllProgrammers;
            }
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

        public List<DocumentsForm.TableNameIdValueTriple> AllDocuments { get { return database.AllDocuments; } }

        internal void editProgrammer(Programmer programmer)
        {
            database.editProgrammer(programmer);
        }

        internal void editProject(Project project)
        {
            database.editProject(project);
        }

        internal void editFinance(Finance finance)
        {
            database.editFinance(finance);
        }

        internal void editReport(Report report)
        {
            database.editReport(report);
        }

        internal void remove(string tableName, int id)
        {
            database.remove(tableName, id);
        }

        internal List<int> createIdsListFromSkillsList(List<string> list)
        {
            return database.createIdsListFromSkillsList(list);
        }

        internal Report getReportById(int id)
        {
            return database.getReportById(id);
        }

        internal Finance getFinanceById(int id)
        {
            return database.getFinanceById(id);
        }

        internal Programmer getProgrammerById(int id)
        {
            return database.getProgrammerById(id);
        }

        internal Project getProjectById(int id)
        {
            return database.getProjectById(id);
        }

        internal string getSkillsByIds(List<int> list)
        {
            return database.getSkillsByIds(list);
        }

    }
}
