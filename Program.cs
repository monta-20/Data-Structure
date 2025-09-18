//PriorityQueue
//Unlike a normal Queue (FIFO), a PriorityQueue serves elements based on their priority, not just order.
//Higher (or lower, depending on configuration) priority elements are dequeued first.
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a PriorityQueue instance
        PriorityQueue<string , int > priorityQueue = new PriorityQueue<string, int>();
        // Enqueue elements with associated priorities
        priorityQueue.Enqueue("Task 1", 2); // Lower number = higher priority
        priorityQueue.Enqueue("Task 2", 1);
        priorityQueue.Enqueue("Task 3", 3);
        while (priorityQueue.Count > 0)
        {
            Console.WriteLine(priorityQueue.Dequeue()); //Removes and returns the element with the highest priority(lowest number) => Task 2
        }
        // Safely dequeue without throwing an exception if the queue is empty
        if (priorityQueue.TryDequeue(out string? item, out int priority))
        {
            Console.WriteLine($"Dequeued: {item} with priority {priority}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
        // Peek element in queue 
        Console.WriteLine(priorityQueue.Peek()); //Returns the element with the highest priority without removing it => Task 1
        // Clear the queue
        priorityQueue.Clear();
        Console.WriteLine($"Queue count after clear: {priorityQueue.Count}"); // 0
        /* 
         
         Real-life Use Cases in Web Applications

             Job Scheduling → Process urgent tasks (e.g., security alerts) before low-priority ones.

             Message Delivery → Prioritize system messages over user messages.

             Search Engines → Process the most relevant queries first.

             Networking → Prioritize packets (e.g., video call packets over file downloads).
         
         */

    }
}
