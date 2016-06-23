using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TRES4Numbers
{
    class TRES4Numbers
    {
        static void Main(string[] args)
        {
            var digits=new []{ "LON+","VK-","*ACAD","^MIM","ERIK|","SEY&","EMY>>","/TEL","<<DON"};
            var numeralSys = 9;
            BigInteger NumberInDec = BigInteger.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            if (NumberInDec == 0)
            {
                Console.WriteLine(digits[0]);
            }
            while (NumberInDec>0)
            {
                int digitIn9th = (int)(NumberInDec % numeralSys);
                result.Insert(0,digits[digitIn9th]);
                NumberInDec /= numeralSys;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
