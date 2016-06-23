using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            var result2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            if (Double.IsNaN(result) && (double.IsNaN(result2)))
            {
                Console.WriteLine("no real roots");
            }
            else if (result2 != result)
            {
                Console.WriteLine("{0:f2}\n{1:f2}", Math.Min(result, result2), Math.Max(result2, result));
            }
            else if (result == result2)
            {
                Console.WriteLine("{0:f2}",result2);
            }
        }
    }
}
