using System;

public class ByRefExample
{
    public static void Main()
    {
        int value = 20;
        Console.WriteLine("In Main, value = {0}", value);

        ModifyValue(ref value);

        Console.WriteLine("Back in Main, value = {0}", value);
    }

    static void ModifyValue(ref int i)
    {
        i = 30;
        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
        return;
    }// 20
} // then 30 for both

// Red parameters to swap values of variables
public class RefSwapExample
{
    static void Main()
    {
        int i = 2, j = 3;
        Console.WriteLine("i = {0} j = {1}", i, j);

        Swap(ref i, ref j);

        Console.WriteLine("i = {0} j = {1}", i, j);
    }

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}