using System;
namespace GroupWork
{
	public class RemoveDuplicatesToo
	{
		public T[] removeDuplicatesToo<T>(T[] shemArr)
		{
			HashSet<T> set = new HashSet<T>(shemArr);

			T[] result = new T[set.Count];

			set.CopyTo(result);

			return result;
		}
	}
}

