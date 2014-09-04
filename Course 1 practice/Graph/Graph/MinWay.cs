using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class MinWay
    {
        /*
         * in this class we create matrix of ways
         * matrix is filled by floyd or dijkstra algorithms, randomize
         */

        Graph graph;

        int[][] matrix;

        //result matrix
        Way[][] ways;

        int n;

        public MinWay(Graph graph)
        {
            this.graph = graph;
            matrix = graph.getMatrix();
            n = matrix.Length;
            initWays();
            createWays();
        }

        private void initWays()
        {
            ways = new Way[n][];
            for (int i = 0; i < n; i++)
            {
                ways[i] = new Way[n];
                for (int j = 0; j < n; j++)
                {
                    ways[i][j] = new Way(matrix[i][j], i.ToString());
                }
            }
        }

        //different get ways methods
        public Way wayBeetwenTwoVertex(int firstVertex, int secondVertex)
        {
            if ((firstVertex >= n || firstVertex < 0) ||
                (secondVertex >= n || secondVertex < 0))
                throw new Exception("Edge index is out of bounds exception");
            return ways[firstVertex][secondVertex];
        }

        public Way[] dijkstraWays(int vertex)
        {
            if (vertex < 0 || vertex >= n)
                throw new Exception("Vertex index is out of bounds");
            return ways[vertex];
        }

        public Way[][] floydWays()
        {
            return ways;
        }

        private void createWays()
        {
            //we can choose to use dijkstra or floyd according to graph, but it hard
            if (new Random().Next(10) % 2 == 1) //lol
                fillByDijkstra();
            else
                fillByFloyd();
        }

        private void fillByFloyd()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int l = -1;
                    for (int k = 0; k < n; k++)
                    {
                        int oldWeight = ways[i][j].Weight;
                        int newWeight = matrix[i][k] + matrix[k][j];
                        if (newWeight <= oldWeight) 
                        {
                            ways[i][j].Weight = newWeight;
                            l = k;
                        }
                    }
                    //if there are no better way
                    if (l == -1)
                        continue;
                    addVertexToWay(i, j, l);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ways[i][j].RealWay += "->" + j.ToString();
                }
            }

            for (int i = 0; i < n; i++)
            {
                ways[i][i] = new Way(0, i.ToString() + "->" + i.ToString());
            }
        }

        private void fillByDijkstra()
        {
            for (int i = 0; i < n; i++)
                findDijkstraWay(i);
        }

        private void findDijkstraWay(int vertex)
        {
            if (vertex < 0 || vertex >= n)
                throw new Exception("Vertex index is out of bounds");

            //visited vertexes
            bool[] used = new bool[n];
            used[vertex] = true;

            //distances to vertexes
            int[] dist = new int[n];
            dist[vertex] = 0;

            //ways to vertexes
            string[] stringWays = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringWays[i] = vertex.ToString();
                if (i != vertex)
                {
                    used[i] = false;
                    dist[i] = Graph.VERY_BIG_NUMBER;
                }
            }

            //current vertex which we are in
            int current = vertex;
            while (!isAllPassed(used))
            {
                int minDist = Graph.VERY_BIG_NUMBER;
                int minVertex = current;
                for (int i = 0; i < n; i++)
                {
                    if (i == current)
                        continue;
                    if (!used[i]) 
                    {
                        int currentDist = dist[current] + matrix[current][i];
                        if (currentDist < minDist)
                        {
                            minDist = currentDist;
                            minVertex = i;
                        }
                        if (dist[i] > currentDist)
                        {
                            //update distance and way
                            dist[i] = currentDist;
                            stringWays[i] = stringWays[current];
                        }
                    }
                }

                used[minVertex] = true;
                stringWays[minVertex] += "->" + minVertex.ToString();
                current = minVertex;
                ways[vertex][current].Weight = dist[current];
            }
            addVertexToWay(vertex, stringWays);
            ways[vertex][vertex].Weight = 0;
            ways[vertex][vertex].RealWay = vertex.ToString() + "->" + vertex.ToString();
        }

        private bool isAllPassed(bool[] used)
        {
            for (int i = 0; i < used.Length; i++)
                if (!used[i])
                    return false;
            return true;
        }

        private void addVertexToWay(int first, int second, int add)
        {
            String s = ways[first][second].RealWay;
            s += (s.Length == 0) ? add.ToString() : "->" + add.ToString();
            ways[first][second].RealWay = s;
        }

        private void addVertexToWay(int vertex, string[] list)
        {
            for (int i = 0; i < n; i++)
                ways[vertex][i].RealWay = list[i];
        }

    }
}
