//LinkedList
//A LinkedList is a collection of nodes where each node has:
//Value(data stored in the node)
//Pointer(reference to the next node, and sometimes the previous one)
//In C#, LinkedList<T> is a doubly linked list (each node has both Next and Previous references)
class Program
{
    static void Main(string[] args)
    {
        //Empty LinkedList of integers
        LinkedList<int> numbers = new LinkedList<int>();
        //LinkedList with initial values 
        LinkedList<int> initialNumbers = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        //Adding elements
        numbers.AddLast(10); // Add 10 at the end
        numbers.AddFirst(5); // Add 5 at the beginning
        numbers.AddAfter(numbers.First, 7); // Add 7 after the first node (which is 5)
        numbers.AddBefore(numbers.Last, 9); // Add 9 before the last node (which is 10) => 5,7,9,10
        // Traversing
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
        for(int num = 0; num < numbers.Count; num++)
        {
            Console.WriteLine(numbers.ElementAt(num));
        }
        //Removing elements
        numbers.Remove(7); // Remove the node with value 7
        numbers.RemoveFirst(); // Remove the first node (which is 5)
        numbers.RemoveLast(); // Remove the last node (which is 10)
        //Check if an element exists
        bool containsNine = numbers.Contains(9); // true
        Console.WriteLine($"Contains 9: {containsNine}");
        //Adding more elements
        numbers.AddLast(15);
        numbers.AddLast(20);
        numbers.AddLast(25);
        //Accessing elements by position 
        LinkedListNode<int> first = numbers.First; // First node
        LinkedListNode<int> last = numbers.Last; // Last node
        LinkedListNode<int> second = first.Next; // Second node
        LinkedListNode<int> secondLast = last.Previous; // Second last node
        Console.WriteLine($"First: {first.Value}, Second: {second.Value}, Last: {last.Value}, Second Last: {secondLast.Value}");
        //Finding a node
        LinkedListNode<int> Node = numbers.Find(15); // Find node with specific value
        if (Node != null)
        {
            Console.WriteLine("Found: " + Node.Value);
        }
        else
        {
            Console.WriteLine("Not Found");
        }
        //Clearing the LinkedList
        numbers.Clear();

        //When to Use LinkedList
             
             //When you need fast insertion and deletion(O(1)) at beginning, middle, or end.
             
             //When you don’t need fast random access(unlike arrays, numbers[2] is not possible directly).
    }
}
