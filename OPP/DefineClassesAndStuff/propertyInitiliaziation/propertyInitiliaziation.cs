    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyInitiliaziation
{
    public class Collar
    {
        private int size;
        public Collar()
        {
        }
    }

    public class Dog
    {
        private string name;
        private int age;
        private double lenght;
        private Collar collar;

        public Dog()
        {
            this.name = "Sharo";
            this.age = 3;
            this.lenght = 0.5;
            this.collar = new Collar();
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
        }
    }
}
