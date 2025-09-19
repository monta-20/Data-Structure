//Balanced Trees
/*
N-ary Tree

Each node can have N children.

Useful for menu structures, file systems, or organizational charts.

Balanced Trees (AVL, Red-Black Tree)

Self-balancing trees to maintain O(log n) operations.
*/
using System.Collections;
using Training_console;

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertion
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(70);
        bst.Insert(60);
        bst.Insert(80);

        // Parcours InOrder (affiche trié)
        Console.WriteLine("InOrder Traversal:");
        bst.InOrder(bst.Root);
        Console.WriteLine();

        // Recherche
        Console.WriteLine("Search 25: " + (bst.Search(25) ? "Found" : "Not Found"));
        Console.WriteLine("Search 70: " + (bst.Search(70) ? "Found" : "Not Found"));

        // Parcours PreOrder
        Console.WriteLine("PreOrder Traversal:");
        bst.PreOrder(bst.Root);
        Console.WriteLine();

        // Parcours PostOrder
        Console.WriteLine("PostOrder Traversal:");
        bst.PostOrder(bst.Root);
        Console.WriteLine();

        // Suppression
        Console.WriteLine("Delete 20:");
        bst.Delete(20);

        // Nouveau parcours après suppression
        Console.WriteLine("InOrder Traversal after deletion:");
        bst.InOrder(bst.Root);
        Console.WriteLine();
    }

}
