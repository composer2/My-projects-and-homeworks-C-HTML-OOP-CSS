using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndImplementation
{
    public struct Rectangle : IShape, IMovable, IResizable
    {
        private int x, y, width, height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void SetPosition(int x, int y)//from IShape
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()//from IShape
        {
            return width * height;
        }

        public void Move(int deltaX, int deltaY)// From IMovable 
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public void Resize(int weightX, int weightY)//IResizable 
        {
            width = width * weightX;
            height = height * weightY;
        }
        public void ResizeByX(int weightX)//IResizable 
        {
            width = width * weightX;
        }
        public void ResizeByY(int weightY)//IResizable 
        {
            height = height * weightY;
        }
    }
}
