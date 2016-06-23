using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyCapsulation
{
    class Point
    {
        //private double x;
        //private double y;
        private double[] coordinates;

        //public Point(int x, int y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        public Point(int xCood, int yCood)
        {
            this.coordinates = new double[2];
            coordinates[0] = xCood;
            coordinates[1] = yCood;
        }


        public double X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }
        public double Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }
        static void Main(string[] args)
        {
            Point myPoint = new Point(2,3);

            double myPointXcoordinates = myPoint.X;
            double myPointYcoordinates = myPoint.Y;

            Console.WriteLine("X is: {0}",myPointXcoordinates);
            Console.WriteLine("Y is: {0}",myPointYcoordinates);
        }
    }
}
