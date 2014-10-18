using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class VerificationException : Exception
    {
        private List<Document> list;

        public VerificationException(string message) : base(message)
        {
        }

        public VerificationException(string message, List<Document> documents) : base(message)
        {
            list = new List<Document>(documents);
        }

        public VerificationException(string message, Document[] documents) : base(message)
        {
            list = new List<Document>(documents.AsEnumerable());
        }

        public string unverifiedDocuments
        {
            get
            {
                if (list == null)
                {
                    return "";
                }
                StringBuilder builder = new StringBuilder("\n");
                for (int i = 0; i < list.Count - 1; i++)
                {
                    builder.Append(list[i].ToString()).Append("\n");
                }
                builder.Append(list[list.Count - 1].ToString());
                return builder.ToString();
            }
        }
    }
}
