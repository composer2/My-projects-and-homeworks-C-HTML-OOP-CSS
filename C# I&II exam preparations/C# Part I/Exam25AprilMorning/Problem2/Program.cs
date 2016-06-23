using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint s = uint.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int bestOccurrencies = 0;
            uint currentNum = 0;
            for (int i = 0; i < n; i++)
            {
                uint numbers = uint.Parse(Console.ReadLine());
                bool NotOverlap = true;
                for (int bit = 0; bit < 32; bit++)
                {
                    int bitOfNum = bit;
                    int bitOfS = bit;
                    uint maskOfNum = (numbers & (1u << bitOfNum)) >> bitOfNum;
                    uint maskOfS = (s & (1u << bitOfS)) >> bitOfS;

                    if (maskOfNum == maskOfS && maskOfNum == 1 && maskOfS == 1)
                    {
                        NotOverlap = false;
                        break;
                    }
                }
                if (NotOverlap)
                {
                    int occurrencies = 0;

                    for (int bit = 0; bit < 32; bit++)
                    {
                        uint maskOfNum = (numbers & (1u << bit)) >> bit;

                        if (maskOfNum == 1)
                        {
                            occurrencies++;
                        }
                        if (occurrencies > bestOccurrencies)
                        {
                            bestOccurrencies = occurrencies;
                            currentNum = numbers;
                        }
                    }
                }
            }
            Console.WriteLine(currentNum);
        }
    }
}
