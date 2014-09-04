using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentsSecurity
{
    class Programmer : Document
    {
        private string name;

        private int salary;

        private LinkedList<string> skills;

        public Programmer(long id, string description, String name, int salary, params string[] values) : base(id, DocumentType.Employee, description)
        {
            Name = name;
            Salary = salary;
            skills = new LinkedList<String>();
            foreach (string skill in skills) 
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
