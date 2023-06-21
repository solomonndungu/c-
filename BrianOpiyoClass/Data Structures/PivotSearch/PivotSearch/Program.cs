namespace PivotSearch
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            // Pivot target is 3
            int pivot = 3;

            Console.WriteLine("Input Array : ");
            Console.WriteLine("------------------------------------------------ ");

            RotatedArray rotatedArray = new RotatedArray();

            for (int row = 0; row < array.Length; row++)
            {
                Console.WriteLine(array[row]);
            }

            int[] rotatedArrai = rotatedArray.RotateArray(array, pivot);

            Console.WriteLine(String.Format("\n\nArray After Rotating to Pivot {0} : ", pivot));
            Console.WriteLine("------------------------------------------------ ");

            for (int row = 0; row < rotatedArrai.Length; row++)
            {
                Console.WriteLine(rotatedArrai[row]);
            }
        }

    }

}

// System Requirement: Functional and Non-functional
// Feasibility
// Problem statement
// Solution

// Device Management System
// Reimbursement (Internet, Insurance cover, cable/charger replacement, transport cost)