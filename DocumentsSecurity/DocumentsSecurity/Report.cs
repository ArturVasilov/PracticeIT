using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class Report : Document
    {
        private int authorId;

        public int AuthorId
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

        public Report(int documentId, int authorId, string text) : base(documentId, text)
        {
            AuthorId = authorId;
        }

        public override string ToString()
        {
            return "Отчет номер " + Id;
        }
    }
}
