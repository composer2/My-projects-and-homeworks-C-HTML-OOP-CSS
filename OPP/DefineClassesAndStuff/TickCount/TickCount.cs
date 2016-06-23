using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickCount
{
    class SystemTest
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }
            int endTime = Environment.TickCount;
            Console.WriteLine("Time elapsed is {0} sec.",(endTime-startTime)/1000.0);
        }
    }
}
