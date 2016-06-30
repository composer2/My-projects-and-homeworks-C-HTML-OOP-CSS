namespace OOP_Principles_Part_2
{
    using System;

    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public override double CalcSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
