// List
//A List<T> is a dynamic array (resizable).
//Unlike arrays, you don’t need to define the size in advance—it grows and shrinks automatically.
//Namespace
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Empty list 
        List<int> numbers = new List<int>();
        // List with values
        List<string> names = new List<string> { "Montassar", "Malek", "Yosra", "Mohamed", "Yamina", "Solephe" };
        // Add elements
        numbers.Add(1);
        numbers.Add(2);
        // Insert elements at index 0
        numbers.Insert(0, 20);
        // Access elements
        Console.WriteLine(numbers[0]);
        // Update elements
        numbers[0] = 100;
        // Remove elements
        numbers.Remove(2); // Remove by value
        numbers.RemoveAt(0); // Remove by index
        numbers.Clear(); // Clear all elements
        // Iterate over elements
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        // Or using for loop
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }
        // Count elements
        Console.WriteLine("Count: " + names.Count);
        //Sorting and Reversing
        names.Sort(); // Sort in ascending order
        names.Reverse(); // Reverse the order
        // Check if an element exists
        Console.WriteLine("Contains 'Yosra': " + names.Contains("Yosra"));
        // Convert array to list
        string[] array = { "A", "B", "C" };
        List<string> listFromArray = new List<string>(array);
        // Convert list to array
        string[] arrayFromList = names.ToArray();

    }
}
