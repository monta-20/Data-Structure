//DFS
/*
DFS explores a graph deeply before backtracking.

It starts from a source node, visits one neighbor, then goes deeper until no unvisited neighbors remain, then backtracks.

DFS can be implemented using:

Recursion (easier, uses call stack)

Explicit Stack (iterative version)
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

        g.DFS(0);
        /*
         DFS Starting from node 0:
         0 1 2 3 4 5
         */
    }
}
