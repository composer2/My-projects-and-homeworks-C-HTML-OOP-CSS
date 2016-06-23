using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoverOf3
{
    class LoverOf3
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = sizes[0];
            var cols = sizes[1];

            var matrix = new int[rows, cols];
            int number = 0;
            for (int row = 0; row < rows; row++)
            {
                matrix[rows - row - 1, 0] = number;
                number += 3;
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 1; col < cols; col++)
                {
                    matrix[rows - row - 1, col] = matrix[rows - row - 1, col - 1] + 3;
                }
            }
            string direction = "";
            int startRow = rows - 1;
            int startCol = 0;

            long result = 0;
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                direction = command[0];
                int timesToMove = int.Parse(command[1]);
                while (timesToMove > 0 && startRow < rows && startRow >= 0 && startCol < cols && startCol >= 0)
                {
                    if (direction == "UR" || direction == "RU")
                    {
                        result += matrix[startRow, startCol];
                        if (startRow < rows && startRow >= 0 && startCol < cols && startCol >= 0)
                        {
                            matrix[startRow, startCol] = 0;
                        }
                        startRow--;
                        startCol++;
                    }
                    if (direction == "UL" || direction == "LU")
                    {
                        result += matrix[startRow, startCol];
                        if (startRow < rows && startRow >= 0 && startCol < cols && startCol >= 0)
                        {
                            matrix[startRow, startCol] = 0;
                        }
                        startRow--;
                        startCol--;
                    }
                    if (direction == "LD" || direction == "DL")
                    {
                        result += matrix[startRow, startCol];
                        if (startRow < rows && startRow >= 0 && startCol < cols && startCol >= 0)
                        {
                            matrix[startRow, startCol] = 0;
                        }
                        startRow++;
                        startCol--;
                    }
                    if (direction == "DR" || direction == "RD")
                    {
                        result += matrix[startRow, startCol];
                        if (startRow < rows && startRow >= 0 && startCol < cols && startCol >= 0)
                        {
                            matrix[startRow, startCol] = 0;
                        }
                        startRow++;
                        startCol++;
                    }
                    timesToMove--;
                }
                if (direction == "UR" || direction == "RU")
                {
                    startRow++;
                    startCol--;
                }
                if (direction == "UL" || direction == "LU")
                {
                    startRow++;
                    startCol++;
                }
                if (direction == "LD" || direction == "DL")
                {
                    startRow--;
                    startCol++;
                }
                if (direction == "DR" || direction == "RD")
                {
                    startRow--;
                    startCol--;
                }
            }
            Console.WriteLine(result);
        }
    }
}