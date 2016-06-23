using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
