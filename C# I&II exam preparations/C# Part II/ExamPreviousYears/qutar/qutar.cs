using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qutar
{
    class qutar
    {
        static void Main(string[] args)
        {
            var songsString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var songs = new int[songsString.Length];

            for (int i = 0; i < songs.Length; i++)
            {
                songs[i] = int.Parse(songsString[i]);
            }

            int start = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int[,] clever = new int[songs.Length + 1, max + 1];
            clever[0, start] = 1;

            for (int i = 0; i < clever.GetLength(0); i++)
            {
                var interval = songs[i - 1];
                for (int j = 0; j < clever.GetLength(1); j++)
                {
                    if (clever[i-1,j]==1)
                    {
                        if (j-interval>=0)
                        {
                            clever[i, j - interval] = 1;
                        }
                        if (j + interval <= max)
                        {
                            clever[i, j + interval] = 1;
                        }
                    }
                }
            }

            for (int i = max; i >=0; i--)
            {
                if (clever[songs.Length,i]==1)
                {
                    Console.WriteLine(i);
                    return; //if (clever[songs.Length,i]==1) is true at least once nothing after return will be executed
                }
            }
            Console.WriteLine(-1);
        }
    }
}
