using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarytoDecimal
{
    class BinarytoDecimal
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
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
            Console.WriteLine(decimalNum);
        }
    }
}
