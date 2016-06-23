using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EvenDifferences
{
    class EvenDifferences
    {
        static void Main(string[] args)
        {
            BigInteger result = 0;
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int pos = 1;
            while (pos < listOfNumbers.Count)
            {
                BigInteger bigger = 0;
                BigInteger smaller = 0;
                if (listOfNumbers[pos] > listOfNumbers[pos - 1])
                {
                    bigger = listOfNumbers[pos];
                    smaller = listOfNumbers[pos - 1];
                }

                if (listOfNumbers[pos] < listOfNumbers[pos - 1])
                {
                    bigger = listOfNumbers[pos - 1];
                    smaller = listOfNumbers[pos];
                }
                BigInteger diff = bigger - smaller;
                if (diff % 2 == 0)
                {
                    result += diff;
                    pos += 2;
                }
                else
                {
                    pos++;
                }
            }
            Console.WriteLine(result);
        }
    }
}