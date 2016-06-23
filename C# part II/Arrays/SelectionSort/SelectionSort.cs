using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                list.Add(nums);
            }
            list.Sort();
            foreach (var item in list)
            {
            Console.WriteLine(item);
            }
        }
    }
}
