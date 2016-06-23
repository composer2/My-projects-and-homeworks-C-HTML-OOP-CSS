using System;
namespace HexToBinary
{
    class HexToBinary
    {
        public static string HexToBin(string hex)
        {
            long decimalNumber = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                int digit = 0;
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    digit = hex[i] - '0';
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    digit = hex[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)Math.Pow(16, hex.Length - 1 - i);
            }
            string binaryNumber = "";
            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit + binaryNumber;
                decimalNumber /= 2;
            }
            return binaryNumber;
        }
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            Console.WriteLine(HexToBin(hexadecimal));
        }
    }
}
