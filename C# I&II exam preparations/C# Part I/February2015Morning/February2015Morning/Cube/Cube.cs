using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Cube
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //1st part
            Console.WriteLine(new string(' ', n - 1) + new string(':', n));
            //2nd part
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string(' ', n - 2 - i) + ":" + new string('/', n - 2) + ":" + new string('X', i) + ":");
            }
            //3rd part
            Console.WriteLine(new string(':', n) + new string('X', n - 2) + ":");
            //4th part
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(":" + new string(' ', n - 2) + ":" + new string('X', n - 3 - i)+":");
            }
            //5th part
            Console.WriteLine(new string(':', n));

        }
    }
}
