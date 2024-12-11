namespace LeapYear
{
    public class LeapYear
    {
        internal static bool IsLeapYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("Year cannot be negative");
            }
            if (year % 400 == 0)
            {
                return true;
            }
            if (year % 100 == 0)
            {
                return false;
            }
            if (year % 4 == 0)
            {
                return true;
            }

            return false;


        }
    }
}
