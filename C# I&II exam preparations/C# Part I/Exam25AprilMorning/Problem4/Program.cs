using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long digitsCount = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i>=1&&i<=9)
                {
                    digitsCount++;
                }
                else if (i >= 10 && i <= 99)
                {
                    digitsCount+=2;
                }
                else if (i >= 100 && i <= 999)
                {
                    digitsCount+=3;
                }
                else if (i >= 1000 && i <= 9999)
                {
                    digitsCount+=4;
                }
                else if (i >= 10000 && i <= 99999)
                {
                    digitsCount+=5;
                }
                else if (i >= 100000 && i <= 999999)
                {
                    digitsCount+=6;
                }
            }
            Console.WriteLine(digitsCount);
        }
    }
}
