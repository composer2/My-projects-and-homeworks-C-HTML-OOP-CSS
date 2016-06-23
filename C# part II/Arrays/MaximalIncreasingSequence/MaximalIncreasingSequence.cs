using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new List<int>();
            int countOccur = 1;
            int bestCount = 0;
            for (int i = 0; i < n; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));

            }
            for (int j = 0; j < arr.Count; j++)
            {
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        countOccur++;
                        arr.Remove(arr[i + 1]);
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
            }
            if (countOccur > bestCount)
            {
                bestCount = countOccur;
            }
            Console.WriteLine(bestCount);
        }
    }
}
