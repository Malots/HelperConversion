using System;
using System.Security.Cryptography;
using System.Text;

namespace HelperConversion
{
    /// <summary>
    /// Static class with useful byte helpers
    /// </summary>
    public static class ByteHelper
    {
        /// <summary>
        /// Generate Random Key in array of byte
        /// </summary>
        /// <param name="value">byte array</param>
        /// <returns>random byte array</returns>
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

        /// <summary>
        /// Combite two array of byte
        /// </summary>
        /// <param name="first">byte array</param>
        /// <param name="second">byte array</param>
        /// <returns>byte array</returns>
        public static byte[] Combine(this byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        /// <summary>
        /// Convert array of byte in string, if conversion is not possible return the default value
        /// </summary>
        /// <param name="value">byte array</param>
        /// <param name="defaultValue">string default</param>
        /// <returns>string or default value</returns>
        public static string ToStringUTF8(this byte[] value, string defaultValue = "")
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
