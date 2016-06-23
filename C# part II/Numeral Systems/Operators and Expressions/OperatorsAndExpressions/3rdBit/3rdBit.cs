using System;
using System.Numerics;

namespace _3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int p1 = 3;
            BigInteger mask1 = 1 << p1;
            BigInteger nAndmask1 = n1 & mask1;
            BigInteger bit1 = nAndmask1 >> p1;
            Console.WriteLine(bit1);
        }
    }
}
