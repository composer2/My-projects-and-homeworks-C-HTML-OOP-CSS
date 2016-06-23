using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            //N! / (K! * (N - K)!)
            int N = int.Parse(Console.ReadLine());           
            int K = int.Parse(Console.ReadLine());
            BigInteger factN =1;
            BigInteger factK = 1;
            BigInteger factNK = 1; ;
            for (int i = 1; i <= N; i++)
            {
                factN *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                factK *= i;
            }
            for (int i = 1; i <= N-K; i++)
            {
                factNK *= i;
            }
            BigInteger result = factN / (factK * factNK);
            Console.WriteLine(result);
            
        }
    }
}
