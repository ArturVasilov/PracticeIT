using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentsSecurity
{
    public class Programmer : Document
    {
        public const string DOCUMENTS_TYPE = "Programmers";

        public const string DOCUMENT_NAME = "name";
        public const string DOCUMENT_SALARY = "salary";

        public const string DOCUMENT_SKILLS = "Skills";
        public const string DOCUMENT_POGRAMMER_SKILLS = "Programmers_skills";
        public const string DOCUMENT_SKILL = "skill";
        public const string DOCUMENT_PROGRAMMER_ID = "programmer_id";
        public const string DOCUMENT_SKILL_ID = "skill_id";
        public const string DOCUMENT_SKILLS_RELATIONS = "skills_relation";
        public const string DOCUMENT_PROGRAMMER_SKILLS_RELATION = "programmer_skills_relation";

        private string name;

        private int salary;

        private LinkedList<string> skills;

        public Programmer(long id, string description, string name, int salary, string[] skillsParams) : base(id, description)
        {
            Name = name;
            Salary = salary;
            skills = new LinkedList<String>();
            foreach (string skill in skillsParams) 
            {
                skills.AddLast(skill);
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set 
            { 
                if (value > 0)
                {
                    salary = value; 
                }
                else
                {
                    throw new ArgumentException("salary shouldn't be less than zero!");
                }
            }
        }

        public LinkedList<string> Skills
        {
            get { return skills; }
        }

        public void addSkill(string skill)
        {
            skills.AddLast(skill);
        }

        public void removeSkill(string skill)
        {
            skills.Remove(skill);
        }
    }
}
