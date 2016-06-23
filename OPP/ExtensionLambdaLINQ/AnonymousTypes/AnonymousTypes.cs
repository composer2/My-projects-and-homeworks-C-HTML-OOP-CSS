using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class AnonymousTypes
    {
        static void Main(string[] args)
        {
            var myCar = new { Color = "Red", Brand = "BMW", Speed = "300" };
            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Brand);
            Console.WriteLine("It runs with {0}km/h", myCar.Speed);
            Console.WriteLine();

            var p = new { X = 3, Y = 5 };
            var q = new { X = 3, Y = 5 };
            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(p == q);
            Console.WriteLine(q.Equals(p));

            Console.WriteLine();

            var arr = new[]
                            {
                                 new { X = 3, Y = 1 },
                                 new { X = 4, Y = 2 },
                                 new { X = 5, Y = 3 }
                            };
            foreach (var item in arr)
            {
                Console.WriteLine("{0} , {1}",item.X,item.Y);
            }
        }
    }
}
