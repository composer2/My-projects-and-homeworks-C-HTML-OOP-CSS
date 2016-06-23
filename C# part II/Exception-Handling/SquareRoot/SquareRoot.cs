using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                double num = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(num);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                Console.WriteLine("{0:f3}",result);
                }
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
