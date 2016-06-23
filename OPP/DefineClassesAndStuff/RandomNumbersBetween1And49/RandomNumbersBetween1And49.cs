using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersBetween1And49
{
    class RandomNumbersBetween1And49
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ",randomNumber);
            }
            Console.WriteLine();
        }
    }
}
