using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            int countOccur = 1;
            int bestCount = 0;
            int number = 0;
            int bestNumber = 0;
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Sort();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    countOccur++;
                    number = list[i];
                }
                else
                {
                    if (countOccur > bestCount)
                    {
                        bestCount = countOccur;
                        bestNumber = number;
                    }
                    countOccur = 1;
                    number = 0;
                }
            }
            if (countOccur > bestCount)
            {
                bestCount = countOccur;
                bestNumber = number;
            }
            Console.WriteLine("{0} ({1} times)",bestNumber, bestCount);
        }
    }
}
