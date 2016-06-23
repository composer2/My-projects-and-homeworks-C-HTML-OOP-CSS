using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BitShiftMatrix
{
    class BitShiftMatrix
    {
        static void Main()
        {


            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var moves = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var coeff = Math.Max(rows, cols);
            var field = new bool[rows, cols];

            BigInteger result = 0;
            int row = rows - 1;
            int col = 0;
            BigInteger currCellValue = 1;

            foreach (var move in moves)
            {
                var nextRow = move / coeff;
                var nextCol = move % coeff;

                var deltaCol = col > nextCol ? -1 : 1;
                while (col != nextCol)
                {
                    if (!field[row, col])
                    {
                        result += currCellValue;
                        field[row, col] = true;
                    }
                    if (deltaCol == 1)
                    {
                        currCellValue *= 2;
                    }
                    else
                    {
                        currCellValue /= 2;
                    }
                    col += deltaCol;
                }
                var deltaRow = row > nextRow ? -1 : 1;
                while (row != nextRow)
                {
                    if (!field[row, col])
                    {
                        result += currCellValue;
                        field[row, col] = true;
                    }

                    if (deltaRow == 1)
                    {
                        currCellValue /= 2;
                    }
                    else
                    {
                        currCellValue *= 2;
                    }
                    row += deltaRow;
                }
            }
            if (!field[row, col])
            {
                result += currCellValue;
                field[row, col] = true;
            }
            Console.WriteLine(result);
        }
    }
}
