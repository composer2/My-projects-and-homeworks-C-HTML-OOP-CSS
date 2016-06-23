using System;
using System.Numerics;

namespace ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v == 0)
            {
                ulong mask = ~(1ul << p);
                ulong nAndMask = n & mask;
                Console.WriteLine(nAndMask);
            }
            else if (v == 1)
            {
                ulong mask = 1ul << p;
                ulong nAndMask = n | mask;
                Console.WriteLine(nAndMask);
            }
        }
    }
}
