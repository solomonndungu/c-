// https://www.c-sharpcorner.com/UploadFile/c25b6d/CSharp-Queue/

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();

            // Add an object to the end of queue
            queue1.Enqueue("MCA");
            queue1.Enqueue("MBA");
            queue1.Enqueue("BCA");
            queue1.Enqueue("BBA");

            Console.WriteLine("The elements in the queue are:");
            foreach(string s in queue1)
            {
                Console.WriteLine(s);
            }

            // Removes first element
            queue1.Dequeue();

            // Determine whether an element is in the queue
            Console.WriteLine("The element MCA is contained in queue:" + queue1.Contains("MCA"));

            // Removes all objects from the queue
            queue1.Clear();

            // Returns object at the beginning of the queue without removing it
            Console.WriteLine("Peek the first item from the queue is:" + queue1.Peek());

            // Copy queue elements to a new array
            Queue<string> queue2 = new Queue<string>(queue1.ToArray());

            Console.WriteLine("\n Contents of the copy");

            foreach(string n in queue2)
            {
                Console.WriteLine(n);
            }
        }
    }
}