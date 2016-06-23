using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    public class Dog :Mammal
    {
        public string Breed { get; set; }

        public Dog(int age, string breed) : base(age)
        {
            this.Breed = breed;
        }

        public void WagTail()
        {
            Console.WriteLine("Tail wagging..");
        }
    }
}
