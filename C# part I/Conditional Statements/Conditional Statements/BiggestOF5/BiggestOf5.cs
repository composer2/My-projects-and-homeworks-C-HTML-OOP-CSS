using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOF5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            var numA = double.Parse(Console.ReadLine());
            var numB = double.Parse(Console.ReadLine());
            var numC = double.Parse(Console.ReadLine());
            var numD = double.Parse(Console.ReadLine());
            var numE = double.Parse(Console.ReadLine());
            var biggestNumber = double.MinValue;
            if (numA > biggestNumber)
            {
                biggestNumber = numA;
            }
            if (numB > biggestNumber)
            {
                biggestNumber = numB;
            }
            if (numC > biggestNumber)
            {
                biggestNumber = numC;
            }
            if (numD > biggestNumber)
            {
                biggestNumber = numD;
            }
            if (numE > biggestNumber)
            {
                biggestNumber = numE;
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
