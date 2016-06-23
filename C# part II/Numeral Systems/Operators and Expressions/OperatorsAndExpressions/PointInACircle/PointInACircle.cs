using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            double r = 2;
            double diagonal = Math.Sqrt(Math.Abs(Math.Pow(x, 2)) + Math.Abs(Math.Pow(y, 2)));

            if (diagonal <= r)
            {
                Console.WriteLine("yes {0:f2}", diagonal);
            }
            else
            {
                Console.WriteLine("no {0:f2}", diagonal);
            }
        }
    }
}
