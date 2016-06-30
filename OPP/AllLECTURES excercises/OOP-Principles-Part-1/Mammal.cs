
namespace OOP_Principles_Part_1
{
    using System;
    internal class Mammal
    {
        public int Age { get; set; }

        public Mammal(int age)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shh I'm sleeping!");
        }
    }
}
