using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var temp = 0.0;

            if (a > b)
            {
            temp = b;
            b = a;
            a = temp;
            }
                Console.WriteLine("{0} {1}", a, b);
        }
    }
}
