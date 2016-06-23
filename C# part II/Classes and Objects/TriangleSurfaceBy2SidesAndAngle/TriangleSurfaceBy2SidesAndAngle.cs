using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBy2SidesAndAngle
{
    class Point
    {
        private double sideA;
        private double sideB;
        private double angle;

        public Point(double sideA, double sideB, double angle)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.angle = angle;
        }
        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            Point myPoints = new Point(a, b, angle);
            double result = (myPoints.sideA * myPoints.sideB * Math.Sin(myPoints.angle * 0.01745329252)) * 0.5;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
