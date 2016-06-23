using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABandC
{
    class ABandC
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sumAvg = (a + b + c) / 3.0;
            int smallest = int.MaxValue;
            int biggerst = int.MinValue;
            if (a>biggerst)
            {
                biggerst = a;
            }
             if(b>biggerst)
            {
                biggerst = b;
            }
             if (c>biggerst)
            {
                biggerst = c;
            }

            if (a<smallest)
            {
                smallest = a;
            }
             if (b<smallest)
            {
                smallest = b;
            }
             if (c<smallest)
            {
                smallest = c;
            }
            Console.WriteLine(biggerst);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:f3}",sumAvg);
        }
    }
}
