using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    class Cat : Mammal
    {
        public Cat(int age) : base(age)
        {
        }
        public void SayMyaau()
        {
            Console.WriteLine("Miayyyyy...");
        }
    }
}
