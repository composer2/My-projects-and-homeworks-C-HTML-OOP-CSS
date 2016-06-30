namespace OOP_Principles_Part_1
{
    using System;
    internal class Square2 : Shape, ISufraceCalculatable
    {
        private float Size { get; set; }

        public Square2(float size, int x, int y)
        : base (new Point(x,y))
    {
            this.Size = size;
        }

        public float CalculateSurface()
        {
            return this.Size * this.Size;
        }
    }
}
