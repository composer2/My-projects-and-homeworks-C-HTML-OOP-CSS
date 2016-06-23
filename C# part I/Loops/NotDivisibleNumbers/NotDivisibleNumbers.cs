using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
