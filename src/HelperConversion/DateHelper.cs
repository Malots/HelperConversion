using System;

namespace HelperConversion
{
    public static class DateHelper
    {
        public static int Age(this DateTime birthdate)
        {
            int years = DateTime.UtcNow.Year - birthdate.Year;
            if ((birthdate.Month > DateTime.UtcNow.Month) || 
                (birthdate.Month == DateTime.UtcNow.Month && birthdate.Day > DateTime.UtcNow.Day))
                years--;
            return years;
        }

        public static int DaysBetween(this DateTime current, DateTime another)
        {
            return another.Subtract(current).Days;
        }
    }
}
