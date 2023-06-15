
namespace RotateAtIndexAssignment;

public class IndexRotate
{
    public static void Main(string[] args)
    {
        var rotatedList = Rotater(new int[] { 0, 1, 2, 4, 5, 6, 7 }, 3);
        Console.WriteLine(string.Join(" ", rotatedList));
    }

    static List<int> Rotater(int[] initialArr, int pivot)
    {
        List<int> listToRotate = new List<int>(initialArr);
        List<int> rotatedList = new List<int>(new int[initialArr.Length]);

        for (int i = pivot; i >= 0; i--)
        {
            int maxInList = listToRotate.Max();
            rotatedList[i] = maxInList;
            listToRotate.Remove(maxInList);
        }

        for (int i = pivot + 1; i < initialArr.Length; i++)
        {
            int minInList = listToRotate.Min();
            rotatedList[i] = minInList;
            listToRotate.Remove(minInList);
        }

        return rotatedList;
    }
}