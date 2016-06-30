using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Implementing_IComparable
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point otherPoint)
        {
            if (this.X != otherPoint.X)
            {
                return (this.X - otherPoint.X);
            }
            if (this.Y != otherPoint.Y)
            {
                return (this.Y - otherPoint.Y);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Point firstPoint = new Point { X = 3, Y = 5 };
            Point secondPoint = new Point { X = 3, Y = 3 };
            Point thirdPoint = new Point { X = 7, Y = 6 };
            //comparing
            Console.WriteLine(firstPoint.CompareTo(secondPoint));
            Console.WriteLine(firstPoint.CompareTo(thirdPoint));
            Console.WriteLine(thirdPoint.CompareTo(secondPoint));

            //sort points
            Point[] points = new Point[]
            {
                firstPoint, secondPoint, thirdPoint, firstPoint, firstPoint,
                secondPoint, thirdPoint, secondPoint, firstPoint, thirdPoint
            };
            Array.Sort(points);
            foreach (var p in points)
            {
                Console.WriteLine("({0} {1})",p.X,p.Y);
            }
        }
    }
}
