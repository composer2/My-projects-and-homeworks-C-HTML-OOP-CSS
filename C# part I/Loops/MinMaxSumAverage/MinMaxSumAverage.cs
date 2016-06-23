using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double sum = 0.00;
            double max = double.MinValue;
            double min = double.MaxValue;
            for (int i = 1; i <= N; i++)
            {
               double numbers = double.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers > max)
                {
                    max = numbers;
                }
                if (numbers < min)
                {
                    min = numbers;
                }
            }
            double average = sum / N;
            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", average);
        }
    }
}
