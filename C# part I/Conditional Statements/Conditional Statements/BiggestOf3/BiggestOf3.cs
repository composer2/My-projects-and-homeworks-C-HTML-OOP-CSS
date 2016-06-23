using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var biggestNumber = double.MinValue;
            if (a>biggestNumber)
            {
                biggestNumber = a;
            }
            if (b>biggestNumber)
            {
                biggestNumber = b;
            }
            if (c>biggestNumber)
            {
                biggestNumber =c;
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
