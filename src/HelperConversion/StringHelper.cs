using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace HelperConversion
{
    /// <summary>
    /// Static class with useful string helpers
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Convert string to int32, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">int32 default value to return if conversion is not possible</param>
        /// <returns>int32 value</returns>
        public static int ToInt32(this string value, int defaultValue = int.MinValue)
        {
            return ToInt32(value, CultureInfo.CurrentCulture, defaultValue);
        }

        /// <summary>
        /// Convert string to int32, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">int32 default value to return if conversion is not possible</param>
        /// <param name="format">The format</param>
        /// <returns>int32 value</returns>
        public static int ToInt32(this string value, IFormatProvider format, int defaultValue = int.MinValue)
        {
            int convert = 0;
            return int.TryParse(value.Trim(), NumberStyles.Any, format, out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to int64, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">int64 default value to return if conversion is not possible</param>
        /// <returns>int64 value</returns>
        public static long ToInt64(this string value, long defaultValue = long.MinValue)
        {
            return ToInt64(value, CultureInfo.CurrentCulture, defaultValue);
        }

        /// <summary>
        /// Convert string to int64, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">int64 default value to return if conversion is not possible</param>
        /// <param name="format">The format</param>
        /// <returns>int64 value</returns>
        public static long ToInt64(this string value, IFormatProvider format, long defaultValue = long.MinValue)
        {
            long convert = 0;
            return long.TryParse(value.Trim(), NumberStyles.Any, format, out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to bool, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">bool default value to return if conversion is not possible</param>
        /// <returns>bool value</returns>
        public static bool ToBool(this string value, bool defaultValue = false)
        {
            bool convert = false;
            return bool.TryParse(value.Trim().ToLower(), out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to float, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">float default value to return if conversion is not possible</param>
        /// <returns>float value</returns>
        public static float ToFloat(this string value, float defaultValue = float.MinValue)
        {
            float convert = 0;
            return float.TryParse(value.Trim(), out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to ip, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">ip default value to return if conversion is not possible</param>
        /// <returns>ip object</returns>
        public static IPAddress ToIp(this string value, IPAddress defaultValue = null)
        {
            IPAddress convert = null;
            return IPAddress.TryParse(value.Trim(), out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to byte UTF8, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">byte default value to return if conversion is not possible</param>
        /// <returns>byte uft8 value</returns>
        public static byte[] ToByteUTF8(this string value, byte[] defaultValue = null)
        {
            byte[] convert = null;
            try
            {
                convert = Encoding.UTF8.GetBytes(value);
            }
            catch
            {
                convert = defaultValue;
            }
            return convert;
        }

        /// <summary>
        /// Return only valid numbers in string
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>string with only numbers or empty</returns>
        public static string GetOnlyNumbers(this string value)
        {
            return string.IsNullOrEmpty(value) ? "" : new String(value.Where(Char.IsDigit).ToArray());
        }

        /// <summary>
        /// Return reverse string
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>reverse string</returns>
        public static string ReverseString(this string value)
        {
            char[] arr = value.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Convert string to datetime
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>Datetime value</returns>
        public static DateTime ToDate(this string value)
        {
            return ToDate(value, DateTime.Now);
        }

        /// <summary>
        /// Convert string to datetime, if it is not possible return default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">datetime default value if conversion is not possible</param>
        /// <returns>Datetime value</returns>
        public static DateTime ToDate(this string value, DateTime defaultValue)
        {
            DateTime convert;
            return DateTime.TryParse(value.Trim(), out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to double, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">double default value to return if conversion is not possible</param>
        /// <returns>double value</returns>
        public static double ToDouble(this string value, double defaultValue = double.MinValue)
        {
            return ToDouble(value, CultureInfo.CurrentCulture, defaultValue);
        }

        /// <summary>
        /// Convert string to double, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">double default value to return if conversion is not possible</param>
        /// <param name="format">The format</param>
        /// <returns>double value</returns>
        public static double ToDouble(this string value, IFormatProvider format, double defaultValue = double.MinValue)
        {
            double convert = 0;
            return double.TryParse(value.Trim(), NumberStyles.Any, format, out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Convert string to decimal, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">decimal default value to return if conversion is not possible</param>
        /// <returns>decimal value</returns>
        public static decimal ToDecimal(this string value, decimal defaultValue = decimal.MinValue)
        {
            return ToDecimal(value, CultureInfo.CurrentCulture, defaultValue);
        }

        /// <summary>
        /// Convert string to decimal, if it is not possible return the default value
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="defaultValue">decimal default value to return if conversion is not possible</param>
        /// <param name="format">The format</param>
        /// <returns>decimal value</returns>
        public static decimal ToDecimal(this string value, IFormatProvider format, decimal defaultValue = decimal.MinValue)
        {
            decimal convert = 0;
            return decimal.TryParse(value.Trim(), NumberStyles.Any, format, out convert) ? convert : defaultValue;
        }

        /// <summary>
        /// Remove mask from the string
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>string without mask</returns>
        public static string RemoveMask(this string value)
        {
            try
            {
                if (value.IsEmpty())
                {
                    return value;
                }
                var regex = new Regex(@"[^\w]");
                return regex.Replace(value, string.Empty);
            }
            catch 
            {
                return "";
            }
        }

        /// <summary>
        /// Check if string is null or empty
        /// </summary>
        /// <param name="value">string value</param>
        /// <returns>true ou false</returns>
        public static bool IsEmpty(this string value)
        {
            return (value == null) || (value.Trim() == "");
        }

        /// <summary>
        /// Get string between two values of the string
        /// </summary>
        /// <param name="value">string to search</param>
        /// <param name="start">start string</param>
        /// <param name="end">final string</param>
        /// <returns>string or empty</returns>
        public static string GetStringBetween(this string value, string start, string end)
        {
            return Regex.Match(value, Regex.Replace(start, @"[][{}()*+?.\\^$|]", @"\$0") + @"\s*(((?!" +
                Regex.Replace(start, @"[][{}()*+?.\\^$|]", @"\$0") + @"|" + Regex.Replace(end, @"[][{}()*+?.\\^$|]", @"\$0") + @").)+)\s*" +
                Regex.Replace(end, @"[][{}()*+?.\\^$|]", @"\$0"), RegexOptions.IgnoreCase).Value.Replace(start, "").Replace(end, "");
        }

        /// <summary>
        /// Get the substring after the string param
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="str">set a string to get value</param>
        /// <returns>string or empty</returns>
        public static string GetAfter(this string value, string str)
        {
            var posStr = value.LastIndexOf(str);
            if (posStr == -1) return string.Empty;
            var result = posStr + str.Length;
            return result >= value.Length ? string.Empty : value.Substring(result);
        }

        /// <summary>
        /// Get the substring before the string param
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="str">set a string to get value</param>
        /// <returns></returns>
        public static string GetBefore(this string value, string str)
        {
            var posStr = value.IndexOf(str);
            return posStr == -1 ? string.Empty : value.Substring(0, posStr);
        }
    }
}
