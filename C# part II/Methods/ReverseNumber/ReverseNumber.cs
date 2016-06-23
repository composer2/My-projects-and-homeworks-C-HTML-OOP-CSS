using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNum(n));
        }
        static string ReverseNum(decimal n)
        {
            string reversed = "";
            string number = Convert.ToString(n);
            for (int i = 0; i < number.Length; i++)
            {
                reversed = number[i] + reversed;
            }
            return reversed;
        }
    }
}