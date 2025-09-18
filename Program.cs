//SortedDictionary
/*
 
A SortedDictionary<TKey, TValue> is like a normal Dictionary, but it automatically sorts elements by key.

Internally, it uses a balanced binary search tree (Red-Black tree) → optimized for frequent insertions/removals.

Unlike SortedList, it does not allow index-based access (you can’t say myDict[0]).

 */
class Program
{
    static void Main(string[] args)
    {
        // Create a SortedDictionary
        SortedDictionary<int, string> users = new SortedDictionary<int, string>();
        // Add elements
        users.Add(3, "Alice");
        users.Add(1, "Bob");
        users.Add(2, "Charlie");
        // Display elements (automatically sorted by key)
        // Indexer access
        Console.WriteLine(users[2]); // Output: Charlie
        users[2] = "Alicia";
        // Check if a key exists
        if (users.ContainsKey(1))
        {
            Console.WriteLine("Key 1 exists.");
        }
        // Check if a value exists
        if (users.ContainsValue("Bob"))
        {
            Console.WriteLine("Value 'Bob' exists.");
        }
        // Iterate through elements
        foreach(var kvp in users)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        // Keys & Values
         foreach (var key in users.Keys)
            Console.WriteLine(key);

        foreach (var value in users.Values)
            Console.WriteLine(value);
        // Remove an element
        users.Remove(3);
        // Count elements
        Console.WriteLine($"Total users: {users.Count}");
        // Clear all elements
        users.Clear();
    }
}
