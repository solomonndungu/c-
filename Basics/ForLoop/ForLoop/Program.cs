// For loop

// for(initializer; condition; iterator)
//  {
//      do some task over and over
//
//  }

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Value of i is {i}");
}

for(int ii = 10; ii > 0; ii--)
{
    Console.WriteLine($"Value of ii is {ii}");
}

// List
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

foreach (int element in fibNumbers)
{
    Console.WriteLine($"Value of {element}");
}

// Array
var numbers = new int[] { 3, 14, 15, 92, 6 };

foreach (var elements in numbers)
{
    Console.WriteLine($"Value of element {elements}");
}