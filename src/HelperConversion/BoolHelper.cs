using System;
using System.Collections;

namespace HelperConversion
{
    /// <summary>
    /// Static class with useful bool helpers
    /// </summary>
    public static class BoolHelper
    {
        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>string value</returns>
        public static string IfThen(this bool condition, string valueIfTrue, string valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>int value</returns>
        public static int IfThen(this bool condition, int valueIfTrue, int valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>long value</returns>
        public static long IfThen(this bool condition, long valueIfTrue, long valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>float value</returns>
        public static float IfThen(this bool condition, float valueIfTrue, float valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>datetime value</returns>
        public static DateTime IfThen(this bool condition, DateTime valueIfTrue, DateTime valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>decimal value</returns>
        public static decimal IfThen(this bool condition, decimal valueIfTrue, decimal valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>double value</returns>
        public static double IfThen(this bool condition, double valueIfTrue, double valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>char value</returns>
        public static Char IfThen(this bool condition, Char valueIfTrue, Char valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>char[] value</returns>
        public static Char[] IfThen(this bool condition, Char[] valueIfTrue, Char[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>object value</returns>
        public static object IfThen(this bool condition, object valueIfTrue, object valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Convert bool in char value
        /// </summary>
        /// <param name="value">bool value</param>
        /// <returns>char 1 or 0</returns>
        public static Char ToChar(this bool value)
        {
            return value ? '1' : '0';
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static string[] IfThen(this bool condition, string[] valueIfTrue, string[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static int[] IfThen(this bool condition, int[] valueIfTrue, int[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static long[] IfThen(this bool condition, long[] valueIfTrue, long[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static float[] IfThen(this bool condition, float[] valueIfTrue, float[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static decimal[] IfThen(this bool condition, decimal[] valueIfTrue, decimal[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static double[] IfThen(this bool condition, double[] valueIfTrue, double[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static DateTime[] IfThen(this bool condition, DateTime[] valueIfTrue, DateTime[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>array value</returns>
        public static object[] IfThen(this bool condition, object[] valueIfTrue, object[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        /// <summary>
        /// Check condition value and return value if is true or false
        /// </summary>
        /// <param name="condition">bool condition</param>
        /// <param name="valueIfTrue">value if condition is true</param>
        /// <param name="valueIfFalse">value if condition is false</param>
        /// <returns>Enumerable value</returns>
        public static IEnumerable[] IfThen(this bool condition, IEnumerable[] valueIfTrue, IEnumerable[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }
    }
}
