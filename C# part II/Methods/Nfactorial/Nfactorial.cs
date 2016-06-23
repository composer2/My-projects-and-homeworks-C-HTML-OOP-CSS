using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Nfactorial
{
    class Nfactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            BigInteger result = CalculateFactorial(arr,n);
            Console.WriteLine(result);
        }

        private static BigInteger CalculateFactorial(int[] arr, int n)
        {
            BigInteger fact = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
                fact *= arr[i];
            }
            return fact;
        }
    }
}
