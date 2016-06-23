using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsToBits
{
    class BitsToBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            //connecting all numbers in a string
            for (int i = 0; i < n; i++)
            {
                long numbers = long.Parse(Console.ReadLine());
                binary += Convert.ToString(numbers, 2).PadLeft(30, '0');
            }
            //check current sequence of ones and zeros.
            int zeroCount = 1;
            int maxZero = 0;
            int oneCount = 1;
            int maxOne = 0;
            

            for (int i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == binary[i + 1] && binary[i] == '1')
                {

                    oneCount++;
                }
                else
                {
                    if (oneCount >= maxOne)
                    {
                        maxOne = oneCount;

                    }
                    oneCount = 1;
                }

                if (binary[i] == binary[i + 1] && binary[i] == '0')
                {

                    zeroCount++;
                }
                else
                {
                    if (zeroCount >= maxZero)
                    {
                        maxZero = zeroCount;

                    }
                    zeroCount = 1;
                }
            }
            //check for border case and update max sequence of ones and zeros
            if (zeroCount >= maxZero)
            {
                maxZero = zeroCount;

            }
            if (oneCount >= maxOne)
            {
                maxOne = oneCount;
            }
            if (!binary.Contains('0'))
            {
                maxZero--;
            }
            else if (!binary.Contains('1'))
            {
                maxOne--;
            }
            Console.WriteLine(maxZero);
            Console.WriteLine(maxOne);
        }
    }
}
