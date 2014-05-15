using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("MatrixInput.txt");
            Graph graph = new Graph();
            graph.readMatrix(reader);
            Console.WriteLine("Graph reading edges test:");
            Console.WriteLine(graph.edgesToString());
            Console.WriteLine(graph.matrixToString());

            Console.WriteLine();

            Console.WriteLine("Graph removing vertex test (remove vertex 1):");
            graph.deleteVertex(1);
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());

            Console.WriteLine();

            Console.WriteLine("Graph adding vertex test (add vertex 2):");
            graph.addVertex(2);
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());

            Console.WriteLine();

            Console.WriteLine("Graph adding 0-1, 0-2, edges test:\n");
            graph.addEdge(new Edge(0, 1, 4));
            graph.addEdge(new Edge(0, 2, 2));
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());

            Console.WriteLine();

            Console.WriteLine("Graph removing 0-1 edge test:\n");
            graph.deleteEdge(0, 1);
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());

            Console.WriteLine();

            Console.WriteLine("Connection test:\n");
            Console.WriteLine("Is connected: " + graph.isConnected());

            Console.WriteLine();

            Console.WriteLine("Minimum spanning tree test:\n");
            Console.WriteLine(graph.minSpanningTree().matrixToString());

            Console.WriteLine();

            Console.WriteLine("Fill the graph by new edges:");
            graph.addEdge(new Edge(0, 1, 5));
            graph.addEdge(new Edge(2, 3, 4));
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());

            Console.WriteLine();

            Console.WriteLine("Minimum way from 0 to 1 way test:\n");
            Console.WriteLine(graph.minimumWay(0, 1));

            Console.WriteLine();

            Console.WriteLine("Minimum way from 0 to others ways test:\n");
            Console.WriteLine(graph.minimumWay(0));

            Console.WriteLine();

            Console.WriteLine("Minimum way from all to others ways test:\n");
            Console.WriteLine(graph.minimumWay());

            Console.WriteLine();

            //Console.WriteLine(graph.minimumWay());

            Console.ReadLine();
        }
    }
}
