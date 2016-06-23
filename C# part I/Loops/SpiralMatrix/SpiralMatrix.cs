using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();
            uint numN = uint.Parse(numberStr);

            int[,] spiralMatrix = new int[numN, numN];
            int row = 0;
            int col = 0;
            string direction = "right";
            uint maxValue = numN * numN;

            for (int i = 1; i <= maxValue; i++)
            {
                if (direction == "right" && (col > (numN - 1) || spiralMatrix[row, col] != 0))
                {
                    direction = "down";
                    row++;
                    col--;
                }
                if (direction == "down" && (row > (numN - 1) || spiralMatrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || spiralMatrix[row, col] != 0))
                {
                    direction = "up";
                    row--;
                    col++;
                }
                if (direction == "up" && (row < 0 || spiralMatrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                spiralMatrix[row, col] = i;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            // Print Spiral Matrix:
          
            for (int r = 0; r < numN; r++)
            {
                for (int c = 0; c < numN; c++)
                {
                    Console.Write(spiralMatrix[r, c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
