using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int oddPos = 0;
            int numCount = 1;

            BigInteger result1 = 1;
            BigInteger result2 = 1;
            while (numbers != "END")
            {
                BigInteger sum = 1;
                if (oddPos % 2 == 1 && oddPos <= 10)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] != '0')
                        {
                            sum *= numbers[i] - '0';
                        }
                    }
                    if (sum != 0)
                    {
                        result1 *= sum;
                    }
                }
                if (oddPos % 2 == 1 && oddPos >= 10)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] != '0')
                        {
                            sum *= numbers[i] - '0';
                        }
                    }
                    if (sum != 0)
                    {
                        result2 *= sum;
                    }
                }
                oddPos++;
                numCount++;
                numbers = Console.ReadLine();
            }
            if (numCount == 1)
            {

                BigInteger result3 = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != '0')
                    {
                        result3 *= numbers[i] - '0';
                    }
                }
                Console.WriteLine(result3);
            }
            else if (numCount > 1 && oddPos <= 10)
            {
                Console.WriteLine(result1);

            }
            else if (numCount > 1 && oddPos > 10)
            {
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            }            
        }
    }
}
