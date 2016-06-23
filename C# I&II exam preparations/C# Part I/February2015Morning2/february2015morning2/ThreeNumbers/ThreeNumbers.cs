using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long biggest = long.MinValue;
            long smallest = long.MaxValue;
            decimal sum = (a + b + c) / 3.0m;
            if (a>biggest)
            {
                biggest = a;
            }
            if(a<smallest)
            {
                smallest = a;
            }

            if (b > biggest)
            {
                biggest = b;
            }
            if (b < smallest)
            {
                smallest = b;
            }

            if (c > biggest)
            {
                biggest = c;
            }
            if (c < smallest)
            {
                smallest = c;
            }
            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:f2}",sum);
        }
    }
}
