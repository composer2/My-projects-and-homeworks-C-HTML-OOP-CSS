using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    class SimpleInheritance
    {
        static void Main(string[] args)
        {
            Dog bars = new Dog(3, "Akita");
            bars.Sleep();
            bars.WagTail();
            Console.WriteLine("Bars is {0} years old dog if breed {1}",bars.Age,bars.Breed);

            Console.WriteLine();

            Cat mark = new Cat(4);
            mark.Sleep();
            mark.SayMyaau();
            Console.WriteLine("Mark is {0} years old cat.",mark.Age);
        }
    }
}
