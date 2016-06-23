using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;
            var perimeter = (width + height) * 2;
            Console.WriteLine("{0:f2} {1:f2}",area,perimeter);
        }
    }
}
