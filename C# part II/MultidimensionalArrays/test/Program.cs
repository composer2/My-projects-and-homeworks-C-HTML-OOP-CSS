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
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 3 + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 3 + 1; col++)
                {
                    int sum = 0;
                    for (int Prow = row; Prow < row + 3; Prow++)
                    {
                        for (int Pcol = col; Pcol < col + 3; Pcol++)
                        {
                            sum += matrix[Prow, Pcol];
                        }
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
