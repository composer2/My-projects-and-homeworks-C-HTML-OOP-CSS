using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValuePaths
{
    class SpecialValuePaths
    {
        static int[][] ReadData(int [][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currLine = Console.ReadLine().Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);

                field[i] = new int[currLine.Length];

                for (int l = 0; l < currLine.Length; l++)
                {
                    field[i][l] = int.Parse(currLine[l]);
                }
            }
            return field;
        }
        static long FindValue(int [][]field,int column, bool[][] used)
        {
            long result = 0;
            int currRow = 0;

            for (int i = 0; i < used.GetLength(0); i++)
            {
                used[i] = new bool[field[i].Length];
            }

            while (true)
            {
                result++;

                if (used[currRow][column])
                {
                    return long.MinValue;
                }
                if (field[currRow][column]<0)
                {
                    result -= field[currRow][column];
                    return result;
                }
                int nextColumn= field[currRow][column];
                used[currRow][column] = true;
                column = nextColumn;
                currRow++;
                if (currRow == field.GetLength(0));
                {
                    currRow = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] field = new int[n][];

            ReadData(field);

            bool[][] used = new bool[n][];

            for (int i = 0; i < n; i++)
            {
                used[i] = new bool[field[i].Length];
            }

            long max = long.MinValue;

            for (int i = 0; i < field[0].Length; i++)
            {
                long specialValue = FindValue(field, i, used);
                if (max<specialValue)
                {
                    max = specialValue;
                }
            }
            Console.WriteLine(max);
        }
    }
}
