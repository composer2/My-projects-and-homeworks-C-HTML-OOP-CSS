using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>(n);
            numbers.Reverse();
            int groups = 1;
            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                numbers.Add(nums);
            }

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    groups++;
                }
                else
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        numbers[i + 1] = numbers[i];
                    }
                    else
                    {
                        groups++;
                    }
                }
            }
            Console.WriteLine(groups);
        }
    }
}
