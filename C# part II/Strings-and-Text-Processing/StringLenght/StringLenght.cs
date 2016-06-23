using System;

namespace StringLenght
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(text.PadRight(20,'*'));
        }
    }
}
