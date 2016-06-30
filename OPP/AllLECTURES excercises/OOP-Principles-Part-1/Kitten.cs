using System;

namespace OOP_Principles_Part_1
{
    internal class Kitten : Cat2
    {
        public override int Speed
        {
            get
            {
                return 7;
            }
        }
        public override string GetName()
        {
            return "Kitten";
        }

        public override void SayMyaau()
        {
            Console.WriteLine("Kitten mayyyy");
        }
    }
}
