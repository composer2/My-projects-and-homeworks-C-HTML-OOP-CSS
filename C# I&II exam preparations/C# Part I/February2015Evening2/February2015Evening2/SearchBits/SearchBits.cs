using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchBits
{
    class SearchBits
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine().PadLeft(5,'0'));
            int n = int.Parse(Console.ReadLine());
            int occurrencies = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine().PadLeft(29,'0'));
                for (int row = 0; row <= 24; row++)
                {
                    bool IsEqual = true;
                    for (int bit = 0; bit <=4; bit++)
                    {
                        int bitOfNum = row + bit;
                        int bitOfS = bit;
                        int maskOfNum = (numbers & (1 << bitOfNum)) >> bitOfNum;
                        int maskOfS = (s & (1 << bitOfS)) >> bitOfS;

                        if (maskOfNum != maskOfS)
                        {
                            IsEqual = false;
                            break;
                        }
                    }
                    if (IsEqual)
                    {
                        occurrencies++;
                    }
                }
            }
            Console.WriteLine(occurrencies);
        }
    }
}
