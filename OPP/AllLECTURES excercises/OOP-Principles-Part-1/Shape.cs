namespace OOP_Principles_Part_1
{
    using System;

    internal abstract class Shape
    {
        protected Point Position { get; set; }

        public Shape(Point position)
        {
            this.Position = position;
        }
    }
}
