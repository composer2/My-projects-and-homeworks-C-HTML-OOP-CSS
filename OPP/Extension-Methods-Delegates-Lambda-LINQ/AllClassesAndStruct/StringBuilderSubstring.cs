using System;
using System.Text;

namespace AllClassesAndStruct
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            var substring = new StringBuilder();
            //validates the input data
            if (index < 0 || index >= str.Length)
            {
                throw new IndexOutOfRangeException("Index is out if range");
            }
            if (length < 0)
            {
                throw new ArgumentException("Length must be bigger than zero");
            }
            if (index + length >= str.Length)
            {
                throw new ArgumentException("Substring length is out of the bounderies of the string");
            }
            //substring 
            for (int i = 0; i < length; i++)
            {
                substring.Append(str[index + i]);
            }
            return substring;
        }
    }
}
