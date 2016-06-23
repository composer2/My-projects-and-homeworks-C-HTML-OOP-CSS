using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Diagrams
{
    class FilledSquare : Square
    {
        private Color Color { get; set; }

        public FilledSquare(float size, int x, int y, Color color)
            : base(size, x, y)
        {
            this.Color = color;
        }
    }
}
