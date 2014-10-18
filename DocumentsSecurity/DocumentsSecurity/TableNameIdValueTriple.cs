using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsSecurity
{
    internal struct TableNameIdValueTriple
    {
        private int id;
        private string tableName;
        private string value;

        public string TableName { get { return tableName; } }
        public int Id { get { return id; } }
        public string Value { get { return value; } }

        public TableNameIdValueTriple(int id, string tableName, string value)
        {
            this.id = id;
            this.tableName = tableName;
            this.value = value;
        }
    }
}
