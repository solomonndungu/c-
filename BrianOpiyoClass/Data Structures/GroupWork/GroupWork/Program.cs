namespace GroupWork
{

    public class Program : RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            // Define the input array with duplicates
            int[] shemArr = new int[] { 1, 2, 3, 4, 1, 5, 2 };

            // Call the RemoveDuplicates method to remove duplicates from the array
            int[] uniqueArr = RemoveDuplicate(shemArr);

            // Display Array with no duplicates
            Console.WriteLine(String.Join(",", uniqueArr));

            // Define the target sum
            int target = 7;

            // Call the Complements method to find the indices of two numbers that add up to the target sum
            int[] indices = Complements(uniqueArr, target);

            // Check if indices exist
            if (indices != null)
            {
                Console.WriteLine($"The numbers at indices {indices[0]} and {indices[1]} add up to the target.");
            }
            else
            {
                Console.WriteLine("No two numbers in the array add up to the target.");
            }
        }
    }

}