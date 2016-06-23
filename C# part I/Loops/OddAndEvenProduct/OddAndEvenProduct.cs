using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            long oddSum = numbers[0];
            long evenSum = numbers[1];
            for (int i = 2; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum *= numbers[i];
                }
                else if (i % 2 == 1)
                {
                    evenSum *= numbers[i];
                }
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("yes {0}",oddSum);
            }
            else
            {
                Console.WriteLine("no {0} {1}",oddSum,evenSum);
            }
        }
    }
}
