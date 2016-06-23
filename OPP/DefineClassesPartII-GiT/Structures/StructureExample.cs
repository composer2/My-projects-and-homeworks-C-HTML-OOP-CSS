using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Color
    {
        public byte RedValue { get; set; }
        public byte GreenValue { get; set; }
        public byte BlueValue { get; set; }
    }
    public enum Edges
    {
        Straight,
        Rounded
    }
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public struct Square
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public Color SurfaceColor { get; set; }
        public Color BorderColor { get; set; }
        public Edges Edges { get; set; }

        public Square(Point location, int size, Color surfaceColor,
            Color borderColor, Edges edges) : this()
        {
            this.Location = location;
            this.Size = size;
            this.SurfaceColor = surfaceColor;
            this.BorderColor = borderColor;
            this.Edges = edges;
        }

        public override string ToString()
        {
            string squareAsString = string.Format(
                "Rect[location({0},{1}), size({2}), edges({3}), " + "surface(#{4:x2}{5:x2}{6:x2}), border(#{7:x2}{8:x2}{9:x2})]", this.Location.X, this.Location.Y, this.Size, this.Edges, this.SurfaceColor.RedValue, this.SurfaceColor.GreenValue, this.SurfaceColor.BlueValue, this.BorderColor.RedValue, this.BorderColor.GreenValue, this.BorderColor.BlueValue);
            return squareAsString;
        }
    }
    class StructureExample
    {

        static void Main(string[] args)
        {
            Square square = new Square(
                new Point() { X = 5, Y = -3 },
                7,
                new Color() { RedValue = 73, GreenValue = 158, BlueValue = 76 },
                new Color() { RedValue = 0, GreenValue = 255, BlueValue = 133 },
                Edges.Rounded
                );

            Console.WriteLine(square);

            square.Edges = Edges.Straight;
            square.BorderColor = new Color() { RedValue = 0, GreenValue = 0, BlueValue = 0 };

            Point location = square.Location;
            location.X += 10;

            Console.WriteLine(square);
        }
    }
}