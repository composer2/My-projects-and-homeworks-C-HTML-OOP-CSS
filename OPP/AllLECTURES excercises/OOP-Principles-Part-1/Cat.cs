namespace OOP_Principles_Part_1
{
    using System;
    internal class Cat : Mammal
    {
        public Cat(int age) : base(age) { }

        public void SayMay()
        {
            Console.WriteLine("Mauuuu");
        }
    }
}
