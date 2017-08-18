using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace HelperConversion
{
    public static class StringHelper
    {
        public static int ToIntDef(this string value, int defaultValue = int.MinValue)
        {
            int convert = 0;
            return int.TryParse(value.Trim(), out convert) ? convert : defaultValue;
        }

        public static bool ToBoolDef(this string value, bool defaultValue = false)
        {
            bool convert = false;
            return bool.TryParse(value.Trim().ToLower(), out convert) ? convert : defaultValue;
        }

        public static float ToFloatDef(this string value, float defaultValue = float.MinValue)
        {
            float convert = 0;
            return float.TryParse(value.Trim(), out convert) ? convert : defaultValue;
        }

        public static IPAddress ToIpDef(this string value, IPAddress defaultValue = null)
        {
            IPAddress convert = null;
            return IPAddress.TryParse(value.Trim(), out convert) ? convert : defaultValue;
        }

        public static byte[] ToByteUTF8Def(this string value, byte[] defaultValue = null)
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

        public static string GetOnlyNumbers(this string value)
        {
            return string.IsNullOrEmpty(value) ? "" : new String(value.Where(Char.IsDigit).ToArray());
        }

        public static string HashSha256(this string toBeHashed, byte[] key)
        {
            if ((toBeHashed == null) || (toBeHashed == "") || (key == null)) return "";
            byte[] passwordBytes = toBeHashed.ToByteUTF8Def();
            if (passwordBytes == null) return "";
            using (var sha256 = SHA256.Create())
            {
                var combinedHash = passwordBytes.Combine(key);
                return sha256.ComputeHash(combinedHash).ToStringUTF8Def();
            }
        }
    }
}
