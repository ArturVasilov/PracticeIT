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

        public bool verifyDocuments()
        {
            List<Document> docs = getUnverifiedDocs();
            if (docs.Count == 0)
            {
                return true;
            }
            throw new VerificationException("Verification failed!", docs);
        }

        private void initDataSet()
        {
            database = new Database();
            database.loadDatabase();
        }

        #region add functions
        internal void addReport(Report report)
        {
            database.addDocument(report);
            sign(report);
        }

        internal void addProgrammer(Programmer programmer)
        {
            database.addDocument(programmer);
            sign(programmer);
        }

        internal void addProject(Project project)
        {
            database.addDocument(project);
            sign(project);
        }

        internal void addFinance(Finance finance)
        {
            database.addDocument(finance);
            sign(finance);
        }
        #endregion

        internal void save()
        {
            database.save();
        }

        internal List<Programmer.NameIdPair> getAllProgrammers
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

        internal List<TableNameIdValueTriple> AllDocuments { get { return database.AllDocuments; } }

        #region edit functions
        internal void editProgrammer(Programmer programmer)
        {
            database.editProgrammer(programmer);
            sign(programmer);
        }

        internal void editProject(Project project)
        {
            database.editProject(project);
            sign(project);
        }

        internal void editFinance(Finance finance)
        {
            database.editFinance(finance);
            sign(finance);
        }

        internal void editReport(Report report)
        {
            database.editReport(report);
            sign(report);
        }
        #endregion

        internal void remove(string tableName, int id)
        {
            database.remove(tableName, id);
        }

        internal List<int> createIdsListFromSkillsList(List<string> list)
        {
            return database.createIdsListFromSkillsList(list);
        }

        internal string getSkillsByIds(List<int> list)
        {
            return database.getSkillsByIds(list);
        }

        internal string getPerformersByIds(List<int> list)
        {
            return database.getPerformersByIds(list);
        }

        #region getters
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
        #endregion

        #region word documents
        internal void createWordDocument(string tableName, int id)
        {
            switch (tableName)
            {
                case DatabaseConstants.Programmer.TABLE_NAME:
                    WordDocument.createWordDocument(getProgrammerById(id));
                    break;

                case DatabaseConstants.Project.TABLE_NAME:
                    WordDocument.createWordDocument(getProjectById(id));
                    break;

                case DatabaseConstants.Finance.TABLE_NAME:
                    WordDocument.createWordDocument(getFinanceById(id));
                    break;

                case DatabaseConstants.Report.TABLE_NAME:
                    WordDocument.createWordDocument(getReportById(id));
                    break;
            }
        }

        internal void createWordDocument(Programmer programmer)
        {
            WordDocument.createWordDocument(programmer);
        }

        internal void createWordDocument(Project project)
        {
            WordDocument.createWordDocument(project);
        }

        internal void createWordDocument(Report report)
        {
            WordDocument.createWordDocument(report);
        }

        internal void createWordDocument(Finance finance)
        {
            WordDocument.createWordDocument(finance);
        }
        #endregion

        #region serializators
        internal void serialize(string tableName, int id)
        {
            switch (tableName)
            {
                case DatabaseConstants.Programmer.TABLE_NAME:
                    Serializator.serialize(getProgrammerById(id));
                    break;

                case DatabaseConstants.Project.TABLE_NAME:
                    Serializator.serialize(getProjectById(id));
                    break;

                case DatabaseConstants.Finance.TABLE_NAME:
                    Serializator.serialize(getFinanceById(id));
                    break;

                case DatabaseConstants.Report.TABLE_NAME:
                    Serializator.serialize(getReportById(id));
                    break;
            }
        }

        internal void serialize(Programmer programmer)
        {
            Serializator.serialize(programmer);
        }

        internal void serialize(Project project)
        {
            Serializator.serialize(project);
        }

        internal void serialize(Report report)
        {
            Serializator.serialize(report);
        }

        internal void serialize(Finance finance)
        {
            Serializator.serialize(finance);
        }
        #endregion

        #region signers
        internal void sign(string tableName, int id)
        {
            switch (tableName)
            {
                case DatabaseConstants.Programmer.TABLE_NAME:
                    Signer.sign(getProgrammerById(id));
                    break;

                case DatabaseConstants.Project.TABLE_NAME:
                    Signer.sign(getProjectById(id));
                    break;

                case DatabaseConstants.Finance.TABLE_NAME:
                    Signer.sign(getFinanceById(id));
                    break;

                case DatabaseConstants.Report.TABLE_NAME:
                    Signer.sign(getReportById(id));
                    break;
            }
        }

        internal void sign(Programmer programmer)
        {
            Signer.sign(programmer);
        }

        internal void sign(Project project)
        {
            Signer.sign(project);
        }

        internal void sign(Report report)
        {
            Signer.sign(report);
        }

        internal void sign(Finance finance)
        {
            Signer.sign(finance);
        }
        #endregion
   
        private List<Document> getUnverifiedDocs()
        {
            try
            {
                List<Document> unverifiedDocuments = new List<Document>();
                foreach (TableNameIdValueTriple document in AllDocuments) 
                {
                    verify(document, unverifiedDocuments);
                }
                return unverifiedDocuments;
            }
            catch (Exception)
            {
                throw new VerificationException("Attemp to verificate failed! Check documents format or smth like this!");
            }
        }

        private void verify(TableNameIdValueTriple document, List<Document> list)
        {
            switch (document.TableName)
            {
                case DatabaseConstants.Programmer.TABLE_NAME:
                    Programmer programmer = getProgrammerById(document.Id);
                    if (!Verifier.verify(programmer))
                    {
                        list.Add(programmer);
                    }
                    break;

                case DatabaseConstants.Project.TABLE_NAME: 
                    Project project = getProjectById(document.Id);
                    if (!Verifier.verify(project))
                    {
                        list.Add(project);
                    }
                    break;

                case DatabaseConstants.Finance.TABLE_NAME:
                    Finance finance = getFinanceById(document.Id);
                    if (!Verifier.verify(finance))
                    {
                        list.Add(finance);
                    }
                    break;

                case DatabaseConstants.Report.TABLE_NAME:
                    Report report = getReportById(document.Id);
                    if (!Verifier.verify(report))
                    {
                        list.Add(report);
                    }
                    break;
            }
        }
    }
}
