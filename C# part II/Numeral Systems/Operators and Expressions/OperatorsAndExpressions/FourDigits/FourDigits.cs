using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            var ABCD = int.Parse(Console.ReadLine());

            var D = ABCD % 10;
            var C = (ABCD / 10) % 10;
            var B = (ABCD / 100) % 10;
            var A = (ABCD / 1000) % 10;
            var sum = A + B + C + D;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}",D,C,B,A);
            Console.WriteLine("{0}{1}{2}{3}",D,A,B,C);
            Console.WriteLine("{0}{1}{2}{3}",A,C,B,D);
        }
    }
}
