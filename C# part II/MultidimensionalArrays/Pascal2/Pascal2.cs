using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal2
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
            for (int row = 1; row <= height; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    if (col-1<0)
                    {
                    triangle[row][col] = triangle[row-1][col];
                    }
                    else if(triangle[row-1].Length<=col)
                    {
                        triangle[row][col] = triangle[row - 1][col-1];
                    }
                    else
                    {
                    triangle[row][col] = triangle[row-1][col]+ triangle[row-1][col-1];
                    }
                }
            }
            for (int row = 0; row <= height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,4}", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
