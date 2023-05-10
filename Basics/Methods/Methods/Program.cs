using System;

public class Person
{
    public String FirstName;
}

public class ClassTypeExample
{
    public static void Main()
    {
        var p1 = new Person();
        p1.FirstName = "John";
        var p2 = new Person();
        p2.FirstName = "John";

        Console.WriteLine("p1 = p2: {0}", p1.Equals(p2));
    }
} // Returns false

// Passing parameters by value
public class ByValueExample
{
    public static void Main()
    {
        int value = 20;
        Console.WriteLine("In Main, value = {0}", value);

        ModifyValue(value);

        Console.WriteLine("Back in Main, value = {0}", value);
    }

    static void ModifyValue(int i)
    {
        i = 30;
        Console.WriteLine("In ModifyValue, parameter value = {0}", i);
        return;
    }
} // In Main, value = 20
    // In ModifyValue, parameter value = 30
    // Back in Main, value = 20

// Passing object of a reference type to a method by value
public class SampleRefType
{
    public int value;
}

public class ByRefTypeExample
{
    public static void Main()
    {
        var rt = new SampleRefType();
        rt.value = 44;

        ModifyObject(rt);

        Console.WriteLine(rt.value);
    }

    static void ModifyObject(SampleRefType obj)
    {
        obj.value = 33;
    }
}