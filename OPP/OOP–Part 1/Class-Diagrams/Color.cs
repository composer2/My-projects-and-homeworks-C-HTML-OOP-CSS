using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Diagrams
{
    struct Color
    {
        public byte RedValue { get; set; } 
        public byte GreenValue { get; set; }
        public byte BlueValue { get; set; }

        public Color(byte red, byte green, byte blue)
        {
            this.RedValue = red;
            this.GreenValue = green;
            this.BlueValue = blue;
        }
    }
}
