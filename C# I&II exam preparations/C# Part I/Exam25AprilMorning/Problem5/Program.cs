using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            bool Iszero = b != 0;


            if (Iszero)
            {
                double avr = f / b;
                if (b % 2 == 0)
                {
                    double result = avr * 123123123123;
                    Console.WriteLine("{0:f4}", result);
                }
                else if (b % 2 == 1)
                {
                    double result = avr / 317;
                    Console.WriteLine("{0:f4}", result);
                }
            }
            else
            {
                Console.WriteLine("0.0000");
            }
            

        }
    }
}
