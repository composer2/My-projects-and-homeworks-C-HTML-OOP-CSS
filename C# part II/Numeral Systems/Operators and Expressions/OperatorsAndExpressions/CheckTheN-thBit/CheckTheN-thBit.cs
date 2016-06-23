using System;
using System.Numerics;

namespace CheckTheN_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            BigInteger mask1 = 1 << p1;
            BigInteger nAndmask1 = n1 & mask1;
            BigInteger bit1 = nAndmask1 >> p1;
            Console.WriteLine(bit1);
        }
    }
}
