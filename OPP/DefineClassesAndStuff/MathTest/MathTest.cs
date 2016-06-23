using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTest
{
    class MathTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First side");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Second side");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Angle size");
            int angle = int.Parse(Console.ReadLine());

            double angleInRadians = Math.PI * angle / 180.0;
            Console.WriteLine("Area of triangle: {0}",0.5*a*b*Math.Sin(angleInRadians));
        }
    }
}
