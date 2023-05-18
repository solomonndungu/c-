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
            // https://stackoverflow.com/questions/5811151/why-do-we-check-up-to-the-square-root-of-a-number-to-determine-if-the-number-is#:~:text=To%20test%20whether%20a%20number,square%20root%20of%20that%20number%3F&text=because%20if%20n%20%3D%20a*b,%3D%20a*b%20%3D%20n%20.&text=To%20clarify%2C%20this%20means%20we,floor(sqrt(n))%20.
            // Above link to explain why we're using square root
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