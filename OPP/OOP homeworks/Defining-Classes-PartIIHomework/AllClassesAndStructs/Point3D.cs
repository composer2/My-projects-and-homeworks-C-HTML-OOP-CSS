using System;
namespace AllClassesAndStructs
{
    public struct Point3D
    {
        public double X;
        public double Y;
        public double Z;

        private static Point3D zeroPoint = new Point3D(0.0, 0.0, 0.0);

        public static Point3D O
        {
            get
            {
                return zeroPoint;
            }
        }
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
