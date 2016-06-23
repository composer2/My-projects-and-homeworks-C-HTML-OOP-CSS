using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesOfBits
{
    class SequencesOfBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countZeros = 1;
            int bestZeroCount = 0;
            int countOnes = 1;
            int bestOnesCount = 0;

            string binary = string.Empty;
            for (int i = 0; i < n; i++)
            {
                long numbers = long.Parse(Console.ReadLine());
                binary += Convert.ToString(numbers, 2).PadLeft(30, '0');
            }

            for (int i = 0; i < binary.Length-1; i++)
            {
                if (binary[i]==binary[i+1]&&binary[i]=='1')
                {
                    countOnes++;
                }
                else
                {
                    if (countOnes>=bestOnesCount)
                    {
                        bestOnesCount = countOnes;
                    }
                    countOnes = 1;
                }
                if (binary[i] == binary[i + 1] && binary[i] == '0')
                {
                    countZeros++;
                }
                else
                {
                    if (countZeros >= bestZeroCount)
                    {
                        bestZeroCount = countZeros;
                    }
                    countZeros = 1;
                }
            }
            if (countZeros>=bestZeroCount)
            {
                bestZeroCount = countZeros;
            }
            if (!binary.Contains('0'))
            {
                bestZeroCount = 0;
            }
            if (countOnes>=bestOnesCount)
            {
                bestOnesCount = countOnes;
            }
            if (!binary.Contains('1'))
            {
                bestOnesCount = 0;
            }
            Console.WriteLine("{0}\n{1}",bestOnesCount,bestZeroCount);
        }
    }
}
