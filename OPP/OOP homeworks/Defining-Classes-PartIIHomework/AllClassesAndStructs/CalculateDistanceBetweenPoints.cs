using System;
namespace AllClassesAndStructs
{
    public class CalculateDistanceBetweenPoints
    {
        public static double CalculateDistanceBetwPoints(Point3D first, Point3D second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y) + (first.Z - second.Z) * (first.Z - second.Z));
        }
    }
}
