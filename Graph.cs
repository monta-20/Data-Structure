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

        // DFS Traversal
        public void DFS(int start)
        {
            bool[] visited = new bool[V]; 
            Console.WriteLine("DFS Starting from node " + start + ":");
            DFSUtil(start, visited);
            Console.WriteLine();
        }
        private void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");
            foreach (var neighbor in adj[v])
            {
                if (!visited[neighbor])
                {
                    DFSUtil(neighbor, visited);
                }
            }
        }
    }
}
