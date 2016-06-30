namespace OOP_Principles_Part_1
{
    using System;
    internal class Rectangle2 : Shape, ISufraceCalculatable
    {
        private float Width { get; set; }
        private float Height { get; set; }

        public Rectangle2(float width, float height, int x, int y)
        : base (new Point(x,y))
    {
            this.Width = width;
            this.Height = height;
        }

        public float CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
