namespace HelperConversion
{
    public static class CharHelper
    {
        public static int ToIntDef(this char value, int defaultValue = int.MinValue)
        {
            int convert = 0;
            return int.TryParse(value.ToString(), out convert) ? convert : defaultValue;
        }

        public static bool ToBool(this char value)
        {
            return (value == '1') ? true : false;
        }
    }
}
