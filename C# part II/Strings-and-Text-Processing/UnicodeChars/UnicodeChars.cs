using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeChars
{
    class UnicodeChars
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var hex=Convert.ToString(text[i],16);
                result.Append("\\u" + hex.ToUpper().PadLeft(4, '0'));
            }
            Console.WriteLine(result.ToString());
        }
    }
}
