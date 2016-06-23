using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    public class OuterClass
    {
        private string name;

        private OuterClass(string name)
        {
            this.name = name;
        }

        private class NestedClass
        {
            private string name;
            private OuterClass parent;

            public NestedClass(OuterClass parent, string name)
            {
                this.parent = parent;
                this.name = name;
            }
            public void PrintNames()
            {
                Console.WriteLine("Nested name: {0}",this.name);
                Console.WriteLine("Outer name: {0}", this.parent.name);

            }
        }

        static void Main(string[] args)
        {
            OuterClass outerClass = new OuterClass("outer");
            NestedClass nestedCLass = new OuterClass.NestedClass(outerClass, "nested");
            nestedCLass.PrintNames();
        }
    }
}
