namespace OOP_Principles_Part_1
{
    using System;
    internal class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(int age, string breed) : base(age)
        {
            this.Breed = breed;
        }

        public void WagTail()
        {
            Console.WriteLine("Tail wagging");
        }
    }
}
