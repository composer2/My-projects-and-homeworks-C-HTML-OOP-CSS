using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {
        //Field
        private string name;
        //Constructor
        public Dog()
        {
            this.name = null;
        }
        //Constructor
        public Dog(string name)
        {
            this.name = name;
        }
        //Property
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        //Method
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",name);
        }
        static void Main(string[] args)
        {
            string firstDogName = null;
            Console.WriteLine("Write first dog name: ");
            firstDogName = Console.ReadLine();

            Dog firstDog = new Dog(firstDogName);

            Dog secondDog = new Dog();

            Console.WriteLine("Write second dog name: ");
            string secondDogName = Console.ReadLine();

            secondDog.name = secondDogName;

            Dog thirdDog = new Dog();

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}
