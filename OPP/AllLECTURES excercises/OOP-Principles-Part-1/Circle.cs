namespace OOP_Principles_Part_1
{
    using System;

    internal class Circle : IShapecs, IMovable
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()
        {
            return Math.PI * radius * radius;
        }

        public void Move(int deltaX, int deltaY)
        {
            this.x = deltaX;
            this.y = deltaY;
        }

    }
}
