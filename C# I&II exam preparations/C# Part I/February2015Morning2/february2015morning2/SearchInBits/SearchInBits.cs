using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInBits
{
    class SearchInBits
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine().PadLeft(4, '0'));
            int n = int.Parse(Console.ReadLine());
            int occurrencies = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                for (int pos = 0; pos <= 26; pos++)
                {
                    bool IsEqual = true;
                    for (int j = 0; j <= 3; j++)
                    {
                        var posInNum = pos + j;
                        var posInS = j;
                        int bitInNum = (numbers & (1 << posInNum)) >> posInNum;
                        int bitInS = (s & (1 << posInS)) >> posInS;
                        if (bitInNum != bitInS)
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
