using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAccessibility
{
    public class Mammal : Creature
    {
        public int Age { get; set; }

        public Mammal(string name, int age) : base(name)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shh I am sleeping!!!");
        }
    }
}
