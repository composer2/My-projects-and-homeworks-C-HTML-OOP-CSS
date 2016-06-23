using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;
            for (BigInteger i = K; i <= N; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact/K);
        }
    }
}
