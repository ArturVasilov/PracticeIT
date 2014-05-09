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
            Console.WriteLine("Graph reading matrix test:");
            StreamReader reader = new StreamReader("MatrixInput.txt");
            Graph graph = new Graph();
            graph.readMatrix(reader);
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());

            /*Console.WriteLine("Graph reading edges test:");
            StreamReader reader2 = new StreamReader("EdgesInput.txt");
            Graph graph2 = new Graph();
            graph2.readEdges(reader2);
            Console.WriteLine(graph2.edgesToString());
            Console.WriteLine(graph2.matrixToString());*/

            /*Console.WriteLine("Graph adding and removing vertex test:");
            graph.addVertex(2);
            graph.deleteVertex(1);
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());*/

            /*graph.addVertex(2);

            Console.WriteLine("Graph adding and removing edges test:");
            graph.deleteEdge(1, 3);
            graph.addEdge(new Edge(1, 3, 15));
            graph.addEdge(new Edge(2, 3, 22));
            graph.changeEdge(1, 3, 16);
            Console.WriteLine(graph.matrixToString());
            Console.WriteLine(graph.edgesToString());*/

            /*Console.WriteLine("Is connected: " + graph.isConnected());
            graph.deleteEdge(0, 1);
            graph.deleteEdge(0, 2);
            graph.deleteEdge(0, 3);
            Console.WriteLine("Is connected: " + graph.isConnected());
            graph.addEdge(new Edge(0, 2, 16));
            Console.WriteLine("Is connected: " + graph.isConnected());*/

            Console.WriteLine(graph.minimumWay(0, 2));

            Console.ReadLine();
        }
    }
}
