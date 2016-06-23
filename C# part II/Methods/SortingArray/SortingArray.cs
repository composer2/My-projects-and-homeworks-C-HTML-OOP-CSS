using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Sorted = new int[arr.Length];
            Sorted = SortArr(arr);
            Console.WriteLine(string.Join(" ", Sorted));
        }

        private static int[] SortArr(int[] arr)
        {
            var sorted = arr;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int temp = arr[i];
                    arr[i] = ChangeValuesMin(arr[i], arr[j]);
                    arr[j] = ChangeValuesMax(temp, arr[j]);
                }
            }
            return sorted;
        }

        private static int ChangeValuesMax(int v1, int v2)
        {
            int max = int.MinValue;
            if (v1 > max)
            {
                max = v1;
            }
            if (v2 > max)
            {
                max = v2;
            }
            return max;
        }

        private static int ChangeValuesMin(int v1, int v2)
        {
            int min = int.MaxValue;
            if (v1 < min)
            {
                min = v1;
            }
            if (v2 < min)
            {
                min = v2;
            }
            return min;
        }
    }
}
