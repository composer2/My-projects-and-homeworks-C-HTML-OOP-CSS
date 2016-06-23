using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var result = 0.0;
            for (int i = 0; i < N; i++)
            {
                var a = double.Parse(Console.ReadLine());
                result += a;
            }
            Console.WriteLine(result);
        }
    }
}
