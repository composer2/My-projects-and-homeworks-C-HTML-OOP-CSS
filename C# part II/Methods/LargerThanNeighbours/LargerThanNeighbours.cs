using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var array = FillArray(numbers);
            Console.WriteLine(Occurrencies(array));
        }
        static int[] FillArray(int n)
        {
            var array = new int[n];
            array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return array;
        }
        static int Occurrencies(int[] arr)
        {
            if (arr.Length == 1)
            {
                return 1;
            }
            if (arr.Length == 2)
            {
                if (arr[0] > arr[1])
                {
                    return 1;
                }
                else if ((arr[0] < arr[1]))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] < arr[i + 1] && arr[i + 1] > arr[i + 2])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
