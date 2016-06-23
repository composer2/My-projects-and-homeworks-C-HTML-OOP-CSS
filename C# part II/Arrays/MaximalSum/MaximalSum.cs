using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int currentSum = array[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;
            int maxSum = array[0];

            for (int i = 0; i < n; i++)
            {
                array[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                    tempStartIndex = i;
                }
                else
                {
                    currentSum += array[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
