using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPage
{
    class GameOfPage
    {
        static void Main(string[] args)
        {
            var matrix = new long[3, 3];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " "); 
                }
                Console.WriteLine();
            }

           
        }
    }
}
