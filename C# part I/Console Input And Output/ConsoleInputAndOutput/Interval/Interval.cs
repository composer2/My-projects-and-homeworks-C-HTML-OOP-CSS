using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them such that the reminder of the division by 5 is 0.
            //On the first two lines you will receive two integers - N on the first and M on the second.
            //Output a single value - the amount of numbers divisible by 5 without remainder.
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = N+1; i < M; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
