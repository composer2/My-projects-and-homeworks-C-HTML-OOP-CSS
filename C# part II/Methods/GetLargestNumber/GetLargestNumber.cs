using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main(string[] args)
        {
         var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(GetMax(GetMax(arr[0],arr[1]),arr[2]));
        }
        static int GetMax(int a, int b)
        {
            int max = a;
            if (b > a)
            {
                max = b;
            }
            return max;
        }
    }
}
