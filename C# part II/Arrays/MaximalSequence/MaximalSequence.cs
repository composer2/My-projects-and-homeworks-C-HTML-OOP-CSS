using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            int countOccur = 1;
            int bestCount = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] = numbers;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    countOccur++;
                }
                else
                {
                    if (countOccur > bestCount)
                    {
                        bestCount = countOccur;
                    }
                    countOccur = 1;
                }
            }
            if (countOccur > bestCount)
            {
                bestCount = countOccur;
            }
            Console.WriteLine(bestCount);
        }
    }
}
