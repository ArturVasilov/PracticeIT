using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentsSecurity
{
    [Serializable]
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

        private List<int> skillsIds;

        public Programmer() : base() { }

        public Programmer(int id, string description, string name, int salary, int[] skillsIds) : base(id, description)
        {
            Name = name;
            Salary = salary;
            this.skillsIds = new List<int>();
            foreach (int skill in skillsIds) 
            {
                this.skillsIds.Add(skill);
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

        public List<int> SkillsIds
        {
            get { return skillsIds; }
        }

        public void addSkill(int skillId)
        {
            skillsIds.Add(skillId);
        }

        public void removeSkill(int skillId)
        {
            skillsIds.Remove(skillId);
        }
    }
}
