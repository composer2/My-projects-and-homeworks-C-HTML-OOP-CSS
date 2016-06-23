using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodeStreet
{
    class NightmareOnCodeStreet
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            long sum = 0;
            long count = 0;
            for (int i = 1; i < text.Length; i += 2)
            {
                if (text[i]>='0'&&text[i]<='9')
                {
                    sum += text[i] - '0';
                    count++;
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
        }
    }
}
