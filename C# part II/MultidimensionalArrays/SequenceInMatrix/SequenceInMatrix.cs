using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    { 
        static int FindStreak(string[,] matrix, int startRow, int startCol, int direction)
        {
            int count = -1;
            //проверка на реда
            if (direction == 0)
            {
                count = 1;
                for (int i = startCol + 1; i < matrix.GetLength(1); i++)
                {
                    if (matrix[startRow, i] == matrix[startRow, startCol])
                    {
                        count++;
                    }
                }
            }
            //проверка на диагонала
            else if (direction == 1)
            {
                count = 1;
                int diagonalSize = (matrix.GetLength(0) < matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1);
                for (int i = startCol + 1; i < diagonalSize; i++)
                {
                    if (matrix[i, i] == matrix[startRow, startCol])
                    {
                        count++;
                    }
                }
            }
            //проверка на колоната
            else if (direction == 2)
            {
                count = 1;
                for (int rows = startRow + 1; rows < matrix.GetLength(0); rows++)
                {
                    if (matrix[rows, startCol] == matrix[startRow, startCol])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
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

            int max = 0;
            int temp = 0;
            int currRow = 0;
            int currCol = 0;
            int currDiag = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    string curr = matrix[rows, cols];
                    currRow = FindStreak(matrix, rows, cols, 0);
                    currDiag = FindStreak(matrix, rows, cols, 1);
                    currCol = FindStreak(matrix, rows, cols, 2);
                    temp = Math.Max(Math.Max(currRow, currCol), currDiag);
                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
