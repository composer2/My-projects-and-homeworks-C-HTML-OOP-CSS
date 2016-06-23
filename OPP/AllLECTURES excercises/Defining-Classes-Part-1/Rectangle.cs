using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    internal class Rectangle
    {
        private float height;
        private float width;

        public Rectangle(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public float Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public float Width
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public float Area
        {
            get
            {
                return height * width;
            }
        }
    }
}
