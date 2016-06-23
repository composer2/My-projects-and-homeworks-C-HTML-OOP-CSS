using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    internal class Point
    {
        private int x;
        private int y;
        private string name;

        public Point() : this(0, 0) { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = String.Format("Point [{0}x{1}]", this.x, this.y);
        }
        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        public double CalcDistance(Point p)
        {
            return Math.Sqrt((p.x - this.x) * (p.x + this.x) + (p.y - this.y) * (p.y - p.y));
        }
    }
}
