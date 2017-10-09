namespace HelperConversion
{
    /// <summary>
    /// Static class with useful char helpers
    /// </summary>
    public static class CharHelper
    {
        /// <summary>
        /// Convert char value to integer
        /// </summary>
        /// <param name="value">char value</param>
        /// <param name="defaultValue">int default value</param>
        /// <returns>integer or default value</returns>
        public static int ToInt(this char value, int defaultValue = int.MinValue)
        {
            int convert = 0;
            return int.TryParse(value.ToString(), out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert char value to bool
        /// </summary>
        /// <param name="value">char value</param>
        /// <returns>true or false</returns>
        public static bool ToBool(this char value)
        {
            return (value == '1') ? true : false;
        }
    }
}
