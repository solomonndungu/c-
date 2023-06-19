using System;
namespace PivotSearch
{
	public class RotatedSubArray
	{
        public int[] RotateSubArray(int[] subArray, int start, int end)
        {
            while (start < end)
            {
                int temp = subArray[start];
                subArray[start] = subArray[end];
                subArray[end] = temp;
                start++;
                end--;
            }
            return subArray;
        }
    }
}

