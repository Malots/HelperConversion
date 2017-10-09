using System;

namespace HelperConversion
{
    /// <summary>
    /// Static class with useful array helpers
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Check if array is null or empty
        /// </summary>
        /// <param name="array">array value</param>
        /// <returns>true or false</returns>
        public static bool IsNullOrEmpty(this Array array)
        {
            return (array == null || array.Length == 0);
        }
    }
}
