using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class GraphFactory
    {
        /* this class is a simple factory with static methods of 
         * creating list of edges from matrix and visa versa
         * also there are method to get emtpy graph of n vertexes without edges
         */

        public static int[][] createMatrix(EdgesLinkedList edges, int n, int m)
        {
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i][j] = Graph.VERY_BIG_NUMBER;
            for (int i = 0; i < m; i++)
            {
                Edge edge = edges.get(i);
                matrix[edge.First][edge.Second] = edge.Weigth;
                matrix[edge.Second][edge.First] = edge.Weigth;
            }
            return matrix;
        }

        public static EdgesLinkedList createEdges(int[][] matrix)
        {
            int n = matrix.Length;
            EdgesLinkedList list = new EdgesLinkedList();
            int k = 0; //index to add to edges
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i][j] < Graph.VERY_BIG_NUMBER)
                    {
                        list.append(new Edge(i, j, matrix[i][j]));
                        k++;
                    }
                }
            }
            return list;
        }

        public static Graph emptyGraph(int vertexesCount)
        {
            Graph graph = new Graph();
            for (int i = 0; i < vertexesCount; i++)
                graph.addVertex(i);
            graph.transformMatrixToEdges();
            return graph;
        }
    }
}
