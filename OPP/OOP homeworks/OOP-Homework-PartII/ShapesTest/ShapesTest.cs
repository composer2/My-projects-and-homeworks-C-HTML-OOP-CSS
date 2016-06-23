using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTest
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            var square = new Square(7.7);
            PrintShapes(square);
            Console.WriteLine("Area is {0:f2}",square.CalculateSurface());
            Console.WriteLine(new string('*',40));

            var triangle = new Triangle(5.6,7.8);
            PrintShapes(triangle);
            Console.WriteLine("Area is {0:f2}", triangle.CalculateSurface());
            Console.WriteLine(new string('*', 40));


            var rectangle = new Rectangle(12,11.9);
            PrintShapes(rectangle);
            Console.WriteLine("Area is {0:f2}", rectangle.CalculateSurface());
            Console.WriteLine(new string('*', 40));

        }
        internal static void PrintShapes(Shape shape)
        {
            if (shape is Square)
            {
                Console.WriteLine("Square with sides {0}", shape.Height);
            }
            else
            {
                Console.WriteLine("{0} with width {1} and height {2}", shape.GetType().Name, shape.Width, shape.Height);
            }
        }
    }
}
