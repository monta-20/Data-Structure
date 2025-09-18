/*
 📌 Browser Back/Forward Navigation with Stacks
🎯 Concept

Browsers use two stacks:

Back stack → stores the history of visited pages.

Forward stack → stores pages you can go forward to after going back.

👉 When you visit a new page:

Push it into the Back stack.

Clear the Forward stack (because forward history is reset).

👉 When you click Back:

Pop from Back stack → move to Forward stack.

👉 When you click Forward:

Pop from Forward stack → move to Back stack.
 */
namespace Training_console
{
    class Browser
    {
        private Stack<string> backStack = new Stack<string>();
        private Stack<string> forwardStack = new Stack<string>();
        private string currentPage;

        public void Visit(string url)
        {
            if (currentPage != null)
            {
                backStack.Push(currentPage);
            }
            currentPage = url;
            forwardStack.Clear(); // reset forward history
            Console.WriteLine("Visited: " + currentPage);
        }

        public void Back()
        {
            if (backStack.Count > 0)
            {
                forwardStack.Push(currentPage);
                currentPage = backStack.Pop();
                Console.WriteLine("Back to: " + currentPage);
            }
            else
            {
                Console.WriteLine("No more pages in back history.");
            }
        }

        public void Forward()
        {
            if (forwardStack.Count > 0)
            {
                backStack.Push(currentPage);
                currentPage = forwardStack.Pop();
                Console.WriteLine("Forward to: " + currentPage);
            }
            else
            {
                Console.WriteLine("No more pages in forward history.");
            }
        }

        public void ShowCurrentPage()
        {
            Console.WriteLine("Current Page: " + currentPage);
        }
    }
}
