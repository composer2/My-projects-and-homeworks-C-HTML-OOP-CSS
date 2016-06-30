namespace OOP_Principles_Part_1
{
    using System;
    internal class Creature
    {
        protected string Name { get; private set; }

        public Creature(string name)
        {
            this.Name = name;
        }

        private void Talk()
        {
            Console.WriteLine("hello im creature");
        }

        private void Walk()
        {
            Console.WriteLine("I can walk!!");
        }
    }
}
