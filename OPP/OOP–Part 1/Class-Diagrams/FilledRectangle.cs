using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Diagrams
{
    class FilledRectangle : Rectangle
    {
        private Color Color { get; set; }

        public FilledRectangle(float width, float height, int x, int y, Color color)
            : base(width, height, x, y)
        {
            this.Color = color;
        }
    }
}
