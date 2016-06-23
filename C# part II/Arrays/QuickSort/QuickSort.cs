using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           QuickSortAlg(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            };
        }
        static void QuickSortAlg(int[] arr, int low, int high)
        {
            int originalLeft = low;
            int originalRight = high;
            int pivot = arr[(low + high) / 2];

            while (low < high)
            {
                while (pivot > arr[low])
                {
                    low++;
                }
                while (pivot < arr[high])
                {
                    high--;
                }
                if (low <= high)
                {
                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;

                    low++;
                    high--;
                }
            }
            if (originalLeft < high)
            {
                QuickSortAlg(arr, originalLeft, high);
            }
            if (low < originalRight)
            {
                QuickSortAlg(arr, low, originalRight);
            }
        }
    }
}
