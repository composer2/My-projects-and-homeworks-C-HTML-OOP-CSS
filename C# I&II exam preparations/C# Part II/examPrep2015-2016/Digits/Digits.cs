using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new long[n, n];

            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            BigInteger result = 0;
            for (int i = 0; i < matrix.GetLength(0) - 4; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {

                    if (matrix[i, j] == 9 && matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j] &&
                             matrix[i + 1, j] == matrix[i + 1, j + 2] &&
                             matrix[i + 1, j + 2] == matrix[i + 2, j + 1] &&
                             matrix[i + 2, j + 1] == matrix[i + 2, j + 2] &&
                             matrix[i + 2, j + 2] == matrix[i + 3, j + 2] &&
                             matrix[i + 3, j + 2] == matrix[i + 4, j] &&
                             matrix[i + 4, j] == matrix[i + 4, j + 1] &&
                             matrix[i + 4, j + 1] == matrix[i + 4, j + 2])
                    {
                        result += 9;
                    }
                    else if (matrix[i + 2, j] == 1 && matrix[i + 2, j] == matrix[i + 1, j + 1] &&
                        matrix[i + 1, j + 1] == matrix[i, j + 2] &&
                        matrix[i, j + 2] == matrix[i + 1, j + 2] &&
                        matrix[i + 1, j + 2] == matrix[i + 2, j + 2] &&
                        matrix[i + 2, j + 2] == matrix[i + 3, j + 2] &&
                        matrix[i + 3, j + 2] == matrix[i + 4, j + 2])
                    {
                        result++;
                    }
                    else if (matrix[i + 1, j] == 2 && matrix[i + 1, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i + 1, j + 2] &&
                             matrix[i + 1, j + 2] == matrix[i + 2, j + 2] &&
                             matrix[i + 2, j + 2] == matrix[i + 3, j + 1] &&
                             matrix[i + 3, j + 1] == matrix[i + 4, j] &&
                             matrix[i + 4, j] == matrix[i + 4, j + 1] &&
                             matrix[i + 4, j + 1] == matrix[i + 4, j + 2])
                    {
                        result += 2;
                    }
                    else if (matrix[i, j] == 3 && matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j + 2] &&
                             matrix[i + 1, j + 2] == matrix[i + 2, j + 1] &&
                             matrix[i + 2, j + 1] == matrix[i + 2, j + 2] &&
                             matrix[i + 2, j + 2] == matrix[i + 3, j + 2] &&
                             matrix[i + 3, j + 2] == matrix[i + 4, j] &&
                             matrix[i + 4, j] == matrix[i + 4, j + 1] &&
                             matrix[i + 4, j + 1] == matrix[i + 4, j + 2])
                    {
                        result += 3;
                    }
                    else if (matrix[i, j] == 4 && matrix[i, j] == matrix[i + 1, j] &&
                             matrix[i + 1, j] == matrix[i + 2, j] &&
                             matrix[i + 2, j] == matrix[i + 2, j + 1] &&
                             matrix[i + 2, j + 1] == matrix[i + 2, j + 2] &&
                             matrix[i + 2, j + 2] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j + 2] &&
                             matrix[i + 1, j + 2] == matrix[i + 3, j + 2] &&
                             matrix[i + 3, j + 2] == matrix[i + 4, j + 2])
                    {
                        result += 4;
                    }
                    else if (matrix[i, j] == 5 && matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j] &&
                             matrix[i + 1, j] == matrix[i + 2, j] &&
                             matrix[i + 2, j] == matrix[i + 2, j + 1] &&
                             matrix[i + 2, j + 1] == matrix[i + 2, j + 2] &&
                             matrix[i + 2, j + 2] == matrix[i + 3, j + 2] &&
                             matrix[i + 3, j + 2] == matrix[i + 4, j + 2] &&
                             matrix[i + 4, j + 2] == matrix[i + 4, j + 1] &&
                             matrix[i + 4, j + 1] == matrix[i + 4, j])
                    {
                        result += 5;
                    }
                    else if (matrix[i, j] == 6 && matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j] &&
                             matrix[i + 1, j] == matrix[i + 2, j] &&
                             matrix[i + 2, j] == matrix[i + 3, j] &&
                             matrix[i + 3, j] == matrix[i + 4, j] &&
                             matrix[i + 4, j] == matrix[i + 4, j + 1] &&
                             matrix[i + 4, j + 1] == matrix[i + 4, j + 2] &&
                             matrix[i + 4, j + 2] == matrix[i + 3, j + 2] &&
                             matrix[i + 3, j + 2] == matrix[i + 2, j + 2] &&
                             matrix[i + 2, j + 2] == matrix[i + 2, j + 1])
                    {
                        result += 6;
                    }
                    else if (matrix[i, j] == 7 && matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j + 2] &&
                             matrix[i + 1, j + 2] == matrix[i + 2, j + 1] &&
                             matrix[i + 2, j + 1] == matrix[i + 3, j + 1] &&
                             matrix[i + 3, j + 1] == matrix[i + 4, j + 1])
                    {
                        result += 7;
                    }
                    else if (matrix[i, j] == 8 && matrix[i, j] == matrix[i, j + 1] &&
                             matrix[i, j + 1] == matrix[i, j + 2] &&
                             matrix[i, j + 2] == matrix[i + 1, j + 2] &&
                             matrix[i + 1, j + 2] == matrix[i + 1, j] &&
                             matrix[i + 1, j] == matrix[i + 2, j + 1] &&
                             matrix[i + 2, j + 1] == matrix[i + 3, j] &&
                             matrix[i + 3, j] == matrix[i + 3, j + 2] &&
                             matrix[i + 3, j + 2] == matrix[i + 4, j] &&
                             matrix[i + 4, j] == matrix[i + 4, j + 1] &&
                             matrix[i + 4, j + 1] == matrix[i + 4, j + 2])
                    {

                        result += 8;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
