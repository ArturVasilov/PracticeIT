using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentsSecurity
{
    public class Programmer : Document
    {
        public struct NameIdPair
        {
            private int id;
            private string name;

            public string Name { get { return name; } }
            public int Id { get { return id; } }

            public NameIdPair(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }

        private string name;

        private int salary;

        private LinkedList<int> skillsIds;

        public Programmer(int id, string description, string name, int salary, int[] skillsIds) : base(id, description)
        {
            Name = name;
            Salary = salary;
            this.skillsIds = new LinkedList<int>();
            foreach (int skill in skillsIds) 
            {
                this.skillsIds.AddLast(skill);
            }
        }

        public override string ToString()
        {
            return "Программист " + Name;
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

        public LinkedList<int> SkillsIds
        {
            get { return skillsIds; }
        }

        public void addSkill(int skillId)
        {
            skillsIds.AddLast(skillId);
        }

        public void removeSkill(int skillId)
        {
            skillsIds.Remove(skillId);
        }
    }
}
