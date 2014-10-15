using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    [Serializable]
    public class Finance : Document
    {
        private long income;

        private long expense;

        private long profit;

        public Finance() : base() { }

        public Finance(int id, string description, long income, long expense) : base(id, description)
        {
            Income = income;
            Expense = expense;
        }

        public override string ToString()
        {
            return "Прибыль: " + Profit;
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
