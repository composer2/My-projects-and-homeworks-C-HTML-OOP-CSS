using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6, }, { 7, 8 } };
            for (int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.GetLength(1); col++)
                {
                    Console.Write("{0}", firstMatrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] secondMatrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6, } };
            for (int row = 0; row < secondMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < secondMatrix.GetLength(1); col++)
                {
                    Console.Write("{0}", secondMatrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int cols1 = firstMatrix.GetLength(1);
            int rows1 = firstMatrix.GetLength(0);
            int cols2 = secondMatrix.GetLength(1);
            int rows2 = secondMatrix.GetLength(0);

            if (cols1!=rows2)
            {
                throw new ArgumentException("Invalid dimenssions!");
            }
            int[,] resultMatrix = new int[rows1, cols2];
            for (int row = 0; row < rows1; row++)
            {
                for (int col = 0; col < cols2; col++)
                {
                    resultMatrix[row, col] = 0;
                    for (int i = 0; i < cols1; i++)
                    {
                        resultMatrix[row, col] = firstMatrix[row, i]*secondMatrix[i,col];
                    }
                }
            }
            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write("{0}", resultMatrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
