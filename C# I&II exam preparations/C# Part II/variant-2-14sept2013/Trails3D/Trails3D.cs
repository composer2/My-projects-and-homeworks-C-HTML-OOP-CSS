using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    class Trails3D
    {

        static void Main(string[] args)
        {
            int[] xyz = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = xyz[0];
            int y = xyz[1];
            int z = xyz[2];
            int rows = y + 1;
            int cols = 2 * x + 2 * z;
            bool[,] visited = new bool[rows, cols];

            int redRow = y / 2;
            int redCol = x / 2;
            int redDir = 0;

            int blueRow = y / 2;
            int blueCol = x + z + x / 2;
            int blueDir = 2;

            int[] dRows = { 0, +1, 0, -1 };
            int[] dCols = { +1, 0, -1, 0 };


            string redMoves = TransformMoves(Console.ReadLine());
            string blueMoves = TransformMoves(Console.ReadLine());

            int redMoveIndex = 0;
            int blueMoveIndex = 0;

            bool redHasCrashed = false;
            bool blueHasCrashed = false;



            while (!redHasCrashed && !blueHasCrashed)
            {
                char redMove = redMoves[redMoveIndex];
                while (redMove == 'M')
                {
                    redDir = ChangeDir(redDir, redMove);
                    redMove = redMoves[redMoveIndex++];
                }
                char blueMove = blueMoves[blueMoveIndex];
                while (redMove == 'M')
                {
                    blueDir = ChangeDir(blueDir, blueMove);
                    blueMove = blueMoves[blueMoveIndex++];
                }
                int nextRedRow = redRow + dRows[redDir];
                int nextRedCol = redCol + dCols[redDir];
                nextRedCol = (nextRedCol + cols) % cols;

                int nextBlueRow = blueRow + dRows[blueDir];
                int nextBlueCol = blueCol + dCols[blueDir];
                nextBlueCol = (nextBlueCol + cols) % cols;

                if (nextRedRow < 0 || nextRedRow >= rows || visited[nextRedRow, nextRedCol] || (nextRedRow == nextBlueRow) && (nextRedCol == nextBlueCol))
                {
                    redHasCrashed = true;
                }
                if (nextBlueRow < 0 || nextBlueRow >= rows || visited[nextBlueRow, nextBlueCol] || (nextRedRow == nextBlueRow) && (nextRedCol == nextBlueCol))
                {
                    blueHasCrashed = true;
                }
                if (redHasCrashed || blueHasCrashed)
                {
                    break;
                }
                visited[nextRedRow, nextRedCol] = true;
                visited[nextBlueRow, nextBlueCol] = true;
                redRow = nextRedRow;
                redCol = nextRedCol;
                blueRow = nextBlueRow;
                blueCol = nextBlueCol;
                redMoveIndex++;
                blueMoveIndex++;
            }
            if (redHasCrashed && blueHasCrashed)
            {
                Console.WriteLine("DRAW");
            }
            else if (redHasCrashed)
            {
                Console.WriteLine("BLUE");
            }
            else
            {
                Console.WriteLine("RED");
            }

            int startRow = y / 2;
            int startCol = x / 2;
            
            int distance = Math.Abs(startRow-redRow)+ Math.Abs(startCol - redRow);
            Console.WriteLine(distance);
        }

        private static int ChangeDir(int redDir, char redMove)
        {
            if (redMove == 'L')
            {
                redDir--;
            }
            else
            {
                redDir++;
            }
            return (redDir + 4) % 4;
        }

        private static string TransformMoves(string moves)
        {
            StringBuilder allMoves = new StringBuilder();
            List<char> digits = new List<char>();
            foreach (var move in moves)
            {
                if (char.IsDigit(move))
                {
                    digits.Add(move);
                }
                else
                {
                    if (digits.Count == 0)
                    {
                        digits.Add('1');
                    }
                    digits.Reverse();
                    int count = int.Parse(string.Join("", digits));
                    allMoves.Append(move, count);
                    digits.Clear();
                }
            }
            return allMoves.ToString();
        }
    }
}
