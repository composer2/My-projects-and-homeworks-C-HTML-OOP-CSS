using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MultiverseComunication
{
    class MultiverseComunication
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            string input = Console.ReadLine();

            BigInteger result = 0;

            for (int i = 0; i < input.Length; i += 3)
            {
                var digitIn13th = input.Substring(i, 3);
                var indexOfDigitIn13th = alphabet.IndexOf(digitIn13th);
                result *= 13;
                result += indexOfDigitIn13th;
            }
            Console.WriteLine(result);
        }
    }
}
