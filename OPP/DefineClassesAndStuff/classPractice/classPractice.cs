using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classPractice
{
   public class Cat
    {//Field name
        private string name;
        private string color;

        //property
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        //property
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        //constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        //Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        //Method
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuu!",name);
        }
        static void Main()
        {
        Cat firstCat = new Cat();
        firstCat.Name = "Bony";
        firstCat.SayMiau();

        Cat secondCat = new Cat("Pepy", "red");
        secondCat.SayMiau();
        Console.WriteLine("Cat {0} is {1}",secondCat.Name, secondCat.Color);
        }
    }
    
}
