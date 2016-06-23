using System;
using System.Linq;
using System.Numerics;

namespace TwoGirlsOnePath
{
    class TwoGirlsOnePath
    {
        static void Main()
        {
            BigInteger [] numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            int mollyIndex = 0;
            int dollyIndex = numbers.Length - 1;

            BigInteger mollyFlowers = 0;
            BigInteger dollyFlowers = 0;

            string winner = "";

            while (true)
            {
                if (numbers[mollyIndex]==0||numbers[dollyIndex]==0)
                {
                    if (numbers[mollyIndex] == 0 && numbers[dollyIndex] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (numbers[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (numbers[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }
                    mollyFlowers += numbers[mollyIndex];
                    dollyFlowers += numbers[dollyIndex];
                    break;
                }
                BigInteger currentMollyFlowers = numbers[mollyIndex];
                BigInteger currentDollyFlowers = numbers[dollyIndex];

                if (mollyIndex==dollyIndex)
                {
                    numbers[mollyIndex] = currentMollyFlowers % 2;
                    mollyFlowers += currentMollyFlowers / 2;
                    dollyFlowers += currentDollyFlowers / 2;
                }
                else
                {
                numbers[mollyIndex] = 0;
                numbers[dollyIndex] = 0;
                mollyFlowers += currentMollyFlowers;
                dollyFlowers += currentDollyFlowers;
                }

                mollyIndex = (int)((mollyIndex+currentMollyFlowers) % numbers.Length);
                dollyIndex = (int)((dollyIndex - currentDollyFlowers) % numbers.Length);
                if (dollyIndex<0)
                {
                    dollyIndex += numbers.Length;
                }
            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}",mollyFlowers, dollyFlowers);
        }
    }
}
