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
            //dataSet.ReadXml(FILENAME, XmlReadMode.ReadSchema);
            #region create database
            //*
            DataTable reportsTable = new DataTable(DatabaseConstants.Report.TABLE_NAME);
            reportsTable.Columns.Add(new DataColumn(DatabaseConstants.Report.ID, Type.GetType("System.Int32")));
            reportsTable.Columns.Add(new DataColumn(DatabaseConstants.Report.AUTHOR, Type.GetType("System.Int32")));
            reportsTable.Columns.Add(new DataColumn(DatabaseConstants.Report.CONTENT, Type.GetType("System.String")));
            reportsTable.PrimaryKey = new DataColumn[] { reportsTable.Columns[DatabaseConstants.Report.ID] };
            dataSet.Tables.Add(reportsTable);

            DataTable financeTable = new DataTable(DatabaseConstants.Finance.TABLE_NAME);
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.ID, Type.GetType("System.Int32")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.INCOME, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.EXPENSE, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.PROFIT, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.DESCRIPTION, Type.GetType("System.String")));
            financeTable.PrimaryKey = new DataColumn[] { financeTable.Columns[DatabaseConstants.Finance.ID] };
            dataSet.Tables.Add(financeTable);

            DataTable projectsTable = new DataTable(DatabaseConstants.Project.TABLE_NAME);
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.ID, Type.GetType("System.Int32")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.CUSTOMER, Type.GetType("System.String")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.COST, Type.GetType("System.Int32")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.DATE, Type.GetType("System.String")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.DESCRIPTION, Type.GetType("System.String")));
            projectsTable.PrimaryKey = new DataColumn[] { projectsTable.Columns[DatabaseConstants.Project.ID] };
            dataSet.Tables.Add(projectsTable);

            DataTable programmerTable = new DataTable(DatabaseConstants.Programmer.TABLE_NAME);
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.ID, Type.GetType("System.Int32")));
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.NAME, Type.GetType("System.String")));
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.SALARY, Type.GetType("System.Int32")));
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.DESCRIPTION, Type.GetType("System.String")));
            programmerTable.PrimaryKey = new DataColumn[] { programmerTable.Columns[DatabaseConstants.Programmer.ID] };
            dataSet.Tables.Add(programmerTable);

            DataTable skillsTable = new DataTable(DatabaseConstants.Skill.TABLE_NAME);
            skillsTable.Columns.Add(new DataColumn(DatabaseConstants.Skill.ID, Type.GetType("System.Int32")));
            skillsTable.Columns.Add(new DataColumn(DatabaseConstants.Skill.SKILL, Type.GetType("System.String")));
            DataColumn[] skillsKey = new DataColumn[] { skillsTable.Columns[DatabaseConstants.Skill.ID] };
            skillsTable.PrimaryKey = skillsKey;
            dataSet.Tables.Add(skillsTable);

            DataTable programmersSkillsTable = new DataTable(DatabaseConstants.ProgrammersSkills.TABLE_NAME);
            programmersSkillsTable.Columns.Add(new DataColumn(DatabaseConstants.ProgrammersSkills.SKILL_ID, Type.GetType("System.Int32")));
            programmersSkillsTable.Columns.Add(new DataColumn(DatabaseConstants.ProgrammersSkills.PROGRAMMER_ID, Type.GetType("System.Int32")));
            DataColumn[] programmerSkillsKey = new DataColumn[] 
            {
                programmersSkillsTable.Columns[0], programmersSkillsTable.Columns[1],
            };
            programmersSkillsTable.PrimaryKey = programmerSkillsKey;
            dataSet.Tables.Add(programmersSkillsTable);

            DataTable performersTable = new DataTable(DatabaseConstants.Performer.TABLE_NAME);
            performersTable.Columns.Add(new DataColumn(DatabaseConstants.Performer.PROGRAMMER_ID, Type.GetType("System.Int32")));
            performersTable.Columns.Add(new DataColumn(DatabaseConstants.Performer.PROJECT_ID, Type.GetType("System.Int32")));
            DataColumn[] performersKey = new DataColumn[] 
            { 
                performersTable.Columns[DatabaseConstants.Performer.PROGRAMMER_ID], 
                performersTable.Columns[DatabaseConstants.Performer.PROJECT_ID], 
            };
            performersTable.PrimaryKey = performersKey;
            dataSet.Tables.Add(performersTable);

            /*DataRelation reportsRelation = new DataRelation(DatabaseConstants.Relations.REPORT_PROGRAMMER,
                new DataColumn[] { reportsTable.Columns[DatabaseConstants.Report.ID] },
                new DataColumn[] { reportsTable.Columns[DatabaseConstants.Programmer.ID] });
            dataSet.Relations.Add(reportsRelation);*/

            DataRelation skillsRelation = new DataRelation(DatabaseConstants.Relations.SKILL_PROGRAMMERSKILL,
                new DataColumn[] { skillsTable.Columns[DatabaseConstants.Skill.ID] },
                new DataColumn[] { programmerTable.Columns[DatabaseConstants.ProgrammersSkills.SKILL_ID] });
            dataSet.Relations.Add(skillsRelation);

            DataRelation programmerRelation = new DataRelation(DatabaseConstants.Relations.SKILL_PROGRAMMER,
                new DataColumn[] { programmersSkillsTable.Columns[DatabaseConstants.ProgrammersSkills.PROGRAMMER_ID] },
                new DataColumn[] { programmersSkillsTable.Columns[DatabaseConstants.Programmer.ID] });
            dataSet.Relations.Add(programmerRelation);

            DataRelation performersRelation = new DataRelation(DatabaseConstants.Relations.PROJECT_PERFORMER,
                new DataColumn[] { projectsTable.Columns[DatabaseConstants.Project.ID] },
                new DataColumn[] { performersTable.Columns[DatabaseConstants.Performer.PROJECT_ID] });
            dataSet.Relations.Add(performersRelation);

            dataSet.WriteXml(FILENAME, XmlWriteMode.WriteSchema);
            //*/
            #endregion
        }

        public void addReport(Report report)
        { 
            if (report == null)
            {
                throw new ArgumentNullException("tried to add null reference for a report document");
            }
            DataTable table = dataSet.Tables[DatabaseConstants.Report.TABLE_NAME];
            DataRow row = table.NewRow();
            row[DatabaseConstants.Report.ID] = table.Rows.Count + 1;
            row[DatabaseConstants.Report.AUTHOR] = report.Id;
            row[DatabaseConstants.Report.CONTENT] = report.Description;
            table.Rows.Add(row);
        }

        public void addProgrammer(Programmer programmer)
        {
            if (programmer == null)
            {
                throw new ArgumentNullException("tried to add null reference for a programmer document");
            }
            DataTable programmersTable = dataSet.Tables[DatabaseConstants.Programmer.TABLE_NAME];
            DataRow programmerRow = programmersTable.NewRow();
            programmer.Id = programmersTable.Rows.Count + 1;
            programmerRow[DatabaseConstants.Programmer.ID] = programmer.Id;
            programmerRow[DatabaseConstants.Programmer.NAME] = programmer.Name;
            programmerRow[DatabaseConstants.Programmer.SALARY] = programmer.Salary;
            programmerRow[DatabaseConstants.Programmer.DESCRIPTION] = programmer.Description;
            programmersTable.Rows.Add(programmerRow);

            //TODO
            DataTable skillsTable = dataSet.Tables[DatabaseConstants.Skill.TABLE_NAME];
            foreach (string skill in programmer.Skills)
            {
                DataRow skillRow = skillsTable.NewRow();
                /*
                skillRow[DatabaseConstants.Programmer.DOCUMENT_SKILL_ID] = skillsTable.Rows.Count + 1;
                skillRow[Programmer.DOCUMENT_PROGRAMMER_ID] = programmer.Id;
                skillRow[Programmer.DOCUMENT_SKILL] = skill;
                //*/
                skillsTable.Rows.Add(skillRow);
            }
        }

        public void addProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("tried to add null reference for a project document");
            }
            //TODO
            /*
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
            //*/
        }

        public void addFinance(Finance finance)
        {
            if (finance == null)
            {
                throw new ArgumentNullException("tried to add null reference for a finance document");
            }
            DataTable financeTable = dataSet.Tables[DatabaseConstants.Finance.TABLE_NAME];
            DataRow financeRow = financeTable.NewRow();
            financeRow[DatabaseConstants.Finance.ID] = financeTable.Rows.Count + 1;
            financeRow[DatabaseConstants.Finance.INCOME] = finance.Income;
            financeRow[DatabaseConstants.Finance.EXPENSE] = finance.Expense;
            financeRow[DatabaseConstants.Finance.PROFIT] = finance.Profit;
            financeRow[DatabaseConstants.Finance.DESCRIPTION] = finance.Description;
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
