using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double result = 1.0;
            int fact = 1;
            double tempDevider = 1.0;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                tempDevider *= X;
                result =result+ (fact / tempDevider);

            }
            Console.WriteLine("{0:f5}", result);
        }
    }
}
