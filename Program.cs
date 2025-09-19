//Tree
/*
🔹What is a Tree?

A tree is a hierarchical data structure consisting of nodes.

Each node contains data and references to child nodes.

The topmost node is called the root.

Nodes with no children are called leaves.

Trees are used when data has a hierarchical relationship.

🔹Types of Trees

Binary Tree

Each node has at most 2 children (left and right).

Binary Search Tree (BST)

A binary tree where left child < parent < right child.

Enables fast search, insertion, and deletion (O(log n) average).

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
        // Bianry tree Define a Node class
        Node root = new Node('R');
        Node nodeA = new Node('A');
        Node nodeB = new Node('B');
        Node nodeC = new Node('C');
        Node nodeD = new Node('D');
        Node nodeE = new Node('E');
        Node nodeF = new Node('F');
        Node nodeG = new Node('G');
        Node nodeH = new Node('H');
        root.left = nodeA; 
        root.right = nodeB;
        nodeA.left = nodeC;
        nodeA.right = nodeD;
        nodeB.left = nodeE;
        nodeB.right = nodeF;
        nodeC.left = nodeG;
        nodeC.right = nodeH;
        // Traversal
        Console.WriteLine("root.right.right " + root.right.right.data);
    }
}
