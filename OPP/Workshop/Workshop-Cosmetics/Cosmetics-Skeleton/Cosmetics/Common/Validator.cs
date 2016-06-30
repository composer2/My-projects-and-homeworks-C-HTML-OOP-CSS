namespace Cosmetics.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }
        public static void CheckIfLessThanZero(decimal digit, string message = null)
        {
            if (digit < 0)
            {
                throw new ArgumentException(message);
            }
        }
        public static void CheckIfValidGender(object obj, string message = null)
        {
            if ((string)obj != "Men"|| (string)obj != "Women"|| (string)obj != "Unisex")
            {
                throw new ArgumentException(message);
            }
        }
    }
}
