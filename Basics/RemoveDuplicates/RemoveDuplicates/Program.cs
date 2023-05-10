using System;
public class RemoveDuplicate {

    public static int[] ToRemoveDuplicates(int[] arr)
    {
        int[] A;
        int i, j, k = 0; // p = 10;

        Console.WriteLine("Enter size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter elements of array : ");

        for (i = 0; i < n; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < k; j++)
            {
                if (A[i] == arr[j])
                {
                    break;
                }
                if (j == k)
                {
                    arr[k] = A[i];
                    k++;
                }
            }
            Console.WriteLine("Integers after duplicate removal");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine($" {arr[i]}");
            }

            //  return p;

        }
        return arr;
    }
}
