using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greeting(name);
        }
        static void Greeting(string str)
        {
            Console.WriteLine("Hello, {0}!", str);
        }
    }
}
