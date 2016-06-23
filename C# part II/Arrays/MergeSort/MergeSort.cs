using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            int[] temp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }
            MergeSortAlgo(arr, temp,0, arr.Length - 1);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
        static void MergeSortAlgo(int[] array, int[] tmp, int start, int end)
        {
            // Array with 1 element
            if (start >= end) return;

            // Define a middle of the array
            int middle = start + (end - start) / 2;

            MergeSortAlgo(array, tmp, start, middle);
            MergeSortAlgo(array, tmp, middle + 1, end);

            CompareAndSort(array, tmp, start, middle, end);
        }

        static void CompareAndSort(int[] array, int[] tmp, int start, int middle, int end)
        {
            int left_tmp = start, left_arr = start, middle_arr = middle + 1;

            while (left_arr <= middle && middle_arr <= end)
            {
                if (array[left_arr] > array[middle_arr])
                {
                    tmp[left_tmp++] = array[middle_arr++];
                }
                else
                {
                    tmp[left_tmp++] = array[left_arr++];
                }
            }

            while (left_arr <= middle)
                tmp[left_tmp++] = array[left_arr++];

            while (middle_arr <= end)
                tmp[left_tmp++] = array[middle_arr++];

            for (int i = start; i <= end; i++)
                array[i] = tmp[i];
        }
    }
}

