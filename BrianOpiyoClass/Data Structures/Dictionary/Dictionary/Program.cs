using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        int[] num = new int [] { 1, 2, 3, 1, 4, 2, 5 };
        int[] uniqueValues = RemoveDuplicates(num);
        int target = 7;
        int[] dictValues = DictOptionToSimplify(uniqueValues, target);

        Console.WriteLine("Unique Values without Duplicates");

        foreach(int value in uniqueValues)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("Sum Output Bruteforce:");

        int[] sumOutput = GetSum(uniqueValues, target);

        if (sumOutput.Length == 0)
        {
            Console.WriteLine("No pair found.");
        }
        else
        {
            Console.WriteLine("Indices of the paired numbers:");
            Console.WriteLine(sumOutput[0]);
            Console.WriteLine(sumOutput[1]);
        }

        if (dictValues.Length == 0)
        {
            Console.WriteLine("No pair in Dictionary found.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Dictionary Sum Implementation");
            Console.WriteLine(dictValues[0]);
            Console.WriteLine(dictValues[1]);
        }
    }
    public static int[] RemoveDuplicates(int[] num)
    {

        HashSet<int> set = new(num);

        int[] result = new int[set.Count];

        set.CopyTo(result);

        return result;
    }
    public static int[] GetSum(int[] arr, int target)
    {
        if (arr == null || arr.Length < 2)
        {
            return Array.Empty<int>();
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                    return new int[] { i, j };
            }
        }
        return Array.Empty<int>();
    }

    private static int[] DictOptionToSimplify(int[] arr, int target)
    {
        Dictionary<int, int> dictValues = new();

        // Validations
        if (arr == null || arr.Length < 2)
        {
            return Array.Empty<int>();
        }

        for (int i = 0; i < arr.Length; i++)
        {
            int firstNumber = arr[i];
            int secondNumber = target - firstNumber;
            if (dictValues.TryGetValue(secondNumber, out int index))
            {
                return new[] { index, i };
            }

            dictValues[firstNumber] = i;
        }
        return Array.Empty<int>();
    }

}