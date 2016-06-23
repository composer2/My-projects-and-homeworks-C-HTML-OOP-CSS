using System;
using System.Linq;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var matrix = new string[arr[0], arr[1]];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var nums = Console.ReadLine().Split().ToArray();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = nums[j];
            }
        }

        int bestCount = 0;
        string element = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string current = matrix[i, j];

                // Horizontal
                int col = j;
                int count = 0;
                while (col < matrix.GetLength(1))
                {
                    if (matrix[i, col++] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }

                // Vertical
                int row = i;
                count = 0;
                while (row < matrix.GetLength(0))
                {
                    if (matrix[row++, j] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }

                // First Diagonal
                row = i;
                col = j;
                count = 0;
                while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
                {
                    if (matrix[row++, col++] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }

                // Second Diagonal
                row = i;
                col = j;
                count = 0;
                while (row < matrix.GetLength(0) && col >= 0)
                {
                    if (matrix[row++, col--] == current)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    element = current;
                }
            }
        }
        Console.WriteLine(bestCount);
    }
}
