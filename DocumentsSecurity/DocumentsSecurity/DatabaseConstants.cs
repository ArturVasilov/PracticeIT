using System;

using System.IO;

namespace DocumentsSecurity
{
    internal static class DatabaseConstants
    {
        internal static class IdsKeeper
        {
            private const string IDS_FILENAME = "max_ids.txt";

            //current ids to set for new documents
            internal static int REPORT_ID { get; private set; }
            internal static void addReport() { REPORT_ID++; }

            internal static int PROGRAMMER_ID { get; private set; }
            internal static void addProgrammer() { PROGRAMMER_ID++; }

            internal static int PROJECT_ID { get; private set; }
            internal static void addProject() { PROJECT_ID++; }

            internal static int FINANCE_ID { get; private set; }
            internal static void addFinance() { FINANCE_ID++; }

            internal static void init()
            {
                StreamReader reader = new StreamReader(IDS_FILENAME);
                REPORT_ID = int.Parse(reader.ReadLine());
                PROGRAMMER_ID = int.Parse(reader.ReadLine());
                PROJECT_ID = int.Parse(reader.ReadLine());
                FINANCE_ID = int.Parse(reader.ReadLine());
                reader.Close();
            }

            internal static void save()
            {
                StreamWriter writer = new StreamWriter(IDS_FILENAME);
                writer.WriteLine(REPORT_ID);
                writer.WriteLine(PROGRAMMER_ID);
                writer.WriteLine(PROJECT_ID);
                writer.WriteLine(FINANCE_ID);
                writer.Close();
            }
        }

        internal static class Report
        {
            internal const string TABLE_NAME = "reports_table";
            internal const string ID = "report_id";
            internal const string AUTHOR = "author_id";
            internal const string CONTENT = "content";
        }

        internal static class Programmer
        {
            internal const string TABLE_NAME = "programmers_table";
            internal const string ID = "programmer_id";
            internal const string NAME = "name";
            internal const string SALARY = "salary";
            internal const string DESCRIPTION = "descrition";
        }

        internal static class Project
        {
            internal const string TABLE_NAME = "projects_table";
            internal const string ID = "project_id";
            internal const string CUSTOMER = "customer";
            internal const string COST = "cost";
            internal const string DATE = "date";
            internal const string DESCRIPTION = "description";
        }

        internal static class Finance
        {
            internal const string TABLE_NAME = "finances_table";
            internal const string ID = "finance_id";
            internal const string INCOME = "income";
            internal const string EXPENSE = "expense";
            internal const string PROFIT = "profit";
            internal const string DESCRIPTION = "description";
        }

        internal static class Skill
        {
            internal const string TABLE_NAME = "skills_table";
            internal const string ID = "skill_id";
            internal const string SKILL = "skill";
        }

        internal static class ProgrammersSkills
        {
            internal const string TABLE_NAME = "programmers_skills_table";
            internal const string PROGRAMMER_ID = "programmer_id";
            internal const string SKILL_ID = "skill_id";
        }

        internal static class Performer
        {
            internal const string TABLE_NAME = "performers_table";
            internal const string PROGRAMMER_ID = "programmer_id";
            internal const string PROJECT_ID = "project_id";
        }

        internal static class Relations
        {
            internal const string REPORT_PROGRAMMER = "report_programmer";
            internal const string SKILL_PROGRAMMERSKILL = "skill_programmerskill";
            internal const string SKILL_PROGRAMMER = "skill_programmer";
            internal const string PROJECT_PERFORMER = "project_performer";
            internal const string PROGRAMMER_PERFORMER = "programmer_performer";
        }
    }
}
