using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            var str = "Hello Extension Methods";
            Console.WriteLine(str.WordCount());

            var ints = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ints.ToString());
            Console.WriteLine(ints.ToString<int>());

            ints.IncreaseInput(5);
            Console.WriteLine(ints.ToString<int>());
        }
    }
}
