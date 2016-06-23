using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int[] GCD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = GCD[0];
            int b = GCD[1];

            int remain = a % b;
            while (remain != 0)
            {
                a = b;
                b = remain;
                remain = a % b;
            }
            Console.WriteLine(Math.Abs(b));
        }
    }
}
