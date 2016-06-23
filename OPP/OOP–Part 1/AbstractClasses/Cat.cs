using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Cat :Animal
    {
        public string Breed { get; set; }
        public abstract void SayMyauu();
    }
}
