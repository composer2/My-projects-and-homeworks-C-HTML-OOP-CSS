using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class PascalTriangle
    {
        private static void Main()
        {
            var height = 10;
            var triangle = new long[height + 1][];
            for (int row = 0; row <= height; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                        triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            for (int row = 0; row <= height; row++)
            {
                Console.Write("".PadLeft((height-row)*2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,4}",triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
