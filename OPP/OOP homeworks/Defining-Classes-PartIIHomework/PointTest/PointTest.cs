using AllClassesAndStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTest
{
    class PointTest
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(1.0, 1.0, 1.0);
            double distance = CalculateDistanceBetweenPoints.CalculateDistanceBetwPoints(point, Point3D.O);
            Console.WriteLine("Distance between {0} and {1} : {2}", point, Point3D.O, distance);
            
            Path points = PathStorage.LoadFile("../../files/load.txt");
            foreach (var po in points.Points)
            {
                Console.WriteLine(po);
            }
            PathStorage.SaveFile("../../files/save.txt", points);
        }
    }
}
