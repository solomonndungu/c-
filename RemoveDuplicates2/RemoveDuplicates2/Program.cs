using System;
using System.Collections.Generic;

// Manually
var size = A.Length;

for (int i = 0; i < size; i++)
{
    for (int j = i + 1;j < size; j++)
    {
        if (A[i] == A[j])
        {
            for (int k = j; k < size - 1; k++)
            {
                A[k] = A[k + 1];
            }
            j--;
            size--;
        }
    }
}

var distinctArray = A[0..size];

Console.WriteLine(A);

// Using HashSet
public class Example
{
    public static T[] removeDuplicates<T>(T[] array)
    {
        HashSet<T> set = new HashSet<T>(array);
        T[] result = new T[set.Count];
        set.CopyTo(result);
        return result;
    }

    public static void Main()
    {
        int[] array = { 2, 3, 3, 4, 1, 2, 5 };
        int[] distinct = removeDuplicates(array);

        Console.WriteLine(String.Join(",", distinct));
    }
}

// Simple version
// var distinctArray = arrayWithDuplicateValues.ToHashSet().ToArray();

// Using the HashSet Constructor
// var hashSet = new HashSet<T>(arrayWithDuplicateValues);
// var distinctArray = hashSet.ToArray();