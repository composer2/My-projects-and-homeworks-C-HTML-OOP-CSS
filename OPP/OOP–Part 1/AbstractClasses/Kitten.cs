using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Kitten: Cat
    {
        public override int Speed
        {
            get
            {
                return 5;
            }
        }
        public override string GetName()
        {
            return "kitten";
        }
        public override void SayMyauu()
        {
            Console.WriteLine("Kitten miau miau");
        }
    }
}
