using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichaniaBoats
{
    class KaspichaniaBoats
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            int upPart = height * 2 / 3;
            int downPart = height / 3;
            //1st part
            for (int i = 0; i < upPart-1; i++)
            {
                Console.Write(new string('.', n - i));
                if (i>0)
                {
                    Console.Write("*");
                }
                if (i>=2)
                {
                    Console.Write(new string('.',i-1));
                }
                Console.Write("*");
                if (i >= 2)
                {
                    Console.Write(new string('.', i - 1));
                }
                if (i > 0)
                {
                    Console.Write("*");
                }
                Console.WriteLine(new string('.', n - i));
            }
            //2nd part
            Console.WriteLine(new string('*',width));
            //3rd
            for (int i = 1; i <= downPart-1; i++)
            {
                Console.WriteLine(new string('.', i) + "*" + new string('.',n-1-i)+"*"+ new string('.', n - 1 - i)+"*"+new string('.',i));
            }
            //4th
            Console.WriteLine(new string('.',n/2+1)+new string('*',n) +new string('.', n / 2 + 1));
        }
    }
}
