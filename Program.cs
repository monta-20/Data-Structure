//Stack
//A stack is a collection that follows the LIFO principle (Last In, First Out)
using Training_console;

class Program
{
    static void Main(string[] args)
    {
        // Create a stack of integers
        Stack<int> stack = new Stack<int>();
        // Create a stack with initial values
        Stack<int> initialStack = new Stack<int>(new int[] { 1, 2, 3, 4, 5, });
        // Push elements onto the stack 
        stack.Push(1);
        stack.Push(2);
        // Count the number of elements in the stack
        Console.WriteLine("Count: " + stack.Count);
        // Peek at the top element without removing it
        Console.WriteLine("Top element: " + stack.Peek());
        // Pop elements from the stack
        Console.WriteLine("Popped element: " + stack.Pop());
        // Check if the stack contains a specific element
        Console.WriteLine("Contains 1: " + stack.Contains(1));
        // Traverse the stack
        foreach(int item in stack)
        {
            Console.WriteLine(item);
        }
        // Set the capacity of the stack
        // Useful when you know no more elements will be added to the stack, and you want to minimize memory overhead
        stack.TrimExcess();
        // Coping the stack to an array (in LIFO order)
        int[] array = stack.ToArray();
        // Clear the stack
        stack.Clear();

        // When using stack 
        // 1. Use stack when you need to reverse the order of elements or when you need to backtrack (e.g., in algorithms like depth-first search).
        // 2. Avoid using stack when you need random access to elements or when you need to frequently search for elements, as stacks do not support these operations efficiently.
        // 3. Undo/Redo in editors (last action undone first).
        // 4. Browser back/ forward navigation.
        // I will this cas 
        Browser browser = new Browser();
        browser.Visit("page1.com");
        browser.Visit("page2.com");
        browser.Back(); // goes back to page1.com
        browser.Forward(); // goes forward to page2.com
        browser.Visit("page3.com"); // visits a new page, forward history is cleared
    }
}
