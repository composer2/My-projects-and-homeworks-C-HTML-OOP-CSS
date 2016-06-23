using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            var weight = double.Parse(Console.ReadLine());
            var moonWeight = weight * 0.17;
            Console.WriteLine("{0:f3}",moonWeight);
        }
    }
}
