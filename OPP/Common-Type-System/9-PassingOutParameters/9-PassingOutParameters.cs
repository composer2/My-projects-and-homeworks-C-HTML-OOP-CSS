using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PassingOutParameters
{
    public struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public struct Dimensions
    {
        public int width, height;

        public Dimensions(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
    class Rectangle
    {
        private int x, y, width, height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void GetLocationAndDimensions(out Point location, out Dimensions dimensions)
        {
            location = new Point(x, y);
            dimensions = new Dimensions(width, height);
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10, 12, 8);

            Point location2 = new Point(0, 0);
            Dimensions dimensions2 = new Dimensions(1, 2);
            // Location and dimension are not pre-initialized!
            rect.GetLocationAndDimensions(out location2, out dimensions2);
            Console.WriteLine("{0}, {1}, {2}, {3}",location2.x,location2.y,dimensions2.width,dimensions2.height);
        }
    }
}
