using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            //C = (2N)! / ((N + 1)! * N!)
            int N = int.Parse(Console.ReadLine());
            BigInteger fact2N = 1;
            BigInteger factNplus1 = 1;
            BigInteger factN = 1;
            for (int i = 1; i <= N*2; i++)
            {
                fact2N *= i;
            }
            for (int i = 1; i <= N+1; i++)
            {
                factNplus1 *= i;
            }
            for (int i = 1; i <= N; i++)
            {
                factN *= i;
            }
            BigInteger result = fact2N / (factNplus1 * factN);
            Console.WriteLine(result);
        }
    }
}
