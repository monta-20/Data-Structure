//Dictionary
/*
 
A Dictionary<TKey, TValue> is a collection of key-value pairs.

It’s like a real dictionary:

Word = Key

Definition = Value

Keys must be unique.

Provides fast lookups (O(1) average time).

 */
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int , string > users = new Dictionary<int, string>();
        Dictionary<string , int> ages = new Dictionary<string, int>();
        // Adding key-value pairs
        users.Add(1 , "Monta");
        users.Add(2, "Mohamed");
        users.Add(3, "Yamina");
        // Accessing values by key 
        Console.WriteLine(users[1]); // Output: Monta
        // Updating values
        users[1] = "Malek";
        Console.WriteLine(users[1]); // Output: Malek
        //check if a key exists
        if (users.ContainsKey(2))
        {
            Console.WriteLine("Key 2 exists.");
        }
        //check if a value exists
        if (users.ContainsValue("Yamina"))
        {
            Console.WriteLine("Value 'Yamina' exists.");
        }
        // Safely get a value without exception if key is missing
        if (users.TryGetValue(3, out string name))
        {
            Console.WriteLine($"Key 3 has value: {name}");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
        // Get collections of keys and values
        foreach (int key in users.Keys)
        {
            Console.WriteLine($"Key: {key}");
        }
        foreach (string value in users.Values)
        {
            Console.WriteLine($"Value: {value}");
        }
        // Remove a key-value pair
        users.Remove(1);
        // clear all entries
        users.Clear();
    }
}
