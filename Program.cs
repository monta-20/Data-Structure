//SortedList
/*
 
A SortedList<TKey, TValue> is like a Dictionary, but it automatically keeps keys sorted.

It combines features of:

Dictionary<TKey, TValue> → fast lookup by key

List<T> → access by index

So you can:

Access by key (like Dictionary)

Access by index position (like List)

 */
class Program
{
    static void Main(string[] args)
    {
        // Create a SortedList
        SortedList<int, string> students = new SortedList<int, string>(); 
        students.Add(1 , "John");
        students.Add(3, "Jane");
        students.Add(2, "Jake");
        // Sorted automatically: [1:John, 2:Jake, 3:Jane]
        // Access by key
        Console.WriteLine(students[2]); // Output: Jake
        // Access by index
        Console.WriteLine(students.Values[0]); // Output: John
        // Iterate in sorted order
        foreach (var kvp in students)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        // Check existence of a key
        if (students.ContainsKey(3))
        {
            Console.WriteLine("Key 3 exists.");
        }
        // Check existnece of a value 
        if (students.ContainsValue("Jane"))
        {
            Console.WriteLine("Value 'Jane' exists.");
        }
        // Get index of a key
        int index = students.IndexOfKey(2);
        Console.WriteLine($"Index of key 2: {index}"); // Output: 1
        // Get index of a value
        index = students.IndexOfValue("Jane");
        Console.WriteLine($"Index of value 'Jane': {index}"); // Output: 2
        // Remove by key
        students.Remove(1); // Removes John
        // Remove by index
        students.RemoveAt(0); // Removes Jake (now at index 0)
        // Count
        Console.WriteLine($"Count: {students.Count}"); // Output: 1
        // Clear all
        students.Clear();
    }
}
