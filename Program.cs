//Queue
//A Queue is a FIFO (First-In, First-Out) collection
//Think of it like a line at the supermarket → the first person to enter is the first person to leave
class Program
{
    static void Main(string[] args)
    {
        // Declare a Queue of strings
        Queue<string> queue = new Queue<string>();
        // Declare a Queue with initial values
        Queue<string> queue2 = new Queue<string>(new[] { "Alice", "Bob", "Charlie" });
        // Add elements to the Queue
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");
        queue.Enqueue("Charlie");
        // Remove and return the front element
        string front = queue.Dequeue();
        Console.WriteLine("Dequeued: " + front);
        // Peek at the front element without removing it
        string peek = queue.Peek();
        Console.WriteLine("Front element: " + peek);
        // Check the number of elements in the Queue
        int count = queue.Count;
        Console.WriteLine("Queue count: " + count);
        // Check if the Queue contains a specific element
        bool containsBob = queue.Contains("Bob");
        Console.WriteLine("Contains Bob: " + containsBob);
        // Traverse the Queue
        Console.WriteLine("Queue elements:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        // Copie the Queue to an array
        string[] array = queue.ToArray();
        // Clear the Queue
        queue.Clear();
        Console.WriteLine("Queue cleared. Count: " + queue.Count);
           //Real - life use case:

                //Printer queue 🖨️ → first document sent gets printed first.
                
               //Customer service system → first customer enters, first served.
    }
}
