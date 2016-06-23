using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSortAlgo
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int elementMin = i;
            for (int p = i + 1; p < arr.Length; p++)
            {
                if (arr[p] < arr[elementMin])
                {
                    elementMin = p;
                }
            }
            if (elementMin != i)
            {
                int temp = 0;
                temp = arr[i];
                arr[i] = arr[elementMin];
                arr[elementMin] = temp;
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
