using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class Document
    {
        public const string DOCUMENTS_TAG = "documents";
        public const string DOCUMENT_TAG = "document";
        public const string ID = "id";
        public const string DESCRIPTION = "description";

        private long id;

        private string description;

        public Document(long id, string description)
        {
            Id = id;
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
    } 
}
