using System;

var arr = new int[] { 1, 2, 3, 4, 5 };

Dictionary<string, string> FindAdditivesLoop(int[] arrIter, int targetSum)
{
    HashSet<int> uniqueArr = new HashSet<int>(arrIter);

    Dictionary<string, string> candidateNums = new Dictionary<string, string>();

    foreach (int i in uniqueArr)
    {
        int firstNum = i;

        foreach (int j in uniqueArr)
        {
            int secondNum = j;

            if ((firstNum + secondNum) == targetSum)
            {
                candidateNums.Add($"{firstNum} + {secondNum}", Array.IndexOf(arrIter, firstNum) + ", " + Array.IndexOf(arrIter, secondNum));
            }
        }
        uniqueArr.Remove(firstNum);
    }

    return candidateNums;
}

var nums = FindAdditivesLoop(arr, 7);

foreach (var val in nums)
{
    Console.WriteLine($"{val.Key} at indices {val.Value}");
}