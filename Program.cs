//BFS
/*
BFS is a graph traversal algorithm.

It starts from a source node and explores all neighbors first (level by level) before moving to the next level.

It uses a Queue data structure.
*/
using Training_console;

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 5);

        g.BFS(0);
    }
}
