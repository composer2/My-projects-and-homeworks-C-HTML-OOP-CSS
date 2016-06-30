﻿namespace OOP_Principles_Part_2
{
    using System;
    internal class Square : Figure
    {
        public double Size { get; set; }

        public override double CalcSurface()
        {
            return this.Size * this.Size;
        }
    }
}
