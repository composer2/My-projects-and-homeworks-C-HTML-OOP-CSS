using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static string DecimalToHexdecimal(long decNumber)
        {
            string hex = "";
            while (decNumber > 0)
            {
                long digit = decNumber % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit-10+'A') + hex;
                }
                decNumber /= 16;
            }
            return hex;
        }
        public static string DecToHex(long decNumber)
        {
            string hexNumber = "";
            if (decNumber == 0)
            {
                hexNumber = "0";
            }
            else
            {
                while (decNumber > 0)
                {
                    long remain = decNumber % 16;
                    decNumber /= 16;
                    switch (remain)
                    {
                        case 10: hexNumber = "A" + hexNumber; break;
                        case 11: hexNumber = "B" + hexNumber; break;
                        case 12: hexNumber = "C" + hexNumber; break;
                        case 13: hexNumber = "D" + hexNumber; break;
                        case 14: hexNumber = "E" + hexNumber; break;
                        case 15: hexNumber = "F" + hexNumber; break;
                        default: hexNumber = remain + hexNumber; break;
                    }
                }
            }
            return hexNumber;   
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHexdecimal(number));
        }
    }
}
