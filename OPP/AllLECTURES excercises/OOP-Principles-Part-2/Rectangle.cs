namespace OOP_Principles_Part_2
{
    using System;

    internal class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalcSurface()
        {
            return this.Width * this.Height;
        }
    }
}
