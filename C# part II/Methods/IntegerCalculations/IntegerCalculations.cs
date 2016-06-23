using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = CalcMin(arr);
            int max = CalcMax(arr);
            double avrg = CalcAvrg(arr);
            int sum = CalcSum(arr);
            long product = CalcProduct(arr);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("{0:f2}", avrg);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        private static long CalcProduct(int[] arr)
        {
            long result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }
        private static int CalcSum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
        private static double CalcAvrg(int[] arr)
        {
            double result = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            result /= arr.Length;
            return result;
        }
        private static int CalcMax(int[] arr)
        {
            var sorted = arr;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int result = sorted[sorted.Length-1];
            return result;
        }
        private static int CalcMin(int[] arr)
        {
            var sorted = arr;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int result = sorted[0];
            return result;
        }
    }
}
