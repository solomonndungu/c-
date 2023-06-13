using System;
namespace GroupWork
{
	public class Complement: RemoveDuplicates
	{
		// Find two numbers in an array that add up to a target sum
		public int[] Complements(int[] arr, int target)
		{
			// Create a dictionary to store the complement of each element and its index
			Dictionary<int, int> numDict = new Dictionary<int, int>();

			// Iterate through the array
			for (int i = 0; i < arr.Length; i++)
			{
				// Calculate the complement (target minus the current element)
				int complement = target - arr[i];

				// Check if the complement exists in the dictionary
				if (numDict.ContainsKey(complement))
				{
					// If the complement exists, return the indices of the current element and its complement
					return new int[] { numDict[complement], i }; // Use continue to allow for calculation of complexity
				}

				// Add the current element to the dictionary with its index as the value
				numDict[arr[i]] = i;
			}

			// Return null if no two numbers add up to the target sum
			int [] sero = new int[] { 0 };
			return sero;
		}
	}
}

