namespace OOP_Principles_Part_1
{
    using System;

    internal class FilledRectangle : Rectangle
    {
        public FilledRectangle(float width, float height, int x, int y, Color color)
        : base(width, height, x, y)
        {
            this.Color = color;
        }
    }
}
