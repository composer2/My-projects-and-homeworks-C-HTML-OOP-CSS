using System;

namespace PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var x1 = -1;
            var x2 = 5;
            var y1 = -1;
            var y2 = 1;

            double r = 1.5;
            double diagonal = Math.Sqrt(Math.Pow(x - 1, 2) + (Math.Pow(y - 1, 2)));

            if (diagonal <= r)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                Console.Write("inside rectangle");
            }
            else
            {
                Console.Write("outside rectangle");
            }
            Console.WriteLine();
        }
    }
}
