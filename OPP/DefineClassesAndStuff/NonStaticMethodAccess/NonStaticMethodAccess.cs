using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticMethodAccess
{
    public class Dog
    {
        // Static variable
        static int dogCount;
        // Instance variables
        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            Dog.dogCount += 1;
        }
        public void Bark()
        {
            Console.WriteLine("BAUUUU");
        }

        public void PrintInfo()
        {
            // Accessing instance variables – name and age
            Console.Write("Dog's name: {0};  age: {1}; often says: ",this.name,this.age);
            // Calling instance method
            this.Bark();
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Sharo",1);
            myDog.PrintInfo();
        }
    }
}
