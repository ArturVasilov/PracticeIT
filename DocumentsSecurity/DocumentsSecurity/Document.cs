using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class Document
    {
        private int id;

        private string description;

        public Document() { }

        public Document(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public override string ToString()
        {
            return "Документ: идентификатор - " + id;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("id shouldn't be less than zero!");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
    } 
}
