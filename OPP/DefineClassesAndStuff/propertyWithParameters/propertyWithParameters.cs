using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyWithParameters
{
    public class Dog
    {
        private string name;
        private int age;
        private double lenght;

        public Dog(string dogName, int dogAge, double dogLenght)
        {
            this.name = dogName;
            this.age = dogAge;
            this.lenght = dogLenght;
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Bobi",2,0.4);
            Console.WriteLine("My dog {0} is {1} years old and its lenght is {2} m.",myDog.name,myDog.age,myDog.lenght);
            
        }
    }
}
