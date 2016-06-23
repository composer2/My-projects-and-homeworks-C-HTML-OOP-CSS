using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aximalKsum
{
    class MaximalKsum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                list.Add(nums);
            }
            list.Sort();
            list.Reverse();
            for (int i = 0; i < k; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
