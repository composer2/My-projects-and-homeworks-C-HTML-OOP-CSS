using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticFields
{
    class Dog
    {
        // Static (class) variable
        static int dogCount=0;
        // Instance variables
        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            // Modifying the static counter in the constructor
            Dog.dogCount += 1;
        }
        static void Main(string[] args)
        {
            // Аccess to the static variable through class name
            Console.WriteLine("Dog count is now " + Dog.dogCount);
            Console.WriteLine();
            Dog dog1 = new Dog("Karaman", 1);
            Dog dog2 = new Dog("Bobi", 2);
            Dog dog3 = new Dog("Sharo", 3);
            // Access to the static variable
            Console.WriteLine("Dog count is now " + Dog.dogCount);
        }
    }
}
