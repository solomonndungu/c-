using System;

namespace SearchAlgo
{
    public class SearchAlgorithm: BinarySrch
    {
        public static void Main(string[] args)
        {
            // Take value from user input
            int val;

            // Convert the input value to array
            int[] nums = new int[7];

            // int currMid; Not Used

            Console.WriteLine("Input 7 numbers from zero: ");

            // Accepting value from user
            for (val = 0; val < 7; val++)
            {
                // Store value in an array
                // Keyboard input is string, so convert to int
                nums[val] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("---------------------------------------");

            // Object to Instantiate logArr class to be used here
            LogArr logArray = new();

            Console.WriteLine("The numbers you have input are: ");

            Console.WriteLine("---------------------------------------");

            Console.WriteLine(logArray.LogArray(nums));

            Console.WriteLine("Enter target to pivot on:");
            int target = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your target is {0}", target);

            // Console.WriteLine("Array after pivoting: ");

            // Console.WriteLine("---------------------------------------");

            // Object to Instantiate BinarySrch class to be used here

            BinarySrch binarySearch = new();

            int bnSearch = binarySearch.BinarySearch(nums, target);//currMid

            if (bnSearch != -1)
            {
                Console.WriteLine($"Target value found at index: {bnSearch}");
            }
            else
                Console.WriteLine("Target value ot found in the array");


        }

    }
}