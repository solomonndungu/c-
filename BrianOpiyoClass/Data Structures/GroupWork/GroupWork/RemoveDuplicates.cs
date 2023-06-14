using System;
namespace GroupWork
{
	// Base Class
	public class RemoveDuplicates
	{
		public virtual int[] RemoveDuplicate(int[] shemArr)
		{
			// Create a HashSet to track unique elements
			HashSet<int> set = new HashSet<int>();

			// Create a list to store the unique elements
			List<int> list = new List<int>();

			// Iterate through the array
			foreach (int i in shemArr)
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
			int[] returnList = list.ToArray();

			//Console.WriteLine($"{returnList}");
			return returnList;
		}
	}
}

