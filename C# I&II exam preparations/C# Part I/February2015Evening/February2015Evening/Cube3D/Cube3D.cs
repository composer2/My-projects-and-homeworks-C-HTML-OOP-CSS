using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube3D
{
    class Cube3D
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //1st part
            Console.WriteLine(new string(':',n));
            //2nd part
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(":"+new string(' ',n-2)+":"+new string('|',i)+":");
            }
            //3rd part
            Console.WriteLine(new string(':', n)+ new string('|', n-2)+":");
            //4th part
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(new string(' ',1+i)+":" + new string('-', n - 2) + ":" + new string('|', n-3-i) + ":");
            }
            //5th part
            Console.WriteLine(new string(' ', n-1) + new string(':', n));
        }
    }
}
