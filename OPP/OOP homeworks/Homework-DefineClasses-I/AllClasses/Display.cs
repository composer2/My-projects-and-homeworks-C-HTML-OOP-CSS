using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClasses
{
    public class Display
    {
        //fields
        private int displayHeigth;
        private int displayWidth;
        private int? displayColors;

        //Constructors
        public Display(int displayHeigth, int displayWidth)
        {
            this.displayHeigth = displayHeigth;
            this.displayWidth = displayWidth;
            this.displayColors = null;
        }
        //parameters from first cinstructor
        public Display(int height, int width, int displayColors)
          : this(height, width)
        {
            this.displayColors = displayColors;
        }
        //properties
        public int DisplayHeigth
        {
            get { return this.displayHeigth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Field needs to be bigger then zero.");
                }
                displayHeigth = value;
            }
        }

        public int DisplayWidth
        {
            get { return this.displayWidth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Field needs to be bigger then zero.");
                }
                displayWidth = value;
            }
        }

        public int? DisplayColors
        {
            get { return this.displayColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Field needs to be bigger then zero.");
                }
                displayColors = value;
            }
        }
    }
}
