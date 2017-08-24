using System;

namespace HelperConversion
{
    public static class BoolHelper
    {
        public static string IfThen(this bool condition, string valueIfTrue, string valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static int IfThen(this bool condition, int valueIfTrue, int valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static float IfThen(this bool condition, float valueIfTrue, float valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static DateTime IfThen(this bool condition, DateTime valueIfTrue, DateTime valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static Decimal IfThen(this bool condition, Decimal valueIfTrue, Decimal valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static Char IfThen(this bool condition, Char valueIfTrue, Char valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static Char[] IfThen(this bool condition, Char[] valueIfTrue, Char[] valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static object IfThen(this bool condition, object valueIfTrue, object valueIfFalse)
        {
            return condition ? valueIfTrue : valueIfFalse;
        }

        public static Char ToChar(this bool value)
        {
            return value ? '1' : '0';
        }
    }
}
