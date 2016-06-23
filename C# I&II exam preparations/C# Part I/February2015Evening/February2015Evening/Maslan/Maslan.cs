using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Maslan
{
    class Maslan
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger transformations = 0;
            while (n > 10 && transformations < 10)
            {
                BigInteger product = 1;
                while (n > 0)
                {
                    n /= 10;
                    int sum = 0;
                    string num = n.ToString();
                    for (int i = 1; i < num.Length; i += 2)
                    {
                        sum += (num[i] - '0');
                    }
                    if (sum != 0)
                    {
                        product *= sum;
                    }
                }
                transformations++;
                n = product;
            }
            if (transformations < 10)
            {
                Console.WriteLine("{0}", transformations);
            }
            Console.WriteLine(n);
        }
    }
}
