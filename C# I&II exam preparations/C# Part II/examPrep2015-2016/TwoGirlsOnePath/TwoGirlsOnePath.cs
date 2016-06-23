using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TwoGirlsOnePath
{
    class TwoGirlsOnePath
    {
        static void Main(string[] args)
        {
            var flowers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger MollyFlowers = 0;
            BigInteger DollyFlowers = 0;
            long mollyIndex = 0;
            long dollyIndex = flowers.Length - 1;
            bool mollyLose = false;
            bool dollyLose = false;

            while (true)
            {
                BigInteger mollyCollectedFlowers = flowers[mollyIndex];
                BigInteger dollyCollectedFlowers = flowers[dollyIndex];

                if (mollyLose && dollyLose)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("{0} {1}", MollyFlowers, DollyFlowers);
                    break;
                }
                else if (mollyLose)
                {
                    Console.WriteLine("Dolly");
                    Console.WriteLine("{0} {1}", MollyFlowers, DollyFlowers);
                    break;
                }
                else if (dollyLose)
                {
                    Console.WriteLine("Molly");
                    Console.WriteLine("{0} {1}", MollyFlowers, DollyFlowers);
                    break;
                }

                if (mollyIndex == dollyIndex && flowers[mollyIndex] > 0)
                {
                    var flowersCurrCell = mollyCollectedFlowers;
                    MollyFlowers += mollyCollectedFlowers / 2;
                    DollyFlowers += dollyCollectedFlowers / 2;
                    flowers[mollyIndex] %= 2;
                    flowers[dollyIndex] %= 2;

                    mollyIndex = (mollyIndex + (long)flowersCurrCell) % flowers.Length;

                    dollyIndex = dollyIndex - (long)flowersCurrCell;
                    if (dollyIndex < 0)
                    {
                        dollyIndex = flowers.Length + (dollyIndex % flowers.Length);
                        if (dollyIndex == flowers.Length)
                        {
                            dollyIndex = 0;
                        }
                    }
                }
                else if (mollyIndex != dollyIndex)
                {

                    if (mollyCollectedFlowers > 0)
                    {

                        MollyFlowers += mollyCollectedFlowers;
                        flowers[mollyIndex] = -1;

                        mollyIndex = (mollyIndex + (long)mollyCollectedFlowers) % flowers.Length;
                    }
                    else
                    {
                        mollyLose = true;
                    }
                    if (dollyCollectedFlowers > 0)
                    {
                        DollyFlowers += dollyCollectedFlowers;
                        flowers[dollyIndex] = -1;

                        dollyIndex = dollyIndex - (long)dollyCollectedFlowers;
                        if (dollyIndex < 0)
                        {
                            dollyIndex = flowers.Length + (dollyIndex % flowers.Length);
                            if (dollyIndex == flowers.Length)
                            {
                                dollyIndex = 0;
                            }
                        }
                    }
                    else
                    {
                        dollyLose = true;
                    }
                }
            }
        }
    }
}