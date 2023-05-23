class LeapYear
{
    static bool Main(int Year)
    {
        if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}