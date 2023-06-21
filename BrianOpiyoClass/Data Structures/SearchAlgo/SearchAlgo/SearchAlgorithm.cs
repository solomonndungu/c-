using System;

namespace SearchAlgo
{
    public class SearchAlgorithm: BinarySrch
    {
        public static void Main()
        {
            int val;

            int[] nums = new int[7];

            // int currMid; Not Used

            Console.WriteLine("Input 7 numbers from zero: ");

            // Accepting value from user
            for (val = 0; val < 7; val++)
            {
                // Store value in an array
                nums[val] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("---------------------------------------");

            LogArr logArray = new LogArr();

            Console.WriteLine("The numbers you have input are: ");

            Console.WriteLine("---------------------------------------");

            Console.WriteLine(logArray.LogArray(nums));

            Console.WriteLine("Enter target to pivot on:");
            int target = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your target is {0}", target);

            Console.WriteLine("Array after pivoting: ");

            Console.WriteLine("---------------------------------------");

            BinarySrch binarySearch = new BinarySrch();

            int bnSearch = binarySearch.BinarySearch(nums, target);//currMid

            for (int row = 0; row < bnSearch; row++)
            {
                Console.WriteLine(bnSearch);
            }

        }

    }
}