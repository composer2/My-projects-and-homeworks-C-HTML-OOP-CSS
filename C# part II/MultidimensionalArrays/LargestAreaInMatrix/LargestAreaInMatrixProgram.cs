using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

class LargestAreaInMatrix
{
    public static int[,] matrix;
    public static bool[,] visited;
    
    static int DepthFirstSearch(int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }
        if (visited[row, col])
        {
            return 0;
        }
        if (matrix[row, col] != value)
        {
            return 0;
        }
        visited[row, col] = true;

        return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
            DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
    }

    static void PrintResult()
    {
        int result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));
            }
        }
        Console.WriteLine(result);
    }
    static void Main()
    {
        var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        matrix =new int[arr[0], arr[1]];
        visited = new bool[arr[0], arr[1]];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = nums[j];
            }
        }
        PrintResult();
    }
}