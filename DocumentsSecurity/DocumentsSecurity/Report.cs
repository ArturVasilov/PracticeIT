using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class Report : Document
    {
        public const string DOCUMENTS_TYPE = "Reports";

        public const string DOCUMENT_AUTHOR_ID = "author_id";

        public const string DOCUMENT_RELATIONS = "reports_relation";

        private long authorId;

        private long AuthorId
        {
            get { return authorId; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Reports author's id is less than zero!!");
                }
                else
                {
                    authorId = value;
                }
            }
        }

        public Report(long documentId, long authorId, string text) : base(documentId, text)
        {
            AuthorId = authorId;
        }
    }
}
