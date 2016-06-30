namespace OOP_Principles_Part_1
{
    using System;
    internal struct Color
    {
        public byte RedValue { get; set; }
        public byte GreenValue { get; set; }
        public byte BlueValue { get; set; }

        public Color(byte redValue, byte greenValue, byte blueValue)
            : this()
        {
            this.RedValue = redValue;
            this.GreenValue = greenValue;
            this.BlueValue = blueValue;
        }
    }
}
