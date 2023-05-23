class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter Year : ");
        int Year = Convert.ToInt32(Console.ReadLine());

      //  static bool IsLeapYear(int Year)
      //  {


        if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
        {
             Console.WriteLine("{0} is a Leap Year.", Year);// return true
        }
        else
        { 
             Console.WriteLine("{0} is not a Leap Year.", Year);// return false
        }
       // }

    }
}