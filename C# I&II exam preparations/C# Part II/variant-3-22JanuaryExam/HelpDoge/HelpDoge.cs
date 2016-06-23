using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HelpDoge
{
    class HelpDoge
    {
        const int BadDogeValue = -1;
        static int fx, fy;
        static void Main(string[] args)
        {
            var field = Input();
            for (int row = 0; row < field.GetLongLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (row==0&&col==0)
                    {
                        field[0, 0] = 1;
                        continue;
                    }
                    if (row==0)
                    {
                        field[0, col] = field[0, col - 1];
                        continue;
                    }
                    if (field[row,col]== BadDogeValue)
                    {
                        field[row, col] = 0;
                        continue;
                    }
                    if (col==0)
                    {
                        field[row, 0] = field[row - 1, 0];
                        continue;
                    }
                    field[row, col] = field[row - 1, col] + field[row, col - 1];
                }
            }
            Console.WriteLine(field[]);
        }

        private static BigInteger[,] Input()
        {
            string line = Console.ReadLine();
            var numberAsStrings = line.Split();
            int n = int.Parse(numberAsStrings[0]);
            int m = int.Parse(numberAsStrings[1]);
            line = Console.ReadLine();
            numberAsStrings = line.Split();
            fx = int.Parse(numberAsStrings[0]);
            fy = int.Parse(numberAsStrings[1]);
            int k = int.Parse(Console.ReadLine());

            BigInteger[,] field = new BigInteger[n, m];
            for (int i = 0; i < k; i++)
            {
                line = Console.ReadLine();
                numberAsStrings = line.Split();
                int x = int.Parse(numberAsStrings[0]);
                int y = int.Parse(numberAsStrings[1]);
                field[x, y] = BadDogeValue;
            }
            return field;
        }
    }
}
