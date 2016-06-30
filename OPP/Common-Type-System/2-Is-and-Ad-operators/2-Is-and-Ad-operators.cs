using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Is_and_Ad_operators
{
    class Base { }

    class Derived : Base { }

    class PalyWithOperatorsIsAndAs
    {
        static void Main(string[] args)
        {
            Object objBase = new Base();
            if (objBase is Base)
            {
                Console.WriteLine("Im base");
            }
            if (objBase is Derived)
            {
                Console.WriteLine("obj isnt derived");
            }

            if (objBase is System.Object)
            {
                Console.WriteLine("Im part of System.Object");
            }

            // "dynamic" is internally System.Object
            // but with runtime binding of the operations
            if (objBase is dynamic)
            {
                Console.WriteLine("Im dynamic too");
            }

            Base b = objBase as Base;
            Console.WriteLine("b = {0}",b);

            Derived d = objBase as Derived;
            if (d==null)
            {
                Console.WriteLine("d is null");
            }

            Object o = objBase as object;
            Console.WriteLine("o = {0}",o);

            Derived der = new Derived();
            Base bas = der as Base;
            Console.WriteLine("bas = {0}",bas);

            Object dyn = objBase as dynamic;
            Console.WriteLine("dyn = {0}",dyn);
        }
    }
}
