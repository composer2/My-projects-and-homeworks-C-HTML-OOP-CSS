using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProperties
{
    class Rectangle
    {
        private float width;
        private float height;

        public Rectangle(float width, float height)
        {
            this.height = height;
            this.width = width;
        }

        public float Height
        {
            get { return height; }
            set { this.height = value; }
        }

        public float Width
        {
            get { return width; }
            set { this.width = value; }
        }

        //property
        public double Area
        {
            get
            {
                return width * height;
            }
        }

        static void Main(string[] args)
        {
            Rectangle first = new Rectangle(5.0f, 3.0f);
            Console.WriteLine("Rectangle 1 is {0}x{1} and has area of {2}",first.height,first.width,first.Area);
            Console.WriteLine();

            Rectangle second = new Rectangle(4.0f, 2.0f);
            Console.WriteLine("Rectangle 2 is {0}x{1} and has area of {2}", first.height, first.width, first.Area);


        }
    }
}
