using System;
using System.Numerics;

namespace BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (q < p)
            {
                var oldp = p;
                p = q;
                q = oldp;
            }
            int p1 = p + k;
            int q1 = q + k;
            BigInteger mask1 = 0;

            while (p < p1 && q1 > q)
            {
                ulong mask = (n & (1ul << p)) << (q - p) | (n & (1ul << q)) >> (q - p);
                ulong mask0 = n & (1ul << p) | n & (1ul << q);
                p++;
                q++;
                mask1 += mask;
                n -= mask0;
            }
            BigInteger result = n | mask1;
            Console.WriteLine(result);
            //Близо седмица за да направя този спагети код. Нечетим е но работи. Ако го разгърна маските става много редове а така изглежда доста готино.
        }
    }
}
