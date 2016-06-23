    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modifiers
{
    class ConstReadonlyModifiersTest
    {
        public const double PI = 3.1415926535897932385;
        public readonly double size;

        public ConstReadonlyModifiersTest(int size)
        {
            this.size = size;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.WriteLine(ConstReadonlyModifiersTest.PI);
            ConstReadonlyModifiersTest test = new ConstReadonlyModifiersTest(5);
            Console.WriteLine(test.size);
        }
    }
}
