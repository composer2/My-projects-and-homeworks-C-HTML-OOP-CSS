using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticAccess
{
    class Dog
    {
        int age = 2;

        public int GetAge()
        {
            return this.age;
        }
        public void MakeOlder()
        {
            this.age++;
        }
        public void PrintAge()
        {
            int myAge = this.GetAge();
            Console.WriteLine("My age is: {0}",myAge);
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("The age is {0}",dog.age);
            Console.WriteLine();
            Dog dog2 = new Dog();
            Console.WriteLine("The age is {0}",dog.GetAge());
            Console.WriteLine();
            dog.MakeOlder();
            Console.WriteLine("After a year dog age is {0}",dog.age);
            Console.WriteLine();
            dog.PrintAge();
        }
    }
}
