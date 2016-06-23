using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class SqrtPrecalculated
    {
        public const int MaxValue = 10000;

        //static field
        private static double[] sqrtValues;

        //static constructor
        static SqrtPrecalculated()
        {
            sqrtValues = new double[MaxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = Math.Sqrt(i);
            }
        }
        //static method
        public static double GetSqrt(int value)
        {
            return sqrtValues[value];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SqrtPrecalculated.GetSqrt(360));
        }
    }
}
