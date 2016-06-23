using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class MultiverseCommunication
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            string input = Console.ReadLine();

            var decimalRepres = 0L;

            for (int i = 0; i < input.Length; i += 3)
            {
                var digitIn13 = input.Substring(i, 3);
                var decimalValue = alphabet.IndexOf(digitIn13);
                decimalRepres *= 13;
                decimalRepres += decimalValue;
            }
            Console.WriteLine(decimalRepres);
        }
    }
}
