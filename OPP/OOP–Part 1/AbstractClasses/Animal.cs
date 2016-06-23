using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Animal : IComparable<Animal>
    {
        // Abstract methods --> should be implemented in the child classes
        public abstract string GetName();
        public abstract int Speed { get; }

        //non abstract method
        public override string ToString()
        {
            return "I am " + this.GetName();
        }
        //interface method
        public int CompareTo(Animal other)
        {
            return this.Speed.CompareTo(other.Speed);
        }
    }
}
