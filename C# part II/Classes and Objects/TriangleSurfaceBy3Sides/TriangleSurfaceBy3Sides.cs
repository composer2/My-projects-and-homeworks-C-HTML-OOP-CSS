using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBy3Sides
{
    class Point
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Point(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
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
        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Point myPoints = new Point(a, b, c);
            double S = (myPoints.sideA + myPoints.sideB + myPoints.sideC) / 2;
            double result = Math.Sqrt(S * (S - myPoints.sideA) * (S - myPoints.sideB) * (S - myPoints.sideC));
            Console.WriteLine("{0:f2}", result);
        }
    }
}
