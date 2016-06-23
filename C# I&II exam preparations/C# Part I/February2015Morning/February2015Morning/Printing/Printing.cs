using System;

namespace Printing
{
    class Printing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double result = n * s / 500d * p;
            Console.WriteLine("{0:f2}",result);
        }
    }
}
