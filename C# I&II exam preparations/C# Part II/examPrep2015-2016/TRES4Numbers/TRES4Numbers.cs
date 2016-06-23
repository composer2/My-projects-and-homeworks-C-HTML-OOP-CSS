using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TRES4Numbers
{
    class TRES4Numbers
    {
        static void Main(string[] args)
        {
            BigInteger numberInDec = BigInteger.Parse(Console.ReadLine());
            if (numberInDec == 0)
            {
                Console.WriteLine("LON+");
                return;
            }
            string NumberIn8thBase = "";
            while (numberInDec > 0)
            {
                BigInteger digit = numberInDec % 9;
                NumberIn8thBase = digit + NumberIn8thBase;
                numberInDec /= 9;
            }
            var result = new StringBuilder();
            var listOfTRES4Numbers = new List<string>
            { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            foreach (var ch in NumberIn8thBase)
            {
                result.Append(listOfTRES4Numbers[ch - '0']);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
