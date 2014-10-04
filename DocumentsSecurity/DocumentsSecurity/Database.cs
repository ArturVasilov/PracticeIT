using System;
using System.Collections.Generic;

using System.Data;

namespace DocumentsSecurity
{
    public class Database
    {
        public const string FILENAME = "alldocuments.xml";

        public Database()
        {
            loadDatabase();
        }

        private DataSet database;

        public void loadDatabase()
        {
            database = new DataSet();
            try 
            {
                database.ReadXml(FILENAME, XmlReadMode.ReadSchema);
            } catch (Exception) 
            {
                createNewDatabase();
            }
        }

        public void addDocument(Report report)
        {
            if (report == null)
            {
                throw new ArgumentNullException("tried to add null reference for a report document");
            }
            DataTable table = database.Tables[DatabaseConstants.Report.TABLE_NAME];
            DataRow row = table.NewRow();
            row[DatabaseConstants.Report.ID] = table.Rows.Count + 1;
            row[DatabaseConstants.Report.AUTHOR] = report.Id;
            row[DatabaseConstants.Report.CONTENT] = report.Description;
            table.Rows.Add(row);
        }

        public void addDocument(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("tried to add null reference for a project document");
            }

            DataTable projectsTable = database.Tables[DatabaseConstants.Project.TABLE_NAME];
            DataRow projectRow = projectsTable.NewRow();
            project.Id = projectsTable.Rows.Count + 1;
            projectRow[DatabaseConstants.Project.ID] = project.Id;
            projectRow[DatabaseConstants.Project.CUSTOMER] = project.Customer;
            projectRow[DatabaseConstants.Project.COST] = project.Cost;
            projectRow[DatabaseConstants.Project.DESCRIPTION] = project.Description;
            projectsTable.Rows.Add(projectRow);

            DataTable performersTable = database.Tables[DatabaseConstants.Performer.TABLE_NAME];
            foreach (int performerId in project.PerformersIds)
            {
                DataRow performerRow = performersTable.NewRow();
                performerRow[DatabaseConstants.Performer.PROJECT_ID] = project.Id;
                performerRow[DatabaseConstants.Performer.PROGRAMMER_ID] = performerId;
                performersTable.Rows.Add(performerRow);
            }
        }

        public void addDocument(Programmer programmer)
        {
            if (programmer == null)
            {
                throw new ArgumentNullException("tried to add null reference for a programmer document");
            }
            DataTable programmersTable = database.Tables[DatabaseConstants.Programmer.TABLE_NAME];
            DataRow programmerRow = programmersTable.NewRow();
            programmer.Id = programmersTable.Rows.Count + 1;
            programmerRow[DatabaseConstants.Programmer.ID] = programmer.Id;
            programmerRow[DatabaseConstants.Programmer.NAME] = programmer.Name;
            programmerRow[DatabaseConstants.Programmer.SALARY] = programmer.Salary;
            programmerRow[DatabaseConstants.Programmer.DESCRIPTION] = programmer.Description;
            programmersTable.Rows.Add(programmerRow);

            DataTable programmersSkillsTable = database.Tables[DatabaseConstants.ProgrammersSkills.TABLE_NAME];
            foreach (int skillId in programmer.SkillsIds)
            {
                DataRow skillRow = programmersSkillsTable.NewRow();
                skillRow[DatabaseConstants.ProgrammersSkills.PROGRAMMER_ID] = programmer.Id;
                skillRow[DatabaseConstants.ProgrammersSkills.SKILL_ID] = skillId;
                programmersSkillsTable.Rows.Add(skillRow);
            }
        }

        public void addDocument(Finance finance)
        {
            if (finance == null)
            {
                throw new ArgumentNullException("tried to add null reference for a finance document");
            }
            DataTable financeTable = database.Tables[DatabaseConstants.Finance.TABLE_NAME];
            DataRow financeRow = financeTable.NewRow();
            financeRow[DatabaseConstants.Finance.ID] = financeTable.Rows.Count + 1;
            financeRow[DatabaseConstants.Finance.INCOME] = finance.Income;
            financeRow[DatabaseConstants.Finance.EXPENSE] = finance.Expense;
            financeRow[DatabaseConstants.Finance.PROFIT] = finance.Profit;
            financeRow[DatabaseConstants.Finance.DESCRIPTION] = finance.Description;
            financeTable.Rows.Add(financeRow);
        }

        public List<int> createIdsListFromSkillsList(List<string> skills)
        {
            DataTable table = database.Tables[DatabaseConstants.Skill.TABLE_NAME];
            List<int> result = new List<int>();
            foreach (string skill in skills)
            {
                //table.Rows.Find()
            }
            return result;
        }

        public void save()
        {
            database.WriteXml(FILENAME, XmlWriteMode.WriteSchema);
        }

        private void createNewDatabase()
        {
            DataTable reportsTable = new DataTable(DatabaseConstants.Report.TABLE_NAME);
            reportsTable.Columns.Add(new DataColumn(DatabaseConstants.Report.ID, Type.GetType("System.Int32")));
            reportsTable.Columns.Add(new DataColumn(DatabaseConstants.Report.AUTHOR, Type.GetType("System.Int32")));
            reportsTable.Columns.Add(new DataColumn(DatabaseConstants.Report.CONTENT, Type.GetType("System.String")));
            reportsTable.PrimaryKey = new DataColumn[] { reportsTable.Columns[DatabaseConstants.Report.ID] };
            database.Tables.Add(reportsTable);

            DataTable financeTable = new DataTable(DatabaseConstants.Finance.TABLE_NAME);
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.ID, Type.GetType("System.Int32")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.INCOME, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.EXPENSE, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.PROFIT, Type.GetType("System.Int64")));
            financeTable.Columns.Add(new DataColumn(DatabaseConstants.Finance.DESCRIPTION, Type.GetType("System.String")));
            financeTable.PrimaryKey = new DataColumn[] { financeTable.Columns[DatabaseConstants.Finance.ID] };
            database.Tables.Add(financeTable);

            DataTable projectsTable = new DataTable(DatabaseConstants.Project.TABLE_NAME);
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.ID, Type.GetType("System.Int32")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.CUSTOMER, Type.GetType("System.String")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.COST, Type.GetType("System.Int32")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.DATE, Type.GetType("System.String")));
            projectsTable.Columns.Add(new DataColumn(DatabaseConstants.Project.DESCRIPTION, Type.GetType("System.String")));
            projectsTable.PrimaryKey = new DataColumn[] { projectsTable.Columns[DatabaseConstants.Project.ID] };
            database.Tables.Add(projectsTable);

            DataTable programmerTable = new DataTable(DatabaseConstants.Programmer.TABLE_NAME);
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.ID, Type.GetType("System.Int32")));
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.NAME, Type.GetType("System.String")));
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.SALARY, Type.GetType("System.Int32")));
            programmerTable.Columns.Add(new DataColumn(DatabaseConstants.Programmer.DESCRIPTION, Type.GetType("System.String")));
            programmerTable.PrimaryKey = new DataColumn[] { programmerTable.Columns[DatabaseConstants.Programmer.ID] };
            database.Tables.Add(programmerTable);

            DataTable skillsTable = new DataTable(DatabaseConstants.Skill.TABLE_NAME);
            skillsTable.Columns.Add(new DataColumn(DatabaseConstants.Skill.ID, Type.GetType("System.Int32")));
            skillsTable.Columns.Add(new DataColumn(DatabaseConstants.Skill.SKILL, Type.GetType("System.String")));
            DataColumn[] skillsKey = new DataColumn[] { skillsTable.Columns[DatabaseConstants.Skill.ID] };
            skillsTable.PrimaryKey = skillsKey;
            database.Tables.Add(skillsTable);

            DataTable programmersSkillsTable = new DataTable(DatabaseConstants.ProgrammersSkills.TABLE_NAME);
            programmersSkillsTable.Columns.Add(new DataColumn(DatabaseConstants.ProgrammersSkills.SKILL_ID, Type.GetType("System.Int32")));
            programmersSkillsTable.Columns.Add(new DataColumn(DatabaseConstants.ProgrammersSkills.PROGRAMMER_ID, Type.GetType("System.Int32")));
            DataColumn[] programmerSkillsKey = new DataColumn[] 
            {
                programmersSkillsTable.Columns[0], programmersSkillsTable.Columns[1],
            };
            programmersSkillsTable.PrimaryKey = programmerSkillsKey;
            database.Tables.Add(programmersSkillsTable);

            DataTable performersTable = new DataTable(DatabaseConstants.Performer.TABLE_NAME);
            performersTable.Columns.Add(new DataColumn(DatabaseConstants.Performer.PROGRAMMER_ID, Type.GetType("System.Int32")));
            performersTable.Columns.Add(new DataColumn(DatabaseConstants.Performer.PROJECT_ID, Type.GetType("System.Int32")));
            DataColumn[] performersKey = new DataColumn[] 
            { 
                performersTable.Columns[DatabaseConstants.Performer.PROGRAMMER_ID], 
                performersTable.Columns[DatabaseConstants.Performer.PROJECT_ID], 
            };
            performersTable.PrimaryKey = performersKey;
            database.Tables.Add(performersTable);

            DataRelation reportsRelation = new DataRelation(DatabaseConstants.Relations.REPORT_PROGRAMMER,
                new DataColumn[] { reportsTable.Columns[DatabaseConstants.Report.ID] },
                new DataColumn[] { programmerTable.Columns[DatabaseConstants.Programmer.ID] });
            database.Relations.Add(reportsRelation);

            DataRelation skillsRelation = new DataRelation(DatabaseConstants.Relations.SKILL_PROGRAMMERSKILL,
                new DataColumn[] { skillsTable.Columns[DatabaseConstants.Skill.ID] },
                new DataColumn[] { programmersSkillsTable.Columns[DatabaseConstants.ProgrammersSkills.SKILL_ID] });
            database.Relations.Add(skillsRelation);

            DataRelation programmerRelation = new DataRelation(DatabaseConstants.Relations.SKILL_PROGRAMMER,
                new DataColumn[] { programmersSkillsTable.Columns[DatabaseConstants.ProgrammersSkills.PROGRAMMER_ID] },
                new DataColumn[] { programmerTable.Columns[DatabaseConstants.Programmer.ID] });
            database.Relations.Add(programmerRelation);

            DataRelation performersRelation = new DataRelation(DatabaseConstants.Relations.PROJECT_PERFORMER,
                new DataColumn[] { projectsTable.Columns[DatabaseConstants.Project.ID] },
                new DataColumn[] { performersTable.Columns[DatabaseConstants.Performer.PROJECT_ID] });
            database.Relations.Add(performersRelation);

            DataRelation programmerPerformerRelation = new DataRelation(DatabaseConstants.Relations.PROGRAMMER_PERFORMER,
                new DataColumn[] { programmerTable.Columns[DatabaseConstants.Programmer.ID] },
                new DataColumn[] { performersTable.Columns[DatabaseConstants.Performer.PROGRAMMER_ID] });
            database.Relations.Add(programmerPerformerRelation);

            database.WriteXml(FILENAME, XmlWriteMode.WriteSchema);
        }
    }
}
