using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            var result = 0.0;
            for (int i = 0; i < 5; i++)
            {
                var a = double.Parse(Console.ReadLine());
                 result += a;
            }
            Console.WriteLine(result);
        }
    }
}
