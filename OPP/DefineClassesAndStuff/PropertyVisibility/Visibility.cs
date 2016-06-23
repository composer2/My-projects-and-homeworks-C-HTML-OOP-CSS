using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyVisibility
{
   public class Dog
    {
        private string name = "Sharo";

        public string Name
        {
            get { return this.name; }
        }

        public void Bark()
        {
            Console.WriteLine("BAU - BAU");
        }

        public void doSmtng()
        {
            this.Bark();
        }

        static void Main(string[] args)
        {
            Dog doge = new Dog();
            Console.WriteLine("My dog's name is: {0}",doge.name);
            doge.Bark();
            Console.WriteLine();
            Kid comeHere = new Kid();
            comeHere.CallTheDog(doge);
            comeHere.WagTheDog(doge);
        }
    }
    public class Kid
    {
        public void CallTheDog(Dog dog)
        {
            Console.WriteLine("Come, {0}",dog.Name);
        }
        public void WagTheDog(Dog dog)
        {
            dog.Bark();
        }
    }
}
