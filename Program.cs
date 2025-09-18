//SortedSet
/*
A collection of unique elements (no duplicates, like HashSet<T>).

But unlike HashSet, it keeps items in sorted order automatically.

Uses a balanced binary search tree internally → operations are O(log n).

Belongs to System.Collections.Generic.

Think of it as: HashSet + automatic sorting.
*/
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create a SortedSet of integers
        SortedSet<int> numbers = new SortedSet<int>();
        // Add elements 
        numbers.Add(1);
        numbers.Add(3);
        numbers.Add(2);
        numbers.Add(2); // Duplicate, won't be added
        // Display elements (will be in sorted order)
        Console.WriteLine("SortedSet elements:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num); // Output: 1, 2, 3
        }
        // Check for existence
        Console.WriteLine($"Contains 2? {numbers.Contains(2)}"); // True
        Console.WriteLine($"Contains 4? {numbers.Contains(4)}"); // False
        // Remove an element
        numbers.Remove(2);
        Console.WriteLine("After removing 2:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num); // Output: 1, 3
        }
        // Count of elements
        Console.WriteLine($"Count: {numbers.Count}"); // 2
        // Clear all elements
        numbers.Clear();
    }
}
