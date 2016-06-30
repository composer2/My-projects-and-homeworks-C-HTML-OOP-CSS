namespace OOP_Principles_Part_2
{
    using System;

    internal abstract class Figure2
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a figure of unknown kind:");
            Console.WriteLine(this.GetType().Name);
        }
    }
}
