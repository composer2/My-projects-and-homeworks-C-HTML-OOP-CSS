using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        public static long BaseToDec(string number, long BaseSystem)
        {
            long decNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                long num = 0;

                if (number[i] >= '0' && number[i] <= '9')
                {
                    num = number[i] - '0';
                }
                else if (number[i] >= 'A' && number[i] <= 'F')
                {
                    num = number[i] - 'A' + 10;
                }
                decNumber += num * (long)Math.Pow(BaseSystem, number.Length - 1 - i);
            }
            return decNumber;
        }
        static string DecToBase(long decNumber, long baseSystem)
        {
            string result = "";
            while (decNumber > 0)
            {
                long remain = decNumber % baseSystem;
                if (remain >= 0 && remain <= 9)
                {
                    result = (char)(remain + '0') + result;
                }
                else if (remain >= 10 && remain <= 15)
                {
                    result = (char)(remain - 10 + 'A') + result;
                }
                decNumber /= baseSystem;
            }
            return result;
        }
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            string N = Console.ReadLine();
            long d = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBase(BaseToDec(N, s), d));
        }
    }
}
