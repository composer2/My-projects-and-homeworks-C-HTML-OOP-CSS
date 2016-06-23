using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifferences
{
    class IncreasingAbsoluteDifferences
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var seq = Console.ReadLine().Split().Select(long.Parse).ToArray();

                bool IsIncreasing = true;

                for (int j = 2; j < seq.Length; j++)
                {
                    var lastAbsDiff = Math.Abs(seq[j - 2] - seq[j - 1]);
                    var currAbsDiff = Math.Abs(seq[j - 1] - seq[j]);

                    if (lastAbsDiff > currAbsDiff || currAbsDiff - lastAbsDiff > 1)
                    {
                        IsIncreasing = false;
                        break;
                    }
                }
                Console.WriteLine(IsIncreasing);
            }

        }
    }
}
