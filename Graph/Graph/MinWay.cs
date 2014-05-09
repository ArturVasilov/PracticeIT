using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class MinWay
    {
        Graph graph;

        int[][] matrix;

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
            //we can choose to use dijkstra or floyd, but it hard
            if (new Random().Next(10) % 10 != 15) //lol
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
                    for (int k = 0; k < n; k++)
                    {
                        int oldWeight = ways[i][j].Weight;
                        int newWeight = matrix[i][k] + matrix[k][j];
                        if (newWeight < oldWeight) 
                        {
                            ways[i][j].Weight = newWeight;
                            addVertexToWay(i, j, k);
                        }
                    }
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

            bool[] used = new bool[n];
            used[vertex] = true;
            int[] dist = new int[n];
            dist[vertex] = 0;
            for (int i = 0; i < n; i++)
                if (i != vertex)
                {
                    used[i] = false;
                    dist[i] = Graph.VERY_BIG_NUMBER;
                }
            int[] parents = new int[n];
            parents[vertex] = vertex;

            int current = vertex;
            while (!isAllPassed(used))
            {
                int currentDist;
                int parent = parents[current];
                int minDist = Graph.VERY_BIG_NUMBER;
                int minVertex = current;
                for (int i = 0; i < current; i++)
                {
                    if (!used[i]) 
                    {
                        currentDist = dist[current] + matrix[current][i];
                        if (currentDist < minDist)
                        {
                            minDist = currentDist;
                            minVertex = i;
                            parent = parents[minVertex];
                        }
                        dist[i] = min(dist[i], currentDist);
                    }
                }

                for (int i = current + 1; i < n; i++)
                {
                    if (!used[i])
                    {
                        currentDist = dist[current] + matrix[current][i];
                        if (currentDist < minDist)
                        {
                            minDist = currentDist;
                            minVertex = i;
                            parent = parents[minVertex];
                        }
                        dist[i] = min(dist[i], currentDist);
                    }
                }

                used[minVertex] = true;
                parents[minVertex] = parent;
                current = minVertex;
                addVertexToWay(parents[current], current, minVertex);
            }
        }

        private int min(int a, int b)
        {
            return a < b ? a : b;
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
    }
}
