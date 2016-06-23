using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Diagrams
{
    abstract class Shape
    {
        protected Point Position { get; set; }

        public Shape (Point position)
        {
            this.Position = position;
        }
    }
}
