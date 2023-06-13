using System;
namespace GroupWork
{
	public class RemoveDuplicates
	{
		public int[] RemoveDuplicate(int[] arr)
		{
			// Create a HashSet to track unique elements
			HashSet<int> set = new HashSet<int>();

			// Create a list to store the unique elements
			List<int> list = new List<int>();

			// Iterate through the array
			foreach (int i in arr)
			{
				// Check if the element is not already in the HashSet
				if (!set.Contains(i))
				{
					// Add the element to the HashSet and the list
					set.Add(i);
					list.Add(i);
				}
			}
			// Convert the list back to an array and return it
			return list.ToArray();
		}
	}
}

