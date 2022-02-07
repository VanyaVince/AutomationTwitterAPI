using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    public static class SystemHelper
    {
        public static string GetRandomValue(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringsChar = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringsChar[i] = chars[new Random().Next(chars.Length)];
            }

            return new string(stringsChar);
        }

        public static string GetTimestamp()
        {
            var timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
            return timestamp.ToString();
        }

        public static string EncodeDataString(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return Uri.EscapeDataString(value);
        }
    }
}
