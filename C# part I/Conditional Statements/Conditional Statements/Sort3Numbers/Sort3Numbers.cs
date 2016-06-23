using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            var numA = double.Parse(Console.ReadLine());
            var numB = double.Parse(Console.ReadLine());
            var numC = double.Parse(Console.ReadLine());

            if (numA >= numB && numB >= numC)
            {
                Console.Write("{0} {1} {2}", numA, numB, numC);
            }
            else if (numA >= numC && numC >= numB)
            {
                Console.Write("{0} {1} {2}", numA, numC, numB);
            }
            else if (numB >= numA && numA >= numC)
            {
                Console.Write("{0} {1} {2}", numB, numA, numC);
            }
            else if (numB >= numC && numC >= numA)
            {
                Console.Write("{0} {1} {2}", numB, numC, numA);
            }
            else if (numC >= numA && numA >= numB)
            {
                Console.Write("{0} {1} {2}", numC, numA, numB);
            }
            else if (numC >= numB && numB >= numA)
            {
                Console.Write("{0} {1} {2}", numC, numB, numA);
            }
            Console.WriteLine();
        }
    }
}
