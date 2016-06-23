using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassDefinition
{
    public class Cat
    {
        private string name;
        private string owner;

        public Cat(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public void SayMiau()
        {
            Console.WriteLine("Mayyyy!");
        }
        static void Main(string[] args)
        {
        }
    }
}
