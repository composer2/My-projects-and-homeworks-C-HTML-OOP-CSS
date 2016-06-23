namespace InheritanceAndAccessibility
{
    using System;
    public class Creature
    {
        public string Name { get; private set; }
        public Creature(string name)
        {
            this.Name = name;
        }
        private void Talk()
        {
            Console.WriteLine("I am a creture!");
        }
        private void Walk()
        {
            Console.WriteLine("walking,walking,walking....");
        }
    }
}
