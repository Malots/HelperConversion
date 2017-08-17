using System;

namespace HelperConversion
{
    public static class DateHelper
    {
        public static int Age(this DateTime birthdate)
        {
            int years = DateTime.Now.Year - birthdate.Year;
            if ((birthdate.Month > DateTime.Now.Month) || (birthdate.Month == DateTime.Now.Month && birthdate.Day > DateTime.Now.Day))
                years--;
            return years;
        }
    }
}
