using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    class Finance : Document
    {
        private long expense;

        private long income;

        private long profit;

        public Finance(long id, string description, long expense, long income) : base(id, DocumentType.Finance, description)
        {
            Expense = expense;
            Income = income;
        }

        public long Expense
        {
            get { return expense; }
            set
            {
                expense = value < 0 ? -value : value;
                profit = income - expense;
            }
        }

        public long Income
        {
            get { return income; }
            set
            {
                if (value < 0)
                {
                    income = 0;
                }
                else
                {
                    income = value;
                }
                profit = income - expense;
            }
        }
    }
}
