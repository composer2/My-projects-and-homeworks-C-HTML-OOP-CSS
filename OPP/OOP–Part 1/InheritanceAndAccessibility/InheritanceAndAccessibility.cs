using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAccessibility
{
    class InheritanceAndAccessibility
    {
        static void Main(string[] args)
        {
            Dog bars = new Dog("Bars", 3, "Akita");
            bars.Sleep();
            Console.WriteLine("Breed "+bars.Breed);
            bars.WagTail();
            //bars.Talk(); // This will not compile - Talk() is private
            //bars.Walk(); // This will not compile - Walk() is protected
            //Console.WriteLine("Name: " + bars.Name); // Name is protected property
        }
    }
}
