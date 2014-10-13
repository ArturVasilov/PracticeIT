using System;

using System.IO;

namespace DocumentsSecurity
{
    public static class DatabaseConstants
    {
        public static class IdsKeeper
        {
            private const string IDS_FILENAME = "max_ids.txt";

            //current ids to set for new documents
            public static int REPORT_ID { get; private set; }
            public static void addReport() { REPORT_ID++; }

            public static int PROGRAMMER_ID { get; private set; }
            public static void addProgrammer() { PROGRAMMER_ID++; }

            public static int PROJECT_ID { get; private set; }
            public static void addProject() { PROJECT_ID++; }

            public static int FINANCE_ID { get; private set; }
            public static void addFinance() { FINANCE_ID++; }

            public static void init()
            {
                StreamReader reader = new StreamReader(IDS_FILENAME);
                REPORT_ID = int.Parse(reader.ReadLine());
                PROGRAMMER_ID = int.Parse(reader.ReadLine());
                PROJECT_ID = int.Parse(reader.ReadLine());
                FINANCE_ID = int.Parse(reader.ReadLine());
                reader.Close();
            }

            public static void save()
            {
                StreamWriter writer = new StreamWriter(IDS_FILENAME);
                writer.WriteLine(REPORT_ID);
                writer.WriteLine(PROGRAMMER_ID);
                writer.WriteLine(PROJECT_ID);
                writer.WriteLine(FINANCE_ID);
                writer.Close();
            }
        }

        public static class Report
        {
            public const string TABLE_NAME = "reports_table";
            public const string ID = "report_id";
            public const string AUTHOR = "author_id";
            public const string CONTENT = "content";
        }

        public static class Programmer
        {
            public const string TABLE_NAME = "programmers_table";
            public const string ID = "programmer_id";
            public const string NAME = "name";
            public const string SALARY = "salary";
            public const string DESCRIPTION = "descrition";
        }

        public static class Project
        {
            public const string TABLE_NAME = "projects_table";
            public const string ID = "project_id";
            public const string CUSTOMER = "customer";
            public const string COST = "cost";
            public const string DATE = "date";
            public const string DESCRIPTION = "description";
        }

        public static class Finance
        {
            public const string TABLE_NAME = "finances_table";
            public const string ID = "finance_id";
            public const string INCOME = "income";
            public const string EXPENSE = "expense";
            public const string PROFIT = "profit";
            public const string DESCRIPTION = "description";
        }

        public static class Skill
        {
            public const string TABLE_NAME = "skills_table";
            public const string ID = "skill_id";
            public const string SKILL = "skill";
        }

        public static class ProgrammersSkills
        {
            public const string TABLE_NAME = "programmers_skills_table";
            public const string PROGRAMMER_ID = "programmer_id";
            public const string SKILL_ID = "skill_id";
        }

        public static class Performer
        {
            public const string TABLE_NAME = "performers_table";
            public const string PROGRAMMER_ID = "programmer_id";
            public const string PROJECT_ID = "project_id";
        }

        public static class Relations
        {
            public const string REPORT_PROGRAMMER = "report_programmer";
            public const string SKILL_PROGRAMMERSKILL = "skill_programmerskill";
            public const string SKILL_PROGRAMMER = "skill_programmer";
            public const string PROJECT_PERFORMER = "project_performer";
            public const string PROGRAMMER_PERFORMER = "programmer_performer";
        }
    }
}
