using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Diagrams
{
    class Rectangle : Shape, ISufraceCalculatable
    {
        private float Width { get; set; }
        private float Height { get; set; }

        public Rectangle(float width, float height, int x, int y)
            : base(new Point(x, y))
        {
            this.Width = width;
            this.Height = height;
        }
        public float CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
