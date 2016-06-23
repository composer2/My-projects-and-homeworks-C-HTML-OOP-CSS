using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogeCoin
{
    class DogeCoin
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] coins = new int[n[0], n[1]];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string[] currCoordinates = Console.ReadLine().Split();
                int currCoinRow = int.Parse(currCoordinates[0]);
                int currCoinCol = int.Parse(currCoordinates[1]);

                coins[currCoinRow, currCoinCol]++;
            }
            int[,] dp = new int[n[0], n[1]];

            for (int row = 0; row < n[0]; row++)
            {
                for (int col = 0; col < n[1]; col++)
                {
                    int maxAbove = 0;
                    int maxLeft = 0;
                    if (row-1>=0)
                    {
                        maxAbove = dp[row - 1, col];
                    }
                    if (col-1>=0)
                    {
                        maxLeft = dp[row, col - 1];
                    }
                    dp[row, col] = Math.Max(maxAbove, maxLeft) + coins[row, col];
                }
            }
            Console.WriteLine(dp[n[0]-1,n[1]-1]);
        }
    }
}
