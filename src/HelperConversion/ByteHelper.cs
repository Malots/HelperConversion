using System;
using System.Security.Cryptography;
using System.Text;

namespace HelperConversion
{
    public static class ByteHelper
    {
        public static byte[] GenerateKey(this byte[] value)
        {
            int saltLength = byte.MaxValue;
            using (var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public static byte[] Combine(this byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public static string ToStringUTF8Def(this byte[] value, string defaultValue = "")
        {
            string convert = "";
            try
            {
                convert = Encoding.UTF8.GetString(value);
            }
            catch
            {
                convert = defaultValue;
            }
            return convert;
        }
    }
}
