using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graph
{
    class Graph
    {
        //very big number which will represented as infinity in some algorithms
        public const int VERY_BIG_NUMBER = 99999999;

        private int[][] matrix;

        public LinkedList<Edge> edges;

        private int n = 0; //vertex count
        private int m = 0; //edges count

        private bool wasChanged;

        private GraphConnected graphConnected;
        private MinTree minTree;
        private MinWay minWay;

        public Graph()
        {

        }

        public void readMatrix(StreamReader reader)
        {
            //matrix is simmetrical, 
            //count of non-zero elements in the right top trianglу will be edges count
            n = Convert.ToInt32(reader.ReadLine());
            matrix = new int[n][];
            for (int i = 0; i < n; i++)
                matrix[i] = new int[n];
            int mCalc = 0;
            for (int i = 0; i < n; i++)
            {
                string[] tokens = reader.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    int x = Convert.ToInt32(tokens[j]);
                    matrix[i][j] = (x == 0) ? VERY_BIG_NUMBER : x;
                    if (x > 0)
                        mCalc++;
                }
            }
            m = mCalc / 2;
            transformMatrixToEdges();
            initAlgorithms();
        }

        public void readEdges(StreamReader reader)
        {
            //max number of vertex + 1 will be count of vertexes
            this.m = Convert.ToInt32(reader.ReadLine());
            edges = new LinkedList<Edge>();
            int nCalc = 0;
            for (int i = 0; i < m; i++)
            {
                string[] tokens = reader.ReadLine().Split(' ');
                int verxtexFirst = Convert.ToInt32(tokens[0]);
                int vertexSecond = Convert.ToInt32(tokens[1]);
                if (verxtexFirst > nCalc) 
                    nCalc = verxtexFirst;
                if (vertexSecond > nCalc)
                    nCalc = vertexSecond;
                edges.AddLast(new Edge(verxtexFirst,
                    vertexSecond, Convert.ToInt32(tokens[2])));
            }
            this.n = nCalc + 1;
            transformEdgesToMatrix();
            initAlgorithms();
        }

        public void transformMatrixToEdges()
        {
            edges = GraphFactory.createEdges(matrix);
        }

        public void transformEdgesToMatrix()
        {
            matrix = GraphFactory.createMatrix(edges, n, m);
        }

        public void deleteVertex(int index)
        {
            if (index >= n || index < 0)
                throw new Exception("Vertex index is out of bounds exception");
            for (int i = 0; i < m; i++)
            {
                Edge edge = edges.ElementAt(i);
                if (edge.First == index || edge.Second == index)
                {
                    edges.Remove(edge);
                    m--;
                }
            }
            transformEdgesToMatrix();
            wasChanged = true;
        }

        public void addVertex(int index)
        {
            if (index > n || index < 0)
                throw new Exception("Vertex index is out of bounds exception");
            n++;
            int[][] newMatrix = new int[n][];
            for (int i = 0; i < n; i++)
                newMatrix[i] = new int[n];
            for (int i = 0; i < index; i++)
                for (int j = 0; j < index; j++)
                    newMatrix[i][j] = matrix[i][j];
            for (int i = 0; i < n; i++)
            {
                newMatrix[i][index] = VERY_BIG_NUMBER;
                newMatrix[index][i] = VERY_BIG_NUMBER;
            }
            for (int i = index + 1; i < n; i++)
                for (int j = index + 1; j < n; j++)
                    newMatrix[i][j] = matrix[i - 1][j - 1];
            for (int i = index + 1; i < n; i++)
                for (int j = 0; j < index; j++)
                    newMatrix[i][j] = matrix[i - 1][j];
            for (int i = 0; i < index; i++)
                for (int j = index + 1; j < n; j++)
                    newMatrix[i][j] = matrix[i][j - 1];
            this.matrix = newMatrix;
            transformMatrixToEdges();
            wasChanged = true;
        }

        public void changeVertex(int index)
        {
            if (index > n || index < 0)
                throw new Exception("Vertex index is out of bounds exception");
            for (int i = 0; i < n; i++)
            {
                matrix[i][index] = VERY_BIG_NUMBER;
                matrix[index][i] = VERY_BIG_NUMBER;
            }
            wasChanged = true;
        }

        public void addEdge(Edge edge)
        {
            if (edge.First > n || edge.Second > n)
                throw new Exception("There are no such vertex in graph!");
            m++;
            edges.AddLast(edge);
            transformEdgesToMatrix();
            wasChanged = true;
        }

        public void deleteEdge(int firstVertex, int secondVertex)
        {
            if ((firstVertex >= n || firstVertex < 0) ||
                (secondVertex >= n || secondVertex < 0))
                throw new Exception("Edge index is out of bounds exception");
            foreach (Edge edge in edges)
                if (edge.First == firstVertex &&  edge.Second == secondVertex)
                {
                    edges.Remove(edge);
                    break;
                }
            m--;
            wasChanged = true;
            transformEdgesToMatrix();
        }

        public void changeEdge(int firstVertex, int secondVertex, int weigth)
        {
            if ((firstVertex >= n || firstVertex < 0) ||
                (secondVertex >= n || secondVertex < 0))
                throw new Exception("Edge index is out of bounds exception");
            deleteEdge(firstVertex, secondVertex);
            addEdge(new Edge(firstVertex, secondVertex, weigth));
            transformEdgesToMatrix();
            wasChanged = true;
        }

        public String matrixToString()
        {
            String res = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    res += shift(matrix[i][j]) + " ";
                res = res.Remove(res.Length - 1) + "\n"; 
            }
            return res;
        }

        public bool isConnected()
        {
            if (wasChanged)
            {
                graphConnected = new GraphConnected(this);
                wasChanged = false;
            }
            return graphConnected.isConnected();
        }

        public Graph minSpanningTree()
        {
            if (wasChanged)
            {
                minTree = new MinTree(this);
                wasChanged = false;
            }
            return minTree.kruskalTree();
        }

        public String minimumWay(int firstVertex, int secondVertex)
        {
            if (wasChanged)
            {
                minWay = new MinWay(this);
                wasChanged = false;
            }
            return wayFromOneVertexToAnother(firstVertex, secondVertex,
                minWay.wayBeetwenTwoVertex(firstVertex, secondVertex));
        }

        public String minimumWay(int vertex)
        {
            if (wasChanged)
            {
                minWay = new MinWay(this);
                wasChanged = false;
            }
            return oneVertexToOthersToString(vertex, minWay.dijkstraWays(vertex));
        }

        public String minimumWay()
        {
            if (wasChanged)
            {
                minWay = new MinWay(this);
                wasChanged = false;
            }
            return allWaysToString(minWay.floydWays());
        }

        public int vertexesCount()
        {
            return n;
        }

        public int edgesCount()
        {
            return m;
        }

        public int[][] getMatrix()
        {
            return matrix;
        }

        public LinkedList<Edge> getEdges()
        {
            return edges;
        }

        public String edgesToString()
        {
            String res = "";
            for (int i = 0; i < m; i++)
            {
                res += edges.ElementAt(i).toString();
                res += "\n";
            }
            return res;
        }

        private String wayFromOneVertexToAnother(int firstVertex, 
            int secondVertex, Way way)
        {
            return "Way from " + firstVertex + " to " 
                + secondVertex + ":\n" + way + "\n";
        }

        private String oneVertexToOthersToString(int vertex, Way[] ways)
        {
            String res = "Ways from vertex " + vertex + " to others:\n";
            for (int i = 0; i < ways.Length; i++)
            {
                res += "To vertex " + i + ":\n";
                res += ways[i].ToString() + "\n";
            }
            return res;
        }

        private String allWaysToString(Way[][] ways)
        {
            String res = "All ways in graph:\n";
            for (int i = 0; i < ways.Length; i++)
                res += oneVertexToOthersToString(i, ways[i]) + "\n";
            return res;
        }

        private String shift(int x)
        {
            String s = VERY_BIG_NUMBER.ToString();
            String s1 = x.ToString();
            while (s1.Length < s.Length)
                s1 += " ";
            return s1;
        }

        private void initAlgorithms()
        {
            graphConnected = new GraphConnected(this);
            minTree = new MinTree(this);
            minWay = new MinWay(this);
        }
    }
}
