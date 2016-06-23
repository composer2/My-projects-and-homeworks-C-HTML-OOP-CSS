using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());
            int middle = n / 3;
            int upOrDown = n / 2;
            int width = 3 * n;

            //1st part
            for (int i = 0; i < upOrDown; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write(new string((char)s, n - i));
                if (i == upOrDown - 1)
                {
                    Console.Write(new string(' ', (n - 3)/2) + new string(s, 1) + " " + new string(s, 1) + new string(' ', (n - 3)/2));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write(new string((char)s, n - i));
                Console.WriteLine(new string(' ', i));
            }
            //2nd part
            for (int i = 0; i < middle; i++)
            {
                Console.WriteLine(new string(' ',(width-(2*n+1))/2)+new string(s,2*n+1)+ new string(' ', (width - (2 * n + 1)) / 2));
            }
            //3rd part
            for (int i = 0; i < upOrDown; i++)
            {
                Console.WriteLine(new string(' ',(width - n + 2) / 2 + i) +new string(s,n-2-i-i)+ new string(' ', (width - n + 2) / 2+ i));
            }
        }
    }
}
