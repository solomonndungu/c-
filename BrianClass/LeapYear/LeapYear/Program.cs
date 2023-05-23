class LeapYear
{
    public static void Main()
    {
        Console.WriteLine("Enter Year : ");
        int Year = Convert.ToInt32(Console.ReadLine());
        if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
        {
            Console.WriteLine("{0} is a leap year", Year); // return true;
        }
        else
        {
            Console.WriteLine("{0} is not a leap year", Year);//return false;
        }
    }
}