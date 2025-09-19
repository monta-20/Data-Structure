using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_console
{
    class Graph
    {
        private int V; // Number of vertices
        private List<int>[] adj; // Adjacency list
        public Graph(int v)
        {
            this.V = v;
            this.adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        // Add an edge to the graph
        public void AddEdge(int v , int w , bool directed = false)
        {
            adj[v].Add(w);
            if(!directed)
            {
                adj[w].Add(v);
            }
        }

        // Print the graph
        public void PrintGraph()
        {
            Console.WriteLine("Graph Adjacency List:");
            for (int i = 0; i < V; i++)
            {
                Console.Write(i + " -> ");
                foreach (var neighbor in adj[i])
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
