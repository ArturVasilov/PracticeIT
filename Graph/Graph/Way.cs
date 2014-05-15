using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Way
    {
        //simple class to keep and print way from one vertex in graph to another

        private int weight;

        private String way;

        public Way(int weight, String way)
        {
            Weight = weight;
            RealWay = way;
        }

        public override String ToString()
        {
            return "Way: " + RealWay +
                "\nWeight - " + Weight;
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public String RealWay
        {
            get { return way; }
            set { way = value; }
        }

    }
}
