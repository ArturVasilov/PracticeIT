using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    class Document
    {
        public enum DocumentType
        {
            Employee,
            Project,
            Finance,
        };

        private long id;

        private DocumentType type;

        private string description;

        public Document(long id, DocumentType type, string description)
        {
            Type = type;
            Description = description;
        }

        public long Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("id shouldn't be less than zero!");
                }
            }
        }

        public DocumentType Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
    } 
}
