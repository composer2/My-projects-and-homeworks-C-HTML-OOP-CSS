using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        private double[] array;

        public SumIntegers(double[] array)
        {
            this.array = array;
        }

        public double[] Array
        {
            get { return array; }
            set { array = value; }
        }
        static double Result(double[] numbers)
        {
            var result = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            SumIntegers sum = new SumIntegers(Console.ReadLine().Split().Select(double.Parse).ToArray());
            Console.WriteLine(Result(sum.array));
        }
    }
}
