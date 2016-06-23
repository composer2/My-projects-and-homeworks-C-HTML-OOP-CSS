using System;
using System.Collections.Generic;
using System.Linq;


namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var matrix = new int[arr[0], arr[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = nums[j];
                }
            }
            int sum = 0;
            int bestSum = int.MinValue;
            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    sum += matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] + matrix[row, col - 1] + matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
