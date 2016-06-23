using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NineGagNumbers
{
    class NineGagNumbers
    {
        static string ConvertGagToNumber(string digit)
        {
            string result = "NO";
            switch (digit)
            {
                case "-!": result = "0"; break;
                case "**": result = "1"; break;
                case "!!!": result = "2"; break;
                case "&&": result = "3"; break;
                case "&-": result = "4"; break;
                case "!-": result = "5"; break;
                case "*!!!": result = "6"; break;
                case "&-!": result = "7"; break;
                case "!!**!-": result = "8"; break;
                default: break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string partialInput = String.Empty;
            string nineSystemBase = "";

            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];
                string currDigit = ConvertGagToNumber(partialInput);
                if (currDigit!="NO")
                {
                    nineSystemBase += currDigit;
                    partialInput = "";
                }
            }

            BigInteger result = 0;

            for (int i = 0; i < nineSystemBase.Length; i++)
            {
                BigInteger digit = BigInteger.Parse(nineSystemBase[i].ToString());
                result += digit * PowerOfNine(nineSystemBase.Length - 1 - i);
            }
            Console.WriteLine(result);
        }
        static BigInteger PowerOfNine(int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 9;
            }
            return result;
        }
    }
}
