using System;
namespace SearchAlgo
{
	public class LogArr
	{
        public string LogArray(int[] nums)
        {
            string arrayString = "[";
            foreach (int num in nums)
            {
                arrayString += $"{num},";
            }
            return arrayString.Trim(',') + "]";
        }

    }
}

