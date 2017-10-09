using System;

namespace HelperConversion
{
    /// <summary>
    /// Static class with useful date helpers
    /// </summary>
    public static class DateHelper
    {
        /// <summary>
        /// Get age from date
        /// </summary>
        /// <param name="birthdate">Date</param>
        /// <returns>Age</returns>
        public static int GetAge(this DateTime birthdate)
        {
            int years = DateTime.UtcNow.Year - birthdate.Year;
            if ((birthdate.Month > DateTime.UtcNow.Month) || 
                (birthdate.Month == DateTime.UtcNow.Month && birthdate.Day > DateTime.UtcNow.Day))
                years--;
            return years;
        }

        /// <summary>
        /// Return numbers of days between two dates
        /// </summary>
        /// <param name="current">start date</param>
        /// <param name="another">end date</param>
        /// <returns>Days</returns>
        public static int GetDaysBetween(this DateTime current, DateTime another)
        {
            return another.Subtract(current).Days;
        }
    }
}
