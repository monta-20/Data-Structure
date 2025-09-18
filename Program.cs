//HashSet
/*
What is a HashSet<T>?

A collection of unique values (no duplicates).

Belongs to System.Collections.Generic.

Uses a hash table internally for fast lookups, insertions, and deletions (O(1) average).

Does not maintain order.

Think of it as a mathematical set → you can do unions, intersections, differences.
*/
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create a HashSet of strings
        HashSet<string> names = new HashSet<string>();
        // Add elements
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("Alice"); // Duplicate, will be ignored
        // Check if an element exists
        Console.WriteLine(names.Contains("Bob")); // True
        // Remove an element
        names.Remove("Charlie");
        // Iterate over elements
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        // Set operations
        HashSet<string> otherNames = new HashSet<string> { "Bob", "David" };
        names.UnionWith(otherNames); // Union
        names.IntersectWith(otherNames); // Intersection
        names.ExceptWith(otherNames); // Difference
        Console.WriteLine("After set operations:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        // Count of elements
        Console.WriteLine($"Count: {names.Count}");
        // Clear all elements
        names.Clear();
    }
}
