using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoverOf3second
{
    class LoverOf3second
    {
        static void Main(string[] args)
        {
            var fieldSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = fieldSizes[0];
            var cols = fieldSizes[1];

            var field = new bool[rows, cols];

            var n = int.Parse(Console.ReadLine());

            long result = 0;

            int row = rows-1;
            int col = 0;

            for (int i = 0; i < n; i++)
            {
                var move = Console.ReadLine().Split();
                var direction = move[0];
                var repeats = int.Parse(move[1]);

                var deltaRow = direction.Contains("U") ? -1 : 1;
                var deltaCol = direction.Contains("L") ? -1 : 1;

                for (int j = 1; j < repeats; j++)
                {

                    bool rowIsInfield = 0 <= row + deltaRow && row + deltaRow < field.GetLength(0);
                    bool colIsInfield = 0 <= col + deltaCol && col + deltaCol < field.GetLength(1);

                    if (rowIsInfield&&colIsInfield)
                    {
                        row += deltaRow;
                        col += deltaCol;
                        if (!field[row,col])
                        {
                            result += col * 3 + (rows - 1 - row) * 3;
                            field[row, col] = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
