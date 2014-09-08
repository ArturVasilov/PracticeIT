using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentsSecurity
{
    public class Programmer : Document
    {
        public const string NAME = "name";
        public const string SALARY = "salary";
        public const string SKILLS = "skills";
        public const string SKILL = "skill";

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
