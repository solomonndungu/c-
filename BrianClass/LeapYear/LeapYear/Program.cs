class LeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Year : ");
        int year = Convert.ToInt32(Console.ReadLine());

        if(IsLeapYear(year))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
     
    }

    public static bool IsLeapYear(int Year)
    {
        if ((Year % 4 == 0) && (Year % 100 != 0) || (Year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// Different types of programming (OOP, procedural, structural)

// List different access modifiers and extend c# with the different access modifiers
// Variables stating the different access modifiers listed

// Assigning to constructor of the object when assigning