using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    public class Finance : Document
    {
        public const string INCOME = "income";
        public const string EXPENSE = "expense";
        public const string PROFIT = "profit";

        private long income;

        private long expense;

        private long profit;

        public Finance(long id, string description, long income, long expense) : base(id, description)
        {
            Income = income;
            Expense = expense;
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

        public long Expense
        {
            get { return expense; }
            set
            {
                expense = value < 0 ? -value : value;
                profit = income - expense;
            }
        }

        public long Profit
        {
            get { return profit; }
        }
    }
}
