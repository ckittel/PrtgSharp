using System;

namespace PrtgSharp.Utilities
{
    internal static class StringExtensions
    {
        public static string Truncate(this string value, int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Length must at least 1");
            }

            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            if (value.Length > length)
            {
                return value.Substring(0, length);
            }

            return value;
        }

        public static string Truncate(this string value, int length, char finalCharacter)
        {
            if (length <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Length must be greater than 1");
            }

            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            if (value.Length > length)
            {
                return value.Substring(0, length - 1) + finalCharacter;
            }

            return value;
        }

        public static string TruncateWithEllipsis(this string value, int length)
        {
            return Truncate(value, length, '…');
        }
    }
}