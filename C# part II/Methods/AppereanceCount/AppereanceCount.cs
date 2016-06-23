using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppereanceCount
{
    class AppereanceCount
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var array = FillArray(numbers);
            int numX= int.Parse(Console.ReadLine());
            Console.WriteLine(Occurrencies(array,numX));
        }
        static int[] FillArray(int n)
        {
            var array = new int[n];
            array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return array;
        }
        static int Occurrencies(int[] arr, int X)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num==X)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
