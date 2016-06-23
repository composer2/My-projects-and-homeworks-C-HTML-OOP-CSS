using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BunnyFactory
{
    class BunnyFactory
    {
        static void Main(string[] args)
        {

            var bunnies = new List<BigInteger>();
            while (true)
            {
                string numbers = Console.ReadLine();
                if (numbers == "END")
                {
                    break;
                }
                else
                {
                    bunnies.Add(BigInteger.Parse(numbers));
                }
            }
            int pos = 0;

            while (true)
            {
                BigInteger sum = 0;
                for (int i = 0; i <= pos; i++)
                {
                    sum += bunnies[i];
                    if (sum >= bunnies.Count)
                    {
                        break;
                    }
                }
                if (sum >= bunnies.Count)
                {
                    break;
                }
                BigInteger sumBunnies = 0;
                BigInteger productBunnies = 1;
                var tmpResult = new StringBuilder();
                for (int j = 0; j < sum; j++)
                {
                    sumBunnies += bunnies[j + pos + 1];
                    productBunnies *= bunnies[j + pos + 1];
                }
                tmpResult.Append(sumBunnies + "" + productBunnies);
                for (int i = 0; i < bunnies.Count; i++)
                {
                    if (i > sum + pos)
                    {
                        tmpResult.Append(bunnies[i]);
                    }
                }
                bunnies.Clear();
                for (int i = 0; i < tmpResult.Length; i++)
                {
                    if (tmpResult[i] - '0' > 1)
                    {
                        bunnies.Add(BigInteger.Parse(tmpResult[i].ToString()));
                    }
                }
                pos++;
            }
            Console.WriteLine(string.Join(" ", bunnies));
        }
    }
}