using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var devider = 2;
            if (num < 0 || num == 1)
            {
                Console.WriteLine("false");
            }
            else
            {

                while (num % devider != 0)
                {
                    devider++;
                }

                if (num == devider)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
