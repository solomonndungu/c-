// Write a program that displays prime numbers between 0 - 100

public class PrimeNumbers
{
    public static void Main()
    {
        // Write does not add a new line, so you have to include the \n
        Console.Write("Prime numbers between 1 and 100 are:\n");

        // Loop to check for each number in the range
        for (int i = 2; i <= 100; ++i)
        {
            // Maintain factor count
            int ctr = 0;

            // Checking for factors
            for (int j = 2; j <= Math.Sqrt(i); ++j)
            {
                if (i % j == 0)
                {
                    // Increase factor count when found
                    ctr = 1;
                }
            }

            // Checking and printing prime numbers
            if (ctr == 0)
            {
                // WriteLine can add a new line
                Console.WriteLine($"{i} ");
            }
        }

    }
}