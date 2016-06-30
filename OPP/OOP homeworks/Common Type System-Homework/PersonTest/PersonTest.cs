using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTest
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Bob Dilan", 21);
            var p2 = new Person("Rob Rilan");//no age

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
