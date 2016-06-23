using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLandNumbers
{
    class StrangeLandNumbers
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Replace("f","0")
                .Replace("bIN", "1")
                .Replace("oBJEC", "2")
                .Replace("mNTRAVL", "3")
                .Replace("lPVKNQ", "4")
                .Replace("pNWE", "5")
                .Replace("hT", "6");
            BigInteger numberInDec = 0;
            for (int i = 0; i < text.Length; i++)
            {
                numberInDec *= 7;
                numberInDec += text[i]-'0';
            }
            Console.WriteLine(numberInDec);
        }
    }
}
