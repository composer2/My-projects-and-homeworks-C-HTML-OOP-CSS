using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    //delegate declaration
    public delegate void SimpleDelegate(string param);
    public class DelegatesExample
    {
        private static void TestMethod(string param)
        {
            Console.WriteLine("I was called by delegate.");
            Console.WriteLine("I got parameter: {0}.",param);
        }

        private static void Main(string[] args)
        {
            //instantiate the delegate
            SimpleDelegate d = new SimpleDelegate(TestMethod);

            //the above can be written in a shorter way
            d = TestMethod;
            //invocation of the method, pointed by delegate
            d("HAHHAHAHAH");
        }
    }
}
