using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class Document
    {
        private long id;

        private string description;

        public Document(long id, string description)
        {
            Id = id;
            Description = description;
        }

        public override string ToString()
        {
            return "Документ: идентификатор - " + id;
        }

        public long Id
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
