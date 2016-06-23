using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            var matrix = Input();
            var pattern = new bool[,]
            {
                {true,true,true,false,false},
                {false,false,true,false,false},
                {false,false,true,true,true},
            };
            long maxSum = long.MinValue;
            bool GlobllyfoundCorrectPattern = false;
            for (int patternStartX = 0; patternStartX <= matrix.GetLength(0) - pattern.GetLength(0); patternStartX++)
            {
                for (int patternStartY = 0; patternStartY <= matrix.GetLength(1) - pattern.GetLength(1); patternStartY++)
                {
                    var numberInPattern = new List<int>();
                    for (int patternX = 0; patternX < pattern.GetLength(0); patternX++)
                    {
                        for (int patternY = 0; patternY < pattern.GetLength(1); patternY++)
                        {
                            var x = patternStartX + patternX;
                            var y = patternStartY + patternY;
                            if (pattern[patternX, patternY])
                            {
                                numberInPattern.Add(matrix[x, y]);
                            }
                        }
                    }
                    bool foundCorrectPattern = true;
                    for (int i = 1; i < numberInPattern.Count; i++)
                    {
                        if (numberInPattern[i - 1] != numberInPattern[i] - 1)
                        {
                            foundCorrectPattern = false;
                            break;
                        }
                    }
                    if (foundCorrectPattern)
                    {
                        GlobllyfoundCorrectPattern = true;
                        long sum = 0;
                        foreach (var item in numberInPattern)
                        {
                            sum += item;
                        }
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            if (GlobllyfoundCorrectPattern)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                Console.WriteLine("NO {0}", SumDiagonal(matrix));
            }
        }
        private static long SumDiagonal(int[,] matrix)
        {
            long sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, i];
            }
            return sum;
        }

        private static int[,] Input()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }
            return matrix;
        }
    }
}
