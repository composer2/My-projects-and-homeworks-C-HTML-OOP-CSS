using System;
using System.Linq;
using System.Numerics;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger MaxResult = 0;
            BigInteger diagonalSum = 0;

            var matrix = new long[n, n];

            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = Parse(line[col]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 4; j++)
                {
                    BigInteger result = 0;
                    if (matrix[i, j] + 1 == matrix[i, j + 1] &&
                        matrix[i, j + 1] + 1 == matrix[i, j + 2] &&
                        matrix[i, j + 2] + 1 == matrix[i + 1, j + 2] &&
                        matrix[i + 1, j + 2] + 1 == matrix[i + 2, j + 2] &&
                        matrix[i + 2, j + 2] + 1 == matrix[i + 2, j + 3] &&
                        matrix[i + 2, j + 3] + 1 == matrix[i + 2, j + 4])
                    {
                        result += (matrix[i, j] +
                                matrix[i, j + 1] +
                                matrix[i, j + 2] +
                                matrix[i + 1, j + 2] +
                                matrix[i + 2, j + 2] +
                                matrix[i + 2, j + 3] +
                                matrix[i + 2, j + 4]);
                    }
                    if (result > MaxResult)
                    {
                        MaxResult = result;
                    }
                }
            }
            if (MaxResult == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    diagonalSum += matrix[i, i];
                }
                Console.WriteLine("NO {0}", diagonalSum);
            }
            else
            {
                Console.WriteLine("YES {0}", MaxResult);
            }
        }

        private static long Parse(string numberToParse)
        {
            long result = 0;
            for (int i = 0; i < numberToParse.Length; i++)
            {
                result *= 10;
                result += numberToParse[i] - '0';
            }
            return result;
        }
    }
}