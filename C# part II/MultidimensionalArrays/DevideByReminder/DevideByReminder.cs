using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideByReminder
{
    class DevideByReminder
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            int[] sizes = new int[n];

            foreach (var number in numbers)
            {
                int remainder = number % n;
                sizes[remainder]++;
            }
            int[] offsets = new int[n];
            int[][] numbersByRemainder = new int[n][];
            for (int i = 0; i < n; i++)
            {
                numbersByRemainder[i] = new int[sizes[i]];
            }
            foreach (var number in numbers)
            {
                int remainder = number % n;
                int index = offsets[remainder];
                numbersByRemainder[remainder][index] = number;
                offsets[remainder]++;
            }
            for (int row = 0; row < numbersByRemainder.GetLength(0); row++)
            {
                foreach (var num in numbersByRemainder[row])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
