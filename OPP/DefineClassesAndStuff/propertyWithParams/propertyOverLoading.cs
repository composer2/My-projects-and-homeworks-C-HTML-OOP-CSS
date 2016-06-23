using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyOverLoading
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
        private double length;
        private Collar collar;
        //no parameters
        public Dog()
        {
            this.name = "Sharo";
            this.age = 1;
            this.length = 0.3;
            this.collar = new Collar();
        }
        // One param
        public Dog(string name)
        {
            this.name = name;
            this.age = 1;
            this.length = 0.3;
            this.collar = new Collar();
        }
        //two params
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.length = 0.3;
            this.collar = new Collar();
        }
        //three params
        public Dog(string name, int age, double lenght)
        {
            this.name = name;
            this.age = age;
            this.length = lenght;
            this.collar = new Collar();
        }
        public Dog(string name, int age, double length, Collar collar)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.collar = collar;
        }
        static void Main(string[] args)
        {

        }
    }
    public class Dog2
    {
        private string name;
        private int age;
        private double length;
        private Collar collar;
        // Nо parameters
        public Dog2()
        : this("Sharo") // Constructor call
        {
            // More code could be added here
        }
        // One parameter
        public Dog2(string name)
        : this(name, 1) // Constructor call
        {
        }
        // Two parameters
        public Dog2(string name, int age)
        : this(name, age, 0.3) // Constructor call
        {
        }
        // Three parameters
        public Dog2(string name, int age, double length)
        : this(name, age, length, new Collar()) // Constructor call
        {
        }
        // Four parameters
        public Dog2(string name, int age, double length, Collar collar)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.collar = collar;
        }
    }
}
