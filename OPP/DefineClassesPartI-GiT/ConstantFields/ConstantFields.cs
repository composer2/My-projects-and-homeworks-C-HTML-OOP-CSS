using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantFields
{
    class Constants
    {
        public const double PI= 3.1415926535897932385;
        public readonly double Size;

        public Constants (int size)
        {
            this.Size = size;// Cannot be further modified!
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.PI);
            Constants c = new Constants(5);
            Console.WriteLine(c.Size);
            //c.Size = 10; // Compilation error: readonly field
            //Console.WriteLine(Constants.Size); // compile error
        }
    }
}
