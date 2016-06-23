using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "integer")
            {
                var value = int.Parse(Console.ReadLine());
                Console.WriteLine(value + 1);
            }
            else if (type == "real")
            {
                var value = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", value + 1.0);
            }
            else if (type == "text")
            {
                var value = Console.ReadLine();
                Console.WriteLine(value + "*");
            }
        }
    }
}
