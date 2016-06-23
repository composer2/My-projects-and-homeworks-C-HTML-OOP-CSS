using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassDog
{
    public class Dog
    {
        private string name;
        private string breed;

        public Dog()
        {
        }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public void SayBay()
        {
            Console.WriteLine("{0} said: Bauuuuuu!",
         this.name ?? "[unnamed dog]");//ako dog e bez ime vtoroto se printira
        }
        static void Main(string[] args)
        {
            var firstDog = new Dog("Vulkan", "Koferman");
            var secondDog = new Dog("Bars", "Akita");
            var thirdDog = new Dog();

            Dog[] dogsArr = new Dog[]
            {
                firstDog,
                secondDog,
                thirdDog
            };

            foreach (var doge in dogsArr)
            {
                doge.SayBay();
            }
        }
    }
}