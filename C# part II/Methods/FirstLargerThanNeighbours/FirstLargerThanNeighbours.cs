using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var array = FillArray(numbers);
            Console.WriteLine(ElementIndex(array));
        }
        static int[] FillArray(int n)
        {
            var array = new int[n];
            array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return array;
        }
        static int ElementIndex(int[] arr)
        {
            if (arr.Length == 1)
            {
                return 1;
            }
            if (arr.Length == 2)
            {
                if (arr[0] > arr[1])
                {
                    return 0;
                }
                else if ((arr[0] < arr[1]))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            int index = -1;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] < arr[i + 1] && arr[i + 1] > arr[i + 2])
                {
                    return i+1;
                }
            }
            return index;
        }
    }
}
