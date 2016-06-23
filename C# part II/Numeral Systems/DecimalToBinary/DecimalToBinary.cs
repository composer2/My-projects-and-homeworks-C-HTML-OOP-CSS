using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static string DecToBin(long decimalNumber)
        {
            string binaryNumber = "";
            while (decimalNumber>0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit+binaryNumber;
                decimalNumber /= 2;
            }
            return binaryNumber;
        }
        public static string DecToBinary(long decimalNumber)
        {
            long remainder;
            string result = ""; //or string.Empty
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBinary(number));
        }
    }
}
