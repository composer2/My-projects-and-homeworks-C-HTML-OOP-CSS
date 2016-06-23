using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {

            int numN = int.Parse(Console.ReadLine());
            string way = Console.ReadLine();
            int[,] spiralMatrix = new int[numN, numN];
            int maxValue = numN * numN;
            if (way == "a")
            {
                int value = 1;
                for (int row = 0; row < numN; row++)
                {
                    for (int col = 0; col < numN; col++)
                    {
                        spiralMatrix[row, col] = value;
                        value++;
                    }
                }
                for (int row = 0; row < numN; row++)
                {
                    for (int col = 0; col < numN; col++)
                    {
                        if (col == numN - 1)
                        {
                            Console.Write(spiralMatrix[col, row]);

                        }
                        else
                        {
                            Console.Write(spiralMatrix[col, row] + " ");
                        }
                    }
                    Console.WriteLine();
                }

            }
            else if (way == "b")
            {
                int row = 0;
                int col = 0;
                string direction = "right";
                for (int i = 1; i <= maxValue; i++)
                {
                    if (direction == "right" && col > numN - 1)
                    {
                        direction = "left";
                        row++;
                        col--;
                    }
                    if (direction == "left" && col < 0 )
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
                    
                    if (direction == "left")
                    {
                        col--;
                    }
                   
                }
                // Print opsite Matrix:
                for (int r = 0; r < numN; r++)
                {
                    for (int c = 0; c < numN; c++)
                    {
                        if (c == numN - 1)
                        {
                            Console.Write(spiralMatrix[c, r]);
                        }
                        else
                        {
                            Console.Write(spiralMatrix[c, r] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (way == "c")
            {
                int rows = 0;
                int cols = 0;
                int value = 1;

                for (int i = numN - 1; i >= 0; i--)
                {
                    rows = i;
                    cols = 0;
                    while (rows < numN && cols < numN)
                    {
                        spiralMatrix[rows++, cols++] = value++;
                    }
                }

                for (int j = 1; j < numN; j++)
                {
                    rows = j;
                    cols = 0;
                    while (rows < numN && cols < numN)
                    {
                        spiralMatrix[cols++, rows++] = value++;
                    }
                }
                // Print Spiral Matrix:
                for (int c = 0; c < numN; c++)
                {
                    for (int r = 0; r < numN; r++)
                    {
                        if (r == numN - 1)
                        {
                            Console.Write(spiralMatrix[c, r]);
                        }
                        else
                        {
                            Console.Write(spiralMatrix[c, r] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (way == "d")
            {
                //spiral Matrix
                int row = 0;
                int col = 0;
                string direction = "right";
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
                for (int c = 0; c < numN; c++)
                {
                    for (int r = 0; r < numN; r++)
                    {
                        if (r == numN - 1)
                        {
                            Console.Write(spiralMatrix[r, c]);
                        }
                        else
                        {
                            Console.Write(spiralMatrix[r, c] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
