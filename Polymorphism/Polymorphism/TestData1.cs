using System;

TestData dataClass = new TestData();
int add2 = dataClass.Add(45, 34, 67);
int add1 = dataClass.Add(34, 3);

public class TestData
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}