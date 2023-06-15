namespace PivotSearch
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 0, 1, 2, 4, 5, 6, 7 };
            // Pivot target is 3
            int pivot = 3;

            Console.WriteLine("Input Array : ");
            Console.WriteLine("------------------------------------------------ ");

            for (int row = 0; row < array.Length; row++)
            {
                Console.WriteLine(array[row]);
            }

            var rotatedArray = RotateArray(array, pivot);

            Console.WriteLine(String.Format("\n\nArray After Rotating to Pivot {0} : ", pivot));
            Console.WriteLine("------------------------------------------------ ");

            for (int row = 0; row < rotatedArray.Length; row++)
            {
                Console.WriteLine(rotatedArray[row]);
            }
        }

        public static int[] RotateArray(int[] array, int pivot)
        {
            if (pivot < 0 || array == null)
                throw new Exception("Invalid argument");

            // Gets the index of where the pivot will occur
            pivot = pivot % array.Length;

            //Rotate first half
            array = RotateSubArray(array, 0, pivot - 1);

            //Rotate second half
            array = RotateSubArray(array, pivot, array.Length - 1);

            //Rotate all
            array = RotateSubArray(array, 0, array.Length - 1);

            return array;
        }

        private static int[] RotateSubArray(int[] subArray, int start, int end)
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