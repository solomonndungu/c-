namespace Stacks
{
    class Program {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();

            // Add elements in a stack
            stack1.Push("***********");
            stack1.Push("MCA");
            stack1.Push("MBA");
            stack1.Push("BCA");
            stack1.Push("BBA");
            stack1.Push("***********");

            Console.WriteLine("The elements in the stack1 are as:");

            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
            // Remove/pop elements
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();

            Console.WriteLine("After removal/pop the elements are");
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }

            // Get items from stack
            // Peek method gives the element located at the top of the stack
            Console.WriteLine("The peek element is:" + stack1.Peek());

            // Contain() method determines and returns true if an element is found in a stack
            Console.WriteLine("The element MCA contain in the stack" + stack1.Contains("MCA"));

            // Clear() method removes all elements from a stack
            stack1.Clear();
            Console.WriteLine("Elements now in the stack are:" + stack1.Count());
        }
    }
}