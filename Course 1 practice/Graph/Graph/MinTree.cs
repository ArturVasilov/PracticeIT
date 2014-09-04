using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class MinTree
    {
        /*
         * this class uses kruskal algorithm
         * we get array of edges, sort them and then adding them
         * by disjoint set union (union-find) algorithm
         */

        private Graph graph;

        private Graph resultTree;

        private int n;

        public MinTree(Graph graph)
        {
            this.graph = graph;
            n = graph.vertexesCount();
            resultTree = kruskalTree();
        }

        public Graph getMinTree()
        {
            if (resultTree == null)
                resultTree = kruskalTree();
            return resultTree;
        }

        private Graph kruskalTree()
        {
            Edge[] edgesArray = graph.getEdges().ToArray();
            Graph res = GraphFactory.emptyGraph(n);
            GraphSets graphSets = new GraphSets(n);
            Array.Sort(edgesArray);
            foreach (Edge edge in edgesArray) 
            {
                if (graphSets.union(edge.First, edge.Second))
                    res.addEdge(edge);
            }
            res.transformEdgesToMatrix();
            return res;
        }

        //disjoint set union class
        private class GraphSets
        {
            //set of vertexes
            int[] sets;
            int[] rnk; 

            public GraphSets(int n)
            {
                sets = new int[n];
                rnk = new int[n];
                for (int i = 0; i < n; i++)
                    sets[i] = i;
            }

            //returns the set contains x
            public int set(int x)
            {
                if (x == sets[x])
                    return x;
                sets[x] = set(sets[x]);
                return sets[x];
            }

            /*
             * if first & second belongs to different sets,
             * unite them into one and add to set
             */ 
            public bool union(int first, int second)
            {
                first = set(first);
                second = set(second);
                if (first == second)
                    return false;

                if (rnk[first] < rnk[second])
                {
                    sets[first] = second;
                }
                else
                {
                    sets[second] = first;
                    if (rnk[first] == rnk[second])
                        rnk[first]++;
                }

                return true;
            }
        }

    }
}
