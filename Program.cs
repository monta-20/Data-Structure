//Graphs
/*
N-ary Tree

Each node can have N children.

Useful for menu structures, file systems, or organizational charts.

Balanced Trees (AVL, Red-Black Tree)

Self-balancing trees to maintain O(log n) operations.
*/
using Training_console;

class Program
{
    static void Main(string[] args)
    {
        // Create a graph with 5 vertices (0, 1, 2, 3, 4)
        Graph g = new Graph(5);

        // Add edges
        g.AddEdge(0, 1);
        g.AddEdge(0, 4);
        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);

        // Print the graph
        g.PrintGraph();

        Console.WriteLine("   (0)------(1)  ");
        Console.WriteLine("    | \\     / |  ");
        Console.WriteLine("    |  \\   /  |  ");
        Console.WriteLine("    |   (4)   |  ");
        Console.WriteLine("    |  /   \\  |  ");
        Console.WriteLine("   (2)------(3)  ");
    }
}
