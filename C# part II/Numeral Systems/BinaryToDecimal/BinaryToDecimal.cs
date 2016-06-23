using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static long BinaryToDec2(string binaryNumber)
        {
            long decimalNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i]-'0';
                int position = binaryNumber.Length - 1 - i;
                decimalNumber += digit*(long)Math.Pow(2,position);
            }
            return decimalNumber;
        }
        public static long BinaryToDec(string binary)
        {
            byte[] binNum = new byte[binary.Length];
            for (int i = 0; i < binary.Length; i++)
            {
                binNum[i] = byte.Parse(Convert.ToString(binary[i]));
            }
            Array.Reverse(binNum);

            long decimalNum = 0;
            long multiply = 1;
            foreach (var digit in binNum)
            {
                decimalNum += (digit * multiply);
                multiply *= 2;
            }
            return decimalNum;
        }
        static void Main(string[] args)
        {
            string bit = Console.ReadLine();
            Console.WriteLine(BinaryToDec2(bit));
        }
    }
}
