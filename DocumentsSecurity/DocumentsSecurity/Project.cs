using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace DocumentsSecurity
{
    public class Project : Document
    {
        private string customer;

        private long cost;

        private string date;

        private LinkedList<int> performersIds;

        public Project(long id, string description, string customer, long cost, string date, int[] performersIds) 
            : base(id, description)
        {
            Customer = customer;
            Date = date;
            Cost = cost;
            this.performersIds = new LinkedList<int>();
            foreach (int performerId in performersIds)
            {
                this.performersIds.AddLast(performerId);
            }
        }

        public override string ToString()
        {
            return "Заказ от " + Customer;
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public long Cost
        {
            get { return cost; }
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                {
                    throw new ArgumentException("project cost is less than zero!");
                }
            }
        }

        public string Date
        {
            get { return date; }
            set
            {
                Regex dateRegex = new Regex("[0-9]{2}/[0-9]{2}/[0-9]{4}");
                if (dateRegex.IsMatch(value))
                {
                    date = value;
                }
                else
                {
                    throw new ArgumentException("Date has irregular format. Use DD/MM/YYYY instead.");
                }
            }
        }

        public LinkedList<int> PerformersIds
        {
            get { return performersIds; }
        }

        public void addPerformer(int id)
        {
            performersIds.AddLast(id);
        }

        public void removePerformer(int id)
        {
            performersIds.Remove(id);
        }
    }
}
