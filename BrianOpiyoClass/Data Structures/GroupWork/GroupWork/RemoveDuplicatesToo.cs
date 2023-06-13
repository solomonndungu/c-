using System;
namespace GroupWork
{
	public class RemoveDuplicatesToo: RemoveDuplicates
	{
		public override int[] RemoveDuplicate(int[] shemArr)
		{
			HashSet<int> set = new HashSet<int>(shemArr);

			int[] result = new int[set.Count];

			set.CopyTo(result);

			//Console.WriteLine("{0}", result);
			return result;
		}
	}
}

