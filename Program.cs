//Tuple
/*
A data structure that holds a fixed number of items (can be different types).

Belongs to System.

Immutable → once created, you can’t change its values.

Supports up to 8 items (Tuple<T1, T2, ..., T7, TRest>).

Introduced before ValueTuple (C# 7.0), which is lighter and more common today.

👉 Think of it like a container for grouping values without creating a class.
*/
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create a tuple using constructor
        Tuple<int, string, bool> person = new Tuple<int, string, bool>(1, "Alice", true);
        // Create a tuple using Create method
        var person2 = Tuple.Create(2, "Bob", false);
        // Access tuple items
        Console.WriteLine($"Person 1: ID={person.Item1}, Name={person.Item2}, IsActive={person.Item3}");
        Console.WriteLine($"Person 2: ID={person2.Item1}, Name={person2.Item2}, IsActive={person2.Item3}");
        // Compare tuples
        var areEqual = person.Equals(person2);
        Console.WriteLine($"Are Person 1 and Person 2 equal? {areEqual}");
        // Tuple with more than 7 items using TRest
        var complexTuple = Tuple.Create(1, "A", true, 3.14, 'c', 100L, (byte)255, Tuple.Create("Nested", 42));
        // Access nested tuple
        Console.WriteLine($"Complex Tuple: Item8.Item1={complexTuple.Rest.Item1.Item1}, Item8.Item2={complexTuple.Rest.Item1.Item2}");
        /*
         ⚠️ Note: Item names are always Item1, Item2, … (not very descriptive).
         👉 That’s why ValueTuple (with named fields) is often preferred.
         */
    }
}
