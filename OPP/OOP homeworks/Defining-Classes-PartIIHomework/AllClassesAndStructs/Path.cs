using System;
using System.Collections.Generic;

namespace AllClassesAndStructs
{
    public class Path
    {
        public List<Point3D> Points
        {
            get;
            private set;
        }
        public Path()
        {
            this.Points = new List<Point3D>();
        }
    }
}
