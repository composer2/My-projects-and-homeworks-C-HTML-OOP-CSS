using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Trailing0inN_
{
    class Trailing0inN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                       
            int zeroCount = 0;
            int d;
            for (int i = 5; i <= n; i += 5)
            {
                d = i;
                while (d % 5 == 0)
                {
                    d /= 5;
                    zeroCount++;
                }
            }
            Console.WriteLine(zeroCount);




            //int zeroCount = 0;
            //BigInteger fact = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fact *= i;
            //}

            //while (fact % 10 == 0)
            //{
            //    zeroCount++;
            //    fact = fact / 10;
            //}
            //Console.WriteLine(zeroCount); 

        }
    }
}
