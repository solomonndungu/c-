using System;
namespace SteveSearchAlgorithms
{
	public class LogArray: MidPoint
	{
        // Method to concatenate array elements into a string using a loop
        public string LogArrays(int[] nums)
		{
            string arrayString = "[";
            foreach (int num in nums)
            {
                arrayString += $"{num},";
            }
            return arrayString.Trim(',') + "]";
        }

        // Method overload to concatenate array elements into a string using a custom separator
        public string LogArrays(int[] nums, string separator)
        {
            // return string.Join(separator, nums);
            return string.Concat(separator, nums);

        }
    }
}

