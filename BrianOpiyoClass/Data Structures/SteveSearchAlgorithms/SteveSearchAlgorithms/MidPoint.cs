using System;
namespace SteveSearchAlgorithms
{
	public class MidPoint
	{
        // Method to calculate the midpoint of an array length using integer division and adding 1 for odd lengths
        public int MidPoints(int arrayLength)
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
        public int MidPoints(int[] nums)
        {
            Array.Sort(nums);
            return nums.Length / 2;
        }
    }
}

