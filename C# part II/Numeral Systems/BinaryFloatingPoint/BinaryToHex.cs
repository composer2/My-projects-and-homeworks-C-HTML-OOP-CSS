using System;
namespace BinaryFloatingPoint
{
    class BinaryToHex
    {
        public static string BinToHex(string binaryNumber)
        {
            long decimalNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i] - '0';
                int position = binaryNumber.Length - 1 - i;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }
            string hexNumber = "";

            while (decimalNumber > 0)
            {
                long remain = decimalNumber % 16;
                decimalNumber /= 16;
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
            return hexNumber;
        }
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            Console.WriteLine(BinToHex(binary));
        }
    }
}
