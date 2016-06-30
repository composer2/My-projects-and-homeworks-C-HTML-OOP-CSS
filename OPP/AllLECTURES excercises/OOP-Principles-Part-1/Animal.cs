namespace OOP_Principles_Part_1
{
    using System;

    internal abstract class Animal : IComparable<Animal>
    {
        public abstract string GetName();
        public abstract int Speed { get; }

        public override string ToString()
        {
            return "I am " + this.GetName();
        }

        public int CompareTo(Animal other)
        {
            return this.Speed.CompareTo(other.Speed);
        }
    }
}
