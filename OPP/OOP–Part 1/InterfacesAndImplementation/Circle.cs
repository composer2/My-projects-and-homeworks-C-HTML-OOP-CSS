using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndImplementation
{
   public class Circle :IShape,IMovable
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public void SetPosition(int x, int y)//from IShape
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()//from IShape
        {
            return Math.PI * radius * radius;
        }

        public void Move(int deltaX, int deltaY)//from IMovable
        {
            this.x += deltaX;
            this.y += deltaY;
        }

    }
}
