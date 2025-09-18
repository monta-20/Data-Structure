//Hashtable
/*
🔹 What is a Hashtable?

A non-generic collection (from the old System.Collections namespace).

Stores key-value pairs like Dictionary, but:

Keys and values are of type object (so you need casting).

Not type-safe compared to Dictionary<TKey,TValue>.

Automatically resizes as elements are added.

Provides fast lookups (O(1) average) using a hash function.

🔹 Common Properties

Count → number of elements.

IsReadOnly, IsFixedSize → check if you can modify it.

IsSynchronized → tells if thread-safe (not by default).

Keys → returns all keys.

Values → returns all values.

🔹 Common Methods

Add(key, value) → add new item.

Remove(key) → remove item by key.

ContainsKey(key) → check if key exists.

ContainsValue(value) → check if value exists.

Clear() → remove all items.

Clone() → shallow copy.

Indexer (myHashtable[key]) → get or set value by key. 
*/
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();

        // Add elements
        ht.Add(1, "Montassar");
        ht.Add(2, "Ben");
        ht.Add(3, "Brahim");

        // Access elements
        Console.WriteLine(ht[1]); // Montassar

        // Check existence
        Console.WriteLine(ht.ContainsKey(2));   // True
        Console.WriteLine(ht.ContainsValue("Ben")); // True

        // Remove element
        ht.Remove(3);

        // Iterate
        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }
    }
}
