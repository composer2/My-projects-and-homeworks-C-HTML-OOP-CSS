using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var areaTrapezoid = (a + b) / 2 * h;
            Console.WriteLine("{0:f7}",areaTrapezoid);
        }
    }
}
