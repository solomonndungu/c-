using System;

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public static class Demo
{
    public static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

        foreach (int num in evenNumbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Console.Read();

        List<Dog> dogs = new List<Dog>()
        {
            new Dog { Name = "Rex", Age = 4},
            new Dog { Name = "Stacy", Age = 1},
            new Dog { Name = "Ruru", Age = 3}
        };

        var names = dogs.Select(x => x.Name);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.Read();

        var newDogList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
        foreach (var item in newDogList)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}