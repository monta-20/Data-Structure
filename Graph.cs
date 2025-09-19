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
        // Undirectionned graph
        public void AddEdge(int v , int w )
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        // BFS Traversal
        public void BFS(int start)
        {
            bool[] visited = new bool[V]; 
            Queue<int> queue = new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);

            Console.WriteLine("BFS Starting from node " + start + ":");

            while(queue.Count > 0)
            {
                int node = queue.Dequeue();
                Console.Write(node + " ");
                foreach (var neighbor in adj[node])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
