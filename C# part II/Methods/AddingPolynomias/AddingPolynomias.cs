using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomias
{
    class AddingPolynomias
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arrPoly = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arrPoly1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var result = SumPolinomys(arrPoly,arrPoly1,n);
            Console.WriteLine(string.Join(" ", result));
        }
        static int[] SumPolinomys(int[] arr1, int[] arr2, int n)
        {
            var result = new int[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }
    }
}
