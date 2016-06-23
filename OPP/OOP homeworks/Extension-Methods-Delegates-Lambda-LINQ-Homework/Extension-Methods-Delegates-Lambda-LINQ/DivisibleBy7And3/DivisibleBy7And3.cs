using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main(string[] args)
        {
            //arr int
            var numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            //sorted with lambda
            var lambdaLocate = numbers.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
            Console.WriteLine("Numbers that are are divisible by 7 and 3(using lambda and extention methods): ");
            Console.WriteLine(new string('*', 40));
            foreach (var number in lambdaLocate)
            {
                Console.WriteLine(number);
            }

            //sorted with LINQ
            var linqLocate = from number in numbers
                             where number % 7 == 0 && number % 3 == 0
                             select number;

            Console.WriteLine();
            Console.WriteLine("Numbers that are are divisible by 7 and 3(using LINQ): ");
            Console.WriteLine(new string('*', 40));
            foreach (var number in linqLocate)
            {
                Console.WriteLine(number);
            }
        }
    }
}
