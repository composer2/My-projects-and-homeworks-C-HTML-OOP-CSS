using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices
{
    class Indices
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split();
            int[] arrayOfNumbers = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(array[i]);
            }

            bool[] visited = new bool[n];

            int currIndex = 0;
            int loopStart = -1;

            StringBuilder result = new StringBuilder();

            while (true)
            {
                if (currIndex < 0 && currIndex >= n)
                {
                    break;
                }
                if (visited[currIndex])
                {
                    loopStart = currIndex;
                    break;
                }
                visited[currIndex] = true;
                result.Append(currIndex);
                result.Append(' ');
                currIndex = arrayOfNumbers[currIndex];
            }
            if (loopStart>=0)
            {
               int index=result.ToString().IndexOf((" "+loopStart+" ").ToString());
                if (index<0)
                {
                    result.Insert(0, '(');
                }
                else
                {
                    result[index] = '(';
                }
                result[result.Length - 1] = ')';
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
