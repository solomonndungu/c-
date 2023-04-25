using System;
using System.Collections.Generic;

class GFG
{

    // Driver code
    public static void Main()
    {

        // Creating a HashSet of odd numbers
        HashSet<int> odd = new HashSet<int>();

        // Inserting elements in HashSet
        for (int i = 0; i < 5; i++)
        {
            odd.Add(2 * i + 1);
        }

        // Displaying the elements in the HashSet
        foreach (int i in odd)
        {
            Console.WriteLine(i);
        }
    }
}
