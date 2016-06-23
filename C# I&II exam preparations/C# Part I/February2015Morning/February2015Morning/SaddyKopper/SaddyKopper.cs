using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SaddyKopper
{
    class SaddyKopper
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            int transformations = 0;

            while (transformations < 10 && 9 < n)
            {
            BigInteger oddProduct = 1;
                while (n > 0)
                {
                    n /= 10;
                    string nString = n.ToString();

                    BigInteger oddSum = 0;
                    for (int i = 0; i < nString.Length; i += 2)
                    {
                        oddSum += nString[i] - '0';
                    }
                    if (oddSum != 0)
                    {
                        oddProduct *= oddSum;
                    }
                }
                n = oddProduct;
                transformations++;
            }
            if (transformations < 10)
            {
                Console.WriteLine(transformations);
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}
