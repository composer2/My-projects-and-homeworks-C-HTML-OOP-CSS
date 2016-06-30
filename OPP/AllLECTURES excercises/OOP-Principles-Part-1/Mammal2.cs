namespace OOP_Principles_Part_1
{
    using System;
    internal class Mammal2 : Creature
    {
        public int Age { get; set; }

        public Mammal2 (string name, int age) : base(name)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shh {0}  is sleeping.",this.Name);
        }
    }
}
