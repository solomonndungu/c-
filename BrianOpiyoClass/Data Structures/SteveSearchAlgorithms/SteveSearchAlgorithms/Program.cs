using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SteveSearchAlgorithms
{
    internal class Program
    {
        // Method to calculate the midpoint of an array length using integer division and adding 1 for odd lengths
        public int MidPoint(int arrayLength)
        {
            if (arrayLength % 2 == 0)
            {
                return arrayLength / 2;
            }
            else
            {
                return (arrayLength / 2) + 1;
            }
        }

        // Method overload to calculate the midpoint of an array by sorting it and returning the middle element
        public int MidPoint(int[] nums)
        {
            Array.Sort(nums);
            return nums.Length / 2;
        }

        // Method to concatenate array elements into a string using a loop
        public string LogArray(int[] nums)
        {
            string arrayString = "[";
            foreach (int num in nums)
            {
                arrayString += $"{num},";
            }
            return arrayString.Trim(',') + "]";
        }

        // Method overload to concatenate array elements into a string using a custom separator
        public string LogArray(int[] nums, string separator)
        {
            // return string.Join(separator, nums);
            return string.Concat(separator, nums);

        }

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

    internal class BinarySearchProgram : Program
    {
        // Binary search method to find the target number in the array
        public static int BinarySearch(int[] nums, int target, int currentMid = 0)

        {
            Program binaryObject = new BinarySearchProgram();

            Console.WriteLine(binaryObject.LogArray(nums)); // Log the current state of the array

            int result = nums.CheckSingleElement(target); // Check for single element and match
            if (result != -1) // If target is found
                return result;


            //            if (nums.Length == 1) // Base case: If the array has only one element
            //            {
            //                if (nums[0] == target)
            //                    return 0; // Return the index if it matches the target
            //               else
            //                    return -1; // Return -1 if the target is not found
            //            }

            int arrMid = binaryObject.MidPoint(nums.Length); // Calculate the midpoint of the array

            if (arrMid >= 0 && arrMid < nums.Length)
            {
                if (nums[arrMid] == target) // If the midpoint matches the target
                    return arrMid; // Return the index of the midpoint

                else
                {
                    List<int> leftArr = new List<int>();
                    List<int> rightArr = new List<int>();

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (i > arrMid)
                            rightArr.Add(nums[i]); // Add elements greater than the midpoint to the right array
                        else if (i < arrMid)
                            leftArr.Add(nums[i]); // Add elements less than the midpoint to the left array
                    }

                    Dictionary<string, int[]> twoHalves = new Dictionary<string, int[]>();
                    twoHalves.Add("left", leftArr.ToArray()); // Create a dictionary to store the left and right arrays
                    twoHalves.Add("right", rightArr.ToArray());

                    int final = -1;

                    foreach (var half in twoHalves)
                    {
                        if (half.Key == "left")
                            currentMid = -1;
                        else
                            currentMid = arrMid;

                        var recursiveResult = BinarySearch(half.Value, target, currentMid); // Recursive call for each half

                        if (recursiveResult == -1)
                            continue; // Continue the loop if target is not found in the current half
                        else
                        {
                            return recursiveResult + currentMid + 1; // Return the final index by adding the current midpoint and the result index
                        }
                    }

                    return final; // Return -1 if the target is not found
                }
            }
            else
                return -1; // Return -1 if the target is not found
        }
    }
    internal static class ArrayExtensions
    {
        // Extension method to check if the array has a single element that matches the target
        public static int CheckSingleElement(this int[] nums, int target)
        {
            if (nums.Length == 1 && nums[0] == target)
                return 0; // Return the index if it matches the target

            return -1; // Return -1 if the target is not found
        }
    }
}