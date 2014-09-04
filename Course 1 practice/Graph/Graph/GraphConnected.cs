using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class GraphConnected
    {
        /*
         * just a simple recursive algorithm, it is trying to visit
         * all vertexes, and returns false, if i impossible
         */

        private Graph graph;

        private int n;

        bool[] flags;

        int[][] matrix;

        private bool isConnected;

        public GraphConnected(Graph graph)
        {
            this.graph = graph;
            this.n = graph.vertexesCount();
            flags = new bool[n];
            for (int i = 0; i < n; i++)
                flags[i] = false;
            matrix = graph.getMatrix();
            isConnected = IsConnected();
        }

        public bool getConnected()
        {
            return isConnected;
        }

        private bool IsConnected()
        {
            if (n < 2)
                return true;
            flag(0);
            for (int i = 0; i < n; i++)
                if (!flags[i])
                    return false;
            return true;
        }

        private void flag(int index)
        {
            flags[index] = true;
            for (int i = 0; i < n; i++)
            {
                if (matrix[index][i] < Graph.VERY_BIG_NUMBER &&
                    !flags[i])
                    flag(i);
            }
        }
    }
}
