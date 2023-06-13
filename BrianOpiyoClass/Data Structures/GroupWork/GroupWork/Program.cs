namespace GroupWork
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // Define the input array with duplicates
            int[] shemArr = new int[] { 1, 2, 3, 4, 1, 5, 2 };

            RemoveDuplicates sticaScolar = new RemoveDuplicates();

            RemoveDuplicatesToo pascalSync = new RemoveDuplicatesToo();

            Complement complement = new Complement();

            ComplementsToo complementToo = new ComplementsToo();

            // Scolar results with no duplicates
            int[] scolar = sticaScolar.RemoveDuplicate(shemArr);

            Console.WriteLine("Scolar results with no duplicates: ");
            Console.WriteLine(String.Join(",", scolar));

            // Pascal Sync results with no duplicates
            int[] pascal = pascalSync.RemoveDuplicate(shemArr);

            Console.WriteLine("Pascal Results with no duplicates: ");
            Console.WriteLine(String.Join(",", pascal));

            // Define the target sum
            int target = 7;

            // Call the Complements method to find the indices of two numbers that add up to the target sum
            int[] indices = complement.Complements(scolar, target);

            // Check if indices exist
            if (indices != null)
            {
                Console.WriteLine($"The numbers at indices {indices[0]} and {indices[1]} add up to the target.");
            }
            else
            {
                Console.WriteLine("No two numbers in the array add up to the target.");
            }


            var nums = complementToo.Complements(shemArr, 7);

            foreach (var val in nums)
            {
                Console.WriteLine($"{val.Key} at indices {val.Value}");
             }
        }
    }
    

}