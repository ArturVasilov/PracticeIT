using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Edge : IComparable<Edge>
    {
        private int first;  //first vertex of edge
        private int second; //second vertex of edge
        private int weigth; //weight of edge

        public Edge(int first, int second, int weigth)
        {
            this.first = first;
            this.second = second;
            this.weigth = weigth;
        }

        //it allow us use Arrays.sort() for this class
        public int CompareTo(Edge edge)
        {
            return Weigth.CompareTo(edge.Weigth);
        }

        public int First
        {
            get { return first; }
            set { if (value > 0) first = value; }
        }

        public int Second
        {
            get { return second; }
            set { if (value > 0) second = value; }
        }

        public int Weigth
        {
            get { return weigth; }
            set { if (value > 0) weigth = value; }
        }

        public String toString()
        {
            return "First vertex: " + First
                + "; Second vertex: " + Second
                + "; Edge weight: " + Weigth;
        }

        //graph is simple, so edges are equal, when their vertexes are the same
        public bool Equals(Edge edge)
        {
            return First == edge.First && Second == edge.Second;
        }
    }
}
