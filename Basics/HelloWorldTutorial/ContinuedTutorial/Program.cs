// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Type Casting

// Implicit
// int num = 6546546;
// long bigNum = num;

// Explicit
// double x = 1234.7;
// int a;
// Cast double to int
// a = (int)x;
// Console.WriteLine(a);


// Application. String to int
string value = "5616465";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure.");
}