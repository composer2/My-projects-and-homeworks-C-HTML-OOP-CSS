using System;
using System.Collections.Generic;
using System.Linq;
namespace ShapesTest
{
    internal abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width must greater than zero");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height must greater than zero");
                }
                this.height = value;
            }
        }
        //child has to impliment method 
        public abstract double CalculateSurface();
    }
}