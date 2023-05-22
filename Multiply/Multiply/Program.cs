public class Program
{
    public static void Main()
    {
        int num1, num2, result;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        result = num1 * num2;

        Console.WriteLine("The product of two numbers is:" + result);
    }
}