using System;
namespace SteveSearchAlgorithms
{
    // Binary search method to find the target number in the array
    public class BinarySearchProgram : LogArray
	{
        public static int BinarySearch(int[] nums, int target, int currentMid = 0)

        {
            BinarySearchProgram binaryObject = new BinarySearchProgram();

            LogArray logArray = new LogArray();

            MidPoint midPoint = new MidPoint();

            Console.WriteLine(logArray.LogArrays(nums)); // Log the current state of the array

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

            int arrMid = midPoint.MidPoints(nums.Length); // Calculate the midpoint of the array

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

    public static class ArrayExtensions
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

