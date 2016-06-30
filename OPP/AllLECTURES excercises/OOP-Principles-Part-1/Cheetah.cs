namespace OOP_Principles_Part_1
{
    using System;

   internal class Cheetah :Animal
    {
        public override int Speed
        {
            get
            {
                return 100;
            }
        }

        public override string GetName()
        {
            return "Cheetah";
        }
    }
}
