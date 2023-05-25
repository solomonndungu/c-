namespace Product
{
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

        static void Multiply()
        {
            Console.WriteLine("Enter first number");
            // Read number as string
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();

            // Parse input strings into numbers
            if(int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                // Calculate product
                int product = number1 * number2;

                Console.WriteLine($"The product of {number1} and {number2} is: {product}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integer numbers.");
            }
        }
    }

}