namespace ShapesTest
{
    internal class Square : Shape
    {
        public Square(double sameSides)
            : base(sameSides,sameSides)
        { }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
