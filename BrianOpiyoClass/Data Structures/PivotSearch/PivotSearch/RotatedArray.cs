using System;
namespace PivotSearch
{
	public class RotatedArray: RotatedSubArray
	{
        public int[] RotateArray(int[] array, int pivot)
        {

            RotatedSubArray rotatedSubArray = new RotatedSubArray();
            if (pivot < 0 || array == null)
                throw new Exception("Invalid argument");

            // Gets the index of where the pivot will occur
            pivot %= array.Length;

            //Rotate first half
            array = rotatedSubArray.RotateSubArray(array, 0, pivot - 1);

            //Rotate second half
            array = rotatedSubArray.RotateSubArray(array, pivot, array.Length - 1);

            //Rotate all
            array = rotatedSubArray.RotateSubArray(array, 0, array.Length - 1);

            return array;
        }
    }
}

