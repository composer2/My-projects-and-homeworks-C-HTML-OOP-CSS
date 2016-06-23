using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBySideAndAltitude
{
    class Point
    {
        private double size;
        private double height;

        public Point(double size, double height)
        {
            this.size = size;
            this.height = height;
        }
        public double Size
        {
            get { return size; }
            set { size = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Point myPoints = new Point(size, height);
            double result = (myPoints.size * myPoints.height) / 2;
            Console.WriteLine("{0:f2}",result);
        }
    }
}
