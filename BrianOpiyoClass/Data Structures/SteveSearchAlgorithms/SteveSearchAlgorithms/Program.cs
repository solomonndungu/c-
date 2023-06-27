using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SteveSearchAlgorithms
{
    public class Program
    {     
        public static void Main(string[] args)
        {
            // BinarySearchProgram binarySearchInstance = new BinarySearchProgram();

            Console.Write("Enter the numbers separated by spaces: ");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // Input array

            Console.Write("Enter the target number to search: ");
            int target = int.Parse(Console.ReadLine()); // Target value to search

            int result = BinarySearchProgram.BinarySearch(nums, target); // Call BinarySearch method to find the index

            if (result != -1) // If target is found
            {
                Console.WriteLine($"Target {target} found at index {result}");
            }
            else
            {
                Console.WriteLine($"Target {target} not found in the array");
            }
        }
    }
}