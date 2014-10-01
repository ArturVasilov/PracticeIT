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
            initDataSet();
        }

        private void initDataSet()
        {
            dataSet = new DataSet();
            dataSet.ReadXml(FILENAME, XmlReadMode.ReadSchema);
            #region create database
            /*
            DataTable reportsTable = new DataTable(Report.DOCUMENTS_TYPE);
            reportsTable.Columns.Add(new DataColumn(Report.ID, Type.GetType("System.Int32")));
            reportsTable.Columns.Add(new DataColumn(Report.DOCUMENT_AUTHOR_ID, Type.GetType("System.Int32")));
            reportsTable.Columns.Add(new DataColumn(Report.DOCUMENT_DESCRIPTION, Type.GetType("System.String")));
            reportsTable.PrimaryKey = new DataColumn[] { reportsTable.Columns[Report.ID] };
            dataSet.Tables.Add(reportsTable);

            DataTable financeTable = new DataTable(Finance.DOCUMENTS_TYPE);
            financeTable.Columns.Add(new DataColumn(Finance.ID, Type.GetType("System.Int32")));
            financeTable.PrimaryKey = new DataColumn[] { financeTable.Columns[Finance.ID] };
            financeTable.Columns.Add(new DataColumn(Finance.DOCUMENT_INCOME, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(Finance.DOCUMENT_EXPENSE, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(Finance.DOCUMENT_PROFIT, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(Finance.DOCUMENT_DESCRIPTION, Type.GetType("System.String")));
            dataSet.Tables.Add(financeTable);

            DataTable projectsTable = new DataTable(Project.DOCUMENTS_TYPE);
            projectsTable.Columns.Add(new DataColumn(Project.ID, Type.GetType("System.Int32")));
            projectsTable.PrimaryKey = new DataColumn[] { projectsTable.Columns[Project.ID] };
            projectsTable.Columns.Add(new DataColumn(Project.DOCUMENT_CUSTOMER, Type.GetType("System.String")));
            projectsTable.Columns.Add(new DataColumn(Project.DOCUMENT_COST, Type.GetType("System.Int32")));
            projectsTable.Columns.Add(new DataColumn(Project.DOCUMENT_DATE, Type.GetType("System.String")));
            projectsTable.Columns.Add(new DataColumn(Project.DOCUMENT_DESCRIPTION, Type.GetType("System.String")));
            dataSet.Tables.Add(projectsTable);

            DataTable programmerTable = new DataTable(Programmer.DOCUMENTS_TYPE);
            programmerTable.Columns.Add(new DataColumn(Programmer.ID, Type.GetType("System.Int32")));
            programmerTable.PrimaryKey = new DataColumn[] { programmerTable.Columns[Programmer.ID] };
            programmerTable.Columns.Add(new DataColumn(Programmer.DOCUMENT_NAME, Type.GetType("System.String")));
            programmerTable.Columns.Add(new DataColumn(Programmer.DOCUMENT_SALARY, Type.GetType("System.Int32")));
            programmerTable.Columns.Add(new DataColumn(Project.DOCUMENT_DESCRIPTION, Type.GetType("System.String")));
            dataSet.Tables.Add(programmerTable);

            DataTable skillsTable = new DataTable(Programmer.DOCUMENT_SKILLS);
            skillsTable.Columns.Add(new DataColumn(Programmer.DOCUMENT_SKILL_ID, Type.GetType("System.Int32")));
            skillsTable.Columns.Add(new DataColumn(Programmer.DOCUMENT_PROGRAMMER_ID, Type.GetType("System.Int32")));
            skillsTable.Columns.Add(new DataColumn(Programmer.DOCUMENT_SKILL, Type.GetType("System.String")));
            DataColumn[] skillsKey = new DataColumn[] { skillsTable.Columns[Programmer.DOCUMENT_SKILL_ID] };
            skillsTable.PrimaryKey = skillsKey;
            dataSet.Tables.Add(skillsTable);

            DataRelation programmerRelation = new DataRelation(Programmer.DOCUMENT_SKILLS_RELATIONS,
                new DataColumn[] { dataSet.Tables[Programmer.DOCUMENTS_TYPE].Columns[Programmer.ID] },
                new DataColumn[] { dataSet.Tables[Programmer.DOCUMENT_SKILLS].Columns[Programmer.DOCUMENT_PROGRAMMER_ID] });
            dataSet.Relations.Add(programmerRelation);

            DataTable performersTable = new DataTable(Project.DOCUMENT_PERFORMERS);
            performersTable.Columns.Add(new DataColumn(Project.DOCUMENT_PERFORMER_ID, Type.GetType("System.Int32")));
            performersTable.Columns.Add(new DataColumn(Project.DOCUMENT_PROJECT_ID, Type.GetType("System.Int32")));
            performersTable.Columns.Add(new DataColumn(Project.DOCUMENT_PROGRAMMER_NAME, Type.GetType("System.String")));
            DataColumn[] performersKey = new DataColumn[] { performersTable.Columns[Project.DOCUMENT_PERFORMER_ID] };
            performersTable.PrimaryKey = performersKey;
            dataSet.Tables.Add(performersTable);

            DataRelation performersRelation = new DataRelation(Project.DOCUMENT_PERFORMERS_RELATIONS,
                new DataColumn[] { dataSet.Tables[Project.DOCUMENTS_TYPE].Columns[Project.ID] },
                new DataColumn[] { dataSet.Tables[Project.DOCUMENT_PERFORMERS].Columns[Project.DOCUMENT_PROJECT_ID] });
            dataSet.Relations.Add(performersRelation);

            dataSet.WriteXml(FILENAME, XmlWriteMode.WriteSchema);
            */
            #endregion
        }

        public void addReport(Report report)
        { 
            if (report == null)
            {
                throw new ArgumentNullException("tried to add null reference for a report document");
            }
            DataTable table = dataSet.Tables[Report.DOCUMENTS_TYPE];
            DataRow row = table.NewRow();
            row[Report.ID] = table.Rows.Count + 1;
            row[Report.DOCUMENT_AUTHOR_ID] = report.Id;
            row[Report.DOCUMENT_DESCRIPTION] = report.Description;
            table.Rows.Add(row);
        }

        public void addProgrammer(Programmer programmer)
        {
            if (programmer == null)
            {
                throw new ArgumentNullException("tried to add null reference for a programmer document");
            }
            DataTable programmersTable = dataSet.Tables[Programmer.DOCUMENTS_TYPE];
            DataRow programmerRow = programmersTable.NewRow();
            programmer.Id = programmersTable.Rows.Count + 1;
            programmerRow[Programmer.ID] = programmer.Id;
            programmerRow[Programmer.DOCUMENT_NAME] = programmer.Name;
            programmerRow[Programmer.DOCUMENT_SALARY] = programmer.Salary;
            programmerRow[Programmer.DOCUMENT_DESCRIPTION] = programmer.Description;
            programmersTable.Rows.Add(programmerRow);

            DataTable skillsTable = dataSet.Tables[Programmer.DOCUMENT_SKILLS];
            foreach (string skill in programmer.Skills)
            {
                DataRow skillRow = skillsTable.NewRow();
                skillRow[Programmer.DOCUMENT_SKILL_ID] = skillsTable.Rows.Count + 1;
                skillRow[Programmer.DOCUMENT_PROGRAMMER_ID] = programmer.Id;
                skillRow[Programmer.DOCUMENT_SKILL] = skill;
                skillsTable.Rows.Add(skillRow);
            }
        }

        public void addProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("tried to add null reference for a project document");
            }
            DataTable projectsTable = dataSet.Tables[Project.DOCUMENTS_TYPE];
            DataRow projectRow = projectsTable.NewRow();
            project.Id = projectsTable.Rows.Count + 1;
            projectRow[Project.ID] = project.Id;
            projectRow[Project.DOCUMENT_CUSTOMER] = project.Customer;
            projectRow[Project.DOCUMENT_COST] = project.Cost;
            projectRow[Project.DOCUMENT_DESCRIPTION] = project.Description;
            projectsTable.Rows.Add(projectRow);

            DataTable performersTable = dataSet.Tables[Project.DOCUMENT_PERFORMERS];
            foreach (string performer in project.PerformersNames)
            {
                DataRow performerRow = performersTable.NewRow();
                performerRow[Project.DOCUMENT_PERFORMER_ID] = performersTable.Rows.Count + 1;
                performerRow[Project.DOCUMENT_PROJECT_ID] = project.Id;
                performerRow[Project.DOCUMENT_PROGRAMMER_NAME] = performer;
                performersTable.Rows.Add(performerRow);
            }
        }

        public void addFinance(Finance finance)
        {
            if (finance == null)
            {
                throw new ArgumentNullException("tried to add null reference for a finance document");
            }
            DataTable financeTable = dataSet.Tables[Finance.DOCUMENTS_TYPE];
            DataRow financeRow = financeTable.NewRow();
            financeRow[Finance.ID] = financeTable.Rows.Count + 1;
            financeRow[Finance.DOCUMENT_INCOME] = finance.Income;
            financeRow[Finance.DOCUMENT_EXPENSE] = finance.Expense;
            financeRow[Finance.DOCUMENT_PROFIT] = finance.Profit;
            financeRow[Finance.DOCUMENT_DESCRIPTION] = finance.Description;
            financeTable.Rows.Add(financeRow);
        }

        public void save()
        {
            dataSet.WriteXml(FILENAME, XmlWriteMode.WriteSchema);
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
