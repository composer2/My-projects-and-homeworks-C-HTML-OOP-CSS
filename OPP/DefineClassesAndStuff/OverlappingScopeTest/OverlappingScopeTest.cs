using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingScopeTest
{
    class OverlappingScopeTest
    {
        int myValue = 3;

        public void PrintMyValue()
        {
            int myValue = 5;
            Console.WriteLine("My value is: {0}",myValue);
            Console.WriteLine("My value is: {0}",this.myValue);
        }

        static void Main(string[] args)
        {
            OverlappingScopeTest instance = new OverlappingScopeTest();
            instance.PrintMyValue();
        }
    }
}
