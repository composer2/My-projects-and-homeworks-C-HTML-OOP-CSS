using System;

namespace OOP_Principles_Part_1
{
    internal class Turtle :Animal
    {
        public override int Speed
        {
            get
            {
                return 5;
            }
        }

        public override string GetName()
        {
            return "Turtle";
        }
    }
}
