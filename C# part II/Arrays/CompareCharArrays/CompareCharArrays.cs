using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {


            var arr1 = Console.ReadLine();
            var arr2 = Console.ReadLine();
            if (arr1.Length<arr2.Length)
            {
                Console.WriteLine("<");
            }
            else if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(">");
            }
            else if (arr1.Length==arr2.Length)
            {
                if (arr1==arr2)
                {
                    Console.WriteLine("=");
                }
                else
                {
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr1[i] < arr2[i])
                        {
                            Console.WriteLine("<");
                            return;
                        }
                        if (arr1[i] > arr2[i])
                        {
                            Console.WriteLine(">");
                            return;
                        }
                    }
                }
            }
        }
    }
}
